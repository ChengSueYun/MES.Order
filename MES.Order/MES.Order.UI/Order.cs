using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using MES.Order.BLL;
using MES.Order.DAL.EntityFramework;
using THS.Infrastructure.Extensions;
using MES.Order.DAL.ViewModel;
using MES.Order.UI.Mappers;
using MES.Order.UI.Module;

namespace MES.Order.UI
{
    public partial class Order : XtraUserControl
    {
        private readonly List<AddOrderViewModel>  addOrderView   = new List<AddOrderViewModel>();
        private          List<ProductsOrder>      productsOrders = new List<ProductsOrder>();
        private          List<ProductsOrder>      UpdateproductsOrders;
        private          ProductsOrderUCO         ProductsOrderUCO;
        private readonly WhetherGetStock          whetherGetStock = new WhetherGetStock();
        private readonly List<KeyAndNameForCombo> whetherCombos   = new List<KeyAndNameForCombo>();
        List<ProductsOrder>                       focusOrders     = new List<ProductsOrder>();
        private string                            queryArea;

        public Order()
        {
            this.InitializeComponent();
            try
            {
                this.InitialUCO();
                this.InitialControls();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void Order_Enter(object sender, EventArgs e)
        {
            this.InitialArea();
            this.InitialProductGroupID();
            this.InitialCusomterName();
            this.InitialProductName();
            this.InitialWhetherStock();
        }

        #region Initial

        public void InitialControls()
        {
            this.InitialArea();
            this.InitialProductGroupID();
            this.InitialCusomterName();
            this.InitialProductName();
            this.InitialWhetherStock();
            this.dateEdit_OrderDateS.DateTime              = DateTime.Today.AddDays(-15);
            this.dateEdit_OrderDateE.DateTime              = DateTime.Today;
            this.addOrderViewModelBindingSource.DataSource = this.addOrderView;
            this.addOrderViewModelBindingSource.AddNew();
            this.FocusbindingSource.DataSource = this.focusOrders;
        }

        private void InitialWhetherStock()
        {
            this.whetherGetStock.SetDefaultValue();
            this.whetherCombos.Add(this.whetherGetStock.Get);
            this.whetherCombos.Add(this.whetherGetStock.unGet);
            this.whetherCombos.Add(this.whetherGetStock.AllNone);

            this.repository_WhetherStock.DataSource = this.whetherCombos;
        }

        private void InitialProductName()
        {
            var result = this.ProductsOrderUCO.GetProductName("*ALL");
            this.lookUpEdit_ProductName.Properties.DataSource    = result;
            this.lookUpEdit_ProductName.EditValue                = "*ALL";
            this.LookUpEdit_addProductName.Properties.DataSource = result.Where(x => x.Code != "*ALL").ToList();

        }

        private void InitialCusomterName()
        {
            var result = this.ProductsOrderUCO.GetCustomerName("*ALL");
            this.lookUpEdit_CustomerName.Properties.DataSource    = result;
            this.lookUpEdit_CustomerName.EditValue                = "*ALL";
            // this.LookUpEdit_addCustomerName.Properties.DataSource = result.Where(x => x.Code != "*ALL").ToList();
            this.LookUpEdit_addCustomerName.Properties.DataSource = result;

        }

        private void InitialProductGroupID()
        {
            var result = this.ProductsOrderUCO.GetProductGroupID();
            this.lookUpEdit_ProductGroupID.Properties.DataSource    = result;
            this.lookUpEdit_ProductGroupID.EditValue                = "*ALL";
            this.lookUpEdit_addProductGroupID.Properties.DataSource = result.Where(x => x.Code != "*ALL").ToList();
        }

        private void InitialArea()
        {
            var result = this.ProductsOrderUCO.GetArea();
            this.lookUpEdit_Area.Properties.DataSource    = result;
            this.lookUpEdit_Area.EditValue                = "*ALL";
            this.lookUpEdit_addArea.Properties.DataSource = result;

            // this.lookUpEdit_addArea.Properties.DataSource = result.Where(x => x.Code != "*ALL").ToList();
        }

        private void InitialUCO()
        {
            this.ProductsOrderUCO = new ProductsOrderUCO();
        }

        #endregion

        #region Button Event

        private void btn_Query_Click(object sender, EventArgs e)
        {
            var Area           = this.lookUpEdit_Area.EditValue.ToString();
            var CusomerName    = this.lookUpEdit_CustomerName.EditValue.ToString();
            var ProductGroupID = this.lookUpEdit_ProductGroupID.EditValue.ToString();
            var ProductName    = this.lookUpEdit_ProductName.EditValue.ToString();
            var OrderDateS     = this.dateEdit_OrderDateS.DateTime;
            var OrderDateE     = this.dateEdit_OrderDateE.DateTime;
            this.productsOrders =
                this.ProductsOrderUCO.QueryAllOrders(Area, ProductGroupID, CusomerName, ProductName, OrderDateS,
                                                     OrderDateE).OrderByDescending(x => x.AutoID).ToList();

            this.productsOrderBindingSource.DataSource = this.productsOrders;
            this.gridView_ProductOrder.BestFitColumns();
            this.gridView_FocusOrder.BestFitColumns();
        }

        /// <summary>
        /// 查詢地區=>變更地區值時，跟著變動客戶
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lookUpEdit_Area_EditValueChanged(object sender, EventArgs e)
        {
            var Area = this.lookUpEdit_Area.EditValue.ToString();
            this.lookUpEdit_CustomerName.Properties.DataSource = this.ProductsOrderUCO.GetCustomerName(Area);
        }

        /// <summary>
        /// 新增地區=>變更地區值時，跟著變動客戶
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lookUpEdit_addArea_EditValueChanged(object sender, EventArgs e)
        {
            var addArea             = this.lookUpEdit_addArea.EditValue.ToString();
            var keyAndNameForCombos = this.ProductsOrderUCO.GetCustomerName(addArea);
            this.LookUpEdit_addCustomerName.Properties.DataSource = keyAndNameForCombos;
        }

        /// <summary>
        /// 新增客戶=>變更客戶值時，跟著變動地區
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LookUpEdit_addCustomerName_EditValueChanged(object sender, EventArgs e)
        {
            var addCustomer = this.LookUpEdit_addCustomerName.EditValue.ToString();
            if (!string.IsNullOrWhiteSpace(addCustomer))
            {
                this.queryArea       = this.ProductsOrderUCO.QuerySpecifcName(addCustomer);
                addOrderView[0].Area = this.queryArea;
                if (!string.IsNullOrWhiteSpace(this.queryArea))
                {
                    this.lookUpEdit_addArea.EditValue = this.queryArea;
                }
            }
        }

        /// <summary>
        /// 查詢廠商=>變更廠商值時，跟著變動產品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lookUpEdit_ProductGroupID_EditValueChanged(object sender, EventArgs e)
        {
            var ProductGroupID = this.lookUpEdit_ProductGroupID.EditValue.ToString();
            this.lookUpEdit_ProductName.Properties.DataSource = this.ProductsOrderUCO.GetProductName(ProductGroupID);
        }

        /// <summary>
        /// 新增廠商=>變更廠商值時，跟著變動產品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lookUpEdit_addProductGroupID_EditValueChanged(object sender, EventArgs e)
        {
            var addProductGroupID   = this.lookUpEdit_addProductGroupID.EditValue.ToString();
            var keyAndNameForCombos = this.ProductsOrderUCO.GetProductName(addProductGroupID);
            keyAndNameForCombos.RemoveAt(0);
            this.LookUpEdit_addProductName.Properties.DataSource =
                keyAndNameForCombos;
        }

        /// <summary>
        /// 新增產品=>變更產品值時，抓取成本、售價等資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LookUpEdit_addProductName_EditValueChanged(object sender, EventArgs e)
        {
            var addProductName = this.LookUpEdit_addProductName.EditValue.ToString();
            if (this.addOrderViewModelBindingSource.Current is AddOrderViewModel addOrderViewModel)
            {
                var productsInfomation =
                    this.ProductsOrderUCO.GetProductPrice(addOrderViewModel.ProductGroupID,
                                                          addProductName)[0];
                addOrderViewModel.Price      = productsInfomation.Price;
                addOrderViewModel.Cost       = productsInfomation.Cost;
                this.spinEdit_addCount.Value = 0;
            }
        }

        /// <summary>
        /// 新增數量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spinEdit_addCount_EditValueChanged(object sender, EventArgs e)
        {
            var addCount = Convert.ToInt16(this.spinEdit_addCount.Value);
            if (this.addOrderViewModelBindingSource.Current is AddOrderViewModel addOrderViewModel)
            {
                addOrderViewModel.Count = addCount;
                addOrderViewModel.SetDefaultValue();
                this.textEdit_addTotalPrice.Text = addOrderViewModel.TotalPrice.ToString();
            }
        }

        /// <summary>
        /// 存檔
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            var saveOrders = new List<ProductsOrder>();
            DefaultMapper.Map(this.addOrderView, saveOrders);
            foreach (var productsOrder in saveOrders)
            {
                productsOrder.SetDefaultValue();
            }

            var actualSaveCount = this.ProductsOrderUCO.SaveOrders(saveOrders);
            if (actualSaveCount == saveOrders.Count)
            {
                foreach (var item in saveOrders)
                {
                    this.alertControl1.Show(this.ParentForm, "存檔訊息",
                                            "已存檔 " + Environment.NewLine + item.CustomName + ":" + item.ProductName);
                }
            }
            else
            {
                throw new Exception("btn_Save_Click 存檔發生錯誤");
            }

            this.addOrderView.Clear();
            this.productsOrders = this
                                  .ProductsOrderUCO.QueryAllOrders("*ALL", "*ALL", "*ALL", "*ALL",
                                                                   DateTime.Today, DateTime.Today)
                                  .OrderByDescending(x => x.AutoID).ToList();
            this.productsOrderBindingSource.DataSource = this.productsOrders;
            this.textEdit_addNote1.Text                = "";
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            var selectedRows = this.gridView_ProductOrder.GetSelectedRows();
            var deleteList   = new List<ProductsOrder>();
            this.productsOrders = this.productsOrders.OrderByDescending(x => x.AutoID).ToList();
            var dialogResult = MessageBox.Show(@"是否確認刪除 " + selectedRows.Length.ToString() + @"筆資料?", @"提醒",
                                               MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            foreach (var row in selectedRows)
            {
                var deleteRow = new ProductsOrder();

                deleteRow = this.productsOrders[row];
                deleteList.Add(deleteRow);
            }

            var actualDeleteCount = this.ProductsOrderUCO.DeleteOrders(deleteList);
            if (actualDeleteCount == deleteList.Count)
            {
                MessageBox.Show(@"已刪除 " + actualDeleteCount + @"筆資料", @"刪除訊息",
                                MessageBoxButtons.YesNo);

                // foreach (var item in deleteList)
                // {
                //     this.alertControl1.Show(this.ParentForm, "刪除訊息",
                //                             "已刪除 " + Environment.NewLine + item.CustomName + ":" +
                //                             item.ProductName);
                // }
            }
            else
            {
                throw new Exception("btn_Cancel_Click 刪除發生錯誤");
            }

            this.btn_Query.PerformClick();
        }

        /// <summary>
        /// 鎖定列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_FocusRow_Click(object sender, EventArgs e)
        {
            var Selected    = this.gridView_ProductOrder.GetSelectedRows();
            var CurrentList = this.productsOrderBindingSource.DataSource as List<ProductsOrder>;
            CurrentList = CurrentList.OrderByDescending(x => x.AutoID).ToList();
            List<ProductsOrder> updateList = new List<ProductsOrder>();
            var dialogResult = MessageBox.Show(@"是否確認鎖定 " + Selected.Length.ToString() + @"筆資料?", "提醒",
                                               MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            foreach (var item in Selected)
            {
                CurrentList[item].Address = "Y:" + DateTime.Today.ToSimpleTaiwanCalendar() + " 已取貨";
                updateList.Add(CurrentList[item]);
                if (this.focusOrders.All(x => x.AutoID != CurrentList[item].AutoID))
                {
                    this.focusOrders.Add(CurrentList[item]);
                }

                this.FocusbindingSource.DataSource = this.focusOrders;
                this.gridControl_FocusOrder.RefreshDataSource();
            }

            var updateOrders = this.ProductsOrderUCO.UpdateOrders(updateList);
            if (updateOrders == updateList.Count)
            {
                MessageBox.Show(@"已鎖定 " + updateOrders + @"筆資料", @"鎖定訊息",
                                MessageBoxButtons.YesNo);

                // foreach (var item in updateList)
                // {
                //     this.alertControl1.Show(this.ParentForm, "鎖定訊息",
                //                             "已鎖定 " + Environment.NewLine + item.CustomName + ":" + item.ProductName);
                // }

                this.xtraTabPage2.Text = string.Concat(@"拉單 共 ", this.focusOrders.Count, @" 筆");
            }
            else
            {
                throw new Exception("btn_FocusRow_Click 鎖定列發生錯誤");
            }

            this.btn_Query.PerformClick();
        }

        /// <summary>
        /// 匯出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Export_Click(object sender, EventArgs e)
        {
            this.gridControl_FocusOrder.ShowPrintPreview();
        }

        /// <summary>
        /// 點選是否取貨時，直接update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repository_WhetherStock_EditValueChanged(object sender, EventArgs e)
        {
            var textEdit = sender as TextEdit;
            this.UpdateproductsOrders = new List<ProductsOrder>();
            var productsOrder = this.productsOrderBindingSource.Current as ProductsOrder;
            if (textEdit != null & productsOrder != null)
            {
                productsOrder.Address    = textEdit.Text;
                productsOrder.UpdateDate = DateTime.Now;
                productsOrder.SetDefaultValue();
                this.UpdateproductsOrders.Add(productsOrder);
                this.ProductsOrderUCO.UpdateOrders(this.UpdateproductsOrders);
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page.TabIndex == 1)
            {
                this.btn_UnFocus.Visible  = true;
                this.btn_UnFocus.Enabled  = true;
                this.btn_Save.Visible     = false;
                this.btn_Cancel.Visible   = false;
                this.btn_FocusRow.Visible = false;
                this.btn_FocusRow.Enabled = false;
            }
            else
            {
                this.btn_UnFocus.Visible  = false;
                this.btn_UnFocus.Enabled  = false;
                this.btn_Save.Visible     = true;
                this.btn_Cancel.Visible   = true;
                this.btn_FocusRow.Visible = true;
                this.btn_FocusRow.Enabled = true;
            }
        }

        /// <summary>
        /// 清除鎖定列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UnFocus_Click(object sender, EventArgs e)
        {
            var Selected    = this.gridView_FocusOrder.GetSelectedRows();
            var CurrentList = this.FocusbindingSource.DataSource as List<ProductsOrder>;
            CurrentList = CurrentList.OrderByDescending(x => x.AutoID).ToList();
            List<ProductsOrder> updateList = new List<ProductsOrder>();
            var dialogResult = MessageBox.Show(@"是否確認要清除鎖定 " + Selected.Length.ToString() + @"筆資料?", "提醒",
                                               MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            foreach (var item in Selected)
            {
                CurrentList[item].Address = "";
                updateList.Add(CurrentList[item]);

                this.focusOrders.Remove(CurrentList[item]);

                this.gridControl_FocusOrder.RefreshDataSource();
            }

            var updateOrders = this.ProductsOrderUCO.UpdateOrders(updateList);
            if (updateOrders == updateList.Count)
            {
                MessageBox.Show(@"已解除鎖定 " + updateOrders + @"筆資料", @"鎖定訊息",
                                MessageBoxButtons.YesNo);

                // foreach (var item in updateList)
                // {
                //     this.alertControl1.Show(this.ParentForm, "鎖定訊息",
                //                             "已解除鎖定 " + Environment.NewLine + item.CustomName + ":" + item.ProductName);
                // }

                this.xtraTabPage2.Text = string.Concat(@"拉單 共 ", this.focusOrders.Count, @" 筆");
            }
            else
            {
                throw new Exception("btn_UnFocus_Click 清除鎖定列發生錯誤");
            }

            this.btn_Query.PerformClick();
        }

        /// <summary>
        /// 熱鍵:鎖定列F1、清除鎖定列F2、存檔F5、刪除F3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Order_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    this.btn_Save.PerformClick();
                    break;
                case Keys.F1:
                    this.btn_FocusRow.PerformClick();
                    break;
                case Keys.F3:
                    this.btn_Cancel.PerformClick();
                    break;
                case Keys.F2:
                    this.btn_UnFocus.PerformClick();
                    break;
                case Keys.Enter:
                    this.btn_Query.PerformClick();
                    break;
            }
        }

        #endregion
    }
}