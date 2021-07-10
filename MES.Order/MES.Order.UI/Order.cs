using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DataProcessing;
using DevExpress.Utils.Extensions;
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
        private readonly List<AddOrderViewModel>  addOrderView    = new List<AddOrderViewModel>();
        private readonly WhetherGetStock          whetherGetStock = new WhetherGetStock();
        private readonly List<KeyAndNameForCombo> whetherCombos   = new List<KeyAndNameForCombo>();
        private readonly List<ProductsOrder>      focusOrders     = new List<ProductsOrder>();
        private          List<ProductsOrder>      productsOrders  = new List<ProductsOrder>();
        private          List<ProductsOrder>      UpdateproductsOrders;
        private          ProductsOrderUCO         ProductsOrderUCO;
        private          List<KeyAndNameForCombo> mProductList;
        private          List<KeyAndNameForCombo> mCustomerList;
        private          List<KeyAndNameForCombo> mVerdorList;
        private          List<KeyAndNameForCombo> mAreaList;
        private          List<ProductsInfomation> mProductsInfomation;

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
        }

        #region Initial

        public void InitialControls()
        {
            this.InitialArea();
            this.InitialProductGroupID();
            this.InitialCusomterName();
            this.InitialProductName();
            this.InitialWhetherStock();
            this.InitialProductInformation();
            this.dateEdit_OrderDateS.DateTime              = DateTime.Today.AddDays(-3);
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

        private void InitialProductInformation()
        {
            this.mProductsInfomation = this.ProductsOrderUCO.GetProductPrice(@"*ALL", @"*ALL");
        }

        private void InitialProductName()
        {
            this.mProductList                                 = this.ProductsOrderUCO.GetProductName("*ALL");
            this.lookUpEdit_ProductName.Properties.DataSource = this.mProductList;
            this.LookUpEdit_addProductName.Properties.DataSource =
                this.mProductList.Where(x => x.Code != "*ALL").ToList();
            this.lookUpEdit_ProductName.EditValue = @"*ALL";
        }

        private void InitialCusomterName()
        {
            this.mCustomerList                                    = this.ProductsOrderUCO.GetCustomerName("*ALL");
            this.lookUpEdit_CustomerName.Properties.DataSource    = this.mCustomerList;
            this.LookUpEdit_addCustomerName.Properties.DataSource = this.mCustomerList;
            this.lookUpEdit_CustomerName.EditValue                = @"*ALL";
        }

        private void InitialProductGroupID()
        {
            this.mVerdorList                                        = this.ProductsOrderUCO.GetProductGroupID();
            this.lookUpEdit_ProductGroupID.Properties.DataSource    = this.mVerdorList;
            this.lookUpEdit_addProductGroupID.Properties.DataSource = this.mVerdorList;
            this.lookUpEdit_ProductGroupID.EditValue                = @"*ALL";
            this.lookUpEdit_addProductGroupID.EditValue             = @"*ALL";
        }

        private void InitialArea()
        {
            this.mAreaList                                = this.ProductsOrderUCO.GetArea();
            this.lookUpEdit_Area.Properties.DataSource    = this.mAreaList;
            this.lookUpEdit_addArea.Properties.DataSource = this.mAreaList;
            this.lookUpEdit_Area.EditValue                = @"*ALL";
            this.lookUpEdit_addArea.EditValue             = @"*ALL";
        }

        private void InitialUCO()
        {
            this.ProductsOrderUCO    = new ProductsOrderUCO();
            this.mProductList        = new List<KeyAndNameForCombo>();
            this.mCustomerList       = new List<KeyAndNameForCombo>();
            this.mVerdorList         = new List<KeyAndNameForCombo>();
            this.mAreaList           = new List<KeyAndNameForCombo>();
            this.mProductsInfomation = new List<ProductsInfomation>();
        }

        #endregion

        #region Button Event

        /// <summary>
        /// 查詢
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            var CurrentList = this.productsOrderBindingSource.DataSource as List<ProductsOrder>;
            var checkedList = CurrentList.Where(x => x.Note3 == "True").ToList();
            var deleteList  = new List<ProductsOrder>();
            var dialogResult = MessageBox.Show(@"是否確認刪除 " + checkedList.Count + @"筆資料?", @"提醒",
                                               MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            foreach (var row in checkedList)
            {
                deleteList.Add(row);
                this.focusOrders.Remove(x => x.AutoID == row.AutoID);
            }

            this.gridControl_FocusOrder.RefreshDataSource();
            this.xtraTabPage2.Text = string.Concat(@"拉單 共 ", this.focusOrders.Count, @" 筆");

            var actualDeleteCount = this.ProductsOrderUCO.DeleteOrders(deleteList);
            if (actualDeleteCount == deleteList.Count)
            {
                var stringBuilder = new StringBuilder();
                foreach (var item in deleteList)
                {
                    stringBuilder.AppendLine(item.CustomName + @":" + item.ProductName);
                }

                MessageBox.Show(@"已經[刪除]的名單=>" + Environment.NewLine + stringBuilder, @"提醒",
                                MessageBoxButtons.YesNo);
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
            var                 CurrentList = this.productsOrderBindingSource.DataSource as List<ProductsOrder>;
            var                 checkedList = CurrentList.Where(x => x.Note3 == "True").ToList();
            List<ProductsOrder> updateList  = new List<ProductsOrder>();
            var dialogResult = MessageBox.Show(@"是否確認鎖定 " + checkedList.Count + @"筆資料?", @"提醒",
                                               MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            //已有"是否取貨"的資料
            var haveData = checkedList
                           .Where(x => x.Address.Contains(@"已取貨"))
                           .ToList();

            //還沒有"是否取貨"的資料
            var noData = checkedList.Where(x => string.IsNullOrEmpty(x.Address)).ToList();

            foreach (var item in haveData)
            {
                this.focusOrders.AddOrReplace(x => x.AutoID == item.AutoID, item);
            }

            foreach (var item in noData)
            {
                item.Address = this.whetherGetStock.Get.Code;
                updateList.Add(item);
                this.focusOrders.AddOrReplace(x => x.AutoID == item.AutoID, item);
            }

            this.gridControl_FocusOrder.RefreshDataSource();
            this.pivotGrid_FocusOrder.RefreshData();
            this.ProductsOrderUCO.UpdateOrders(updateList);
            this.xtraTabPage2.Text = string.Concat(@"拉單 共 ", this.focusOrders.Count, @" 筆");
            this.btn_Query.PerformClick();
        }

        /// <summary>
        /// 匯出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Export_Click(object sender, EventArgs e)
        {
            // this.gridControl_FocusOrder.ShowPrintPreview();
            this.pivotGrid_FocusOrder.ShowPrintPreview();
        }

        /// <summary>
        /// 頁籤改變時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            var                 CurrentList = this.FocusbindingSource.DataSource as List<ProductsOrder>;
            var                 checkedList = CurrentList.Where(x => x.Note3 == "True").ToList();
            List<ProductsOrder> updateList  = new List<ProductsOrder>();
            var dialogResult = MessageBox.Show(@"是否確認要清除鎖定 " + checkedList.Count + @"筆資料?", "提醒",
                                               MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            foreach (var item in checkedList)
            {
                item.Address = @"";
                updateList.Add(item);
                this.focusOrders.Remove(item);

                this.gridControl_FocusOrder.RefreshDataSource();
            }

            var updateOrders = this.ProductsOrderUCO.UpdateOrders(updateList);
            if (updateOrders == updateList.Count)
            {
                var stringBuilder = new StringBuilder();
                foreach (var item in updateList)
                {
                    stringBuilder.AppendLine(item.CustomName + @":" + item.ProductName);
                }

                MessageBox.Show(@"已經[解除鎖定]的名單=>" + Environment.NewLine + stringBuilder, @"提醒",
                                MessageBoxButtons.YesNo);
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

        /// <summary>
        /// 是否要群組計算數量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toggleSwitch_GroupColumn_Toggled(object sender, EventArgs e)
        {
            if (this.toggleSwitch_GroupColumn.IsOn)
            {
                this.colArea.GroupIndex = 0;
            }
            else
            {
                this.colArea.GroupIndex = -1;
            }

            this.gridView_ProductOrder.BestFitColumns();
        }

        #endregion

        #region About Query Event

        /// <summary>
        /// 查詢地區=>變更地區值時，跟著變動客戶
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lookUpEdit_Area_EditValueChanged(object sender, EventArgs e)
        {
            var Area   = this.lookUpEdit_Area.EditValue.ToString();
            var result = this.mCustomerList.Where(x => x.LocalDescription == Area).ToList();
            this.lookUpEdit_CustomerName.Properties.DataSource = result;
        }

        /// <summary>
        /// 查詢廠商=>變更廠商值時，跟著變動產品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lookUpEdit_ProductGroupID_EditValueChanged(object sender, EventArgs e)
        {
            var ProductGroupID = this.lookUpEdit_ProductGroupID.EditValue.ToString();
            var result         = this.mProductList.Where(x => x.LocalDescription == ProductGroupID).ToList();
            this.lookUpEdit_ProductName.Properties.DataSource = result;
        }

        #endregion

        #region About Add Event

        /// <summary>
        /// 新增地區=>變更地區值時，跟著變動客戶
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lookUpEdit_addArea_EditValueChanged(object sender, EventArgs e)
        {
            var addArea = this.lookUpEdit_addArea.EditValue.ToString();
            var result  = this.mCustomerList.Where(x => x.LocalDescription == addArea).ToList();
            this.LookUpEdit_addCustomerName.Properties.DataSource = result;
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
                var selectedDataRow = this.LookUpEdit_addCustomerName.GetSelectedDataRow() as KeyAndNameForCombo;
                this.addOrderView[0].Area = selectedDataRow?.LocalDescription;
            }
        }

        /// <summary>
        /// 新增廠商=>變更廠商值時，跟著變動產品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lookUpEdit_addProductGroupID_EditValueChanged(object sender, EventArgs e)
        {
            var addProductGroupID = this.lookUpEdit_addProductGroupID.EditValue.ToString();
            var result            = this.mProductList.Where(x => x.LocalDescription == addProductGroupID).ToList();
            this.LookUpEdit_addProductName.Properties.DataSource = result;
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
                var result = this.mProductsInfomation.FirstOrDefault(x => x.ProductName == addProductName);
                if (result != null)
                {
                    addOrderViewModel.ProductGroupID = result.ProductGroupID;
                    addOrderViewModel.Price          = result.Price;
                    addOrderViewModel.Cost           = result.Cost;
                }

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

        #endregion

        #region About Update Event

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

                this.focusOrders.AddOrReplace(x => x.AutoID == productsOrder.AutoID, productsOrder);
                this.gridControl_FocusOrder.RefreshDataSource();
            }
        }

        /// <summary>
        /// 點選備註的值改變時，自動Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repository_Note_EditValueChanged(object sender, EventArgs e)
        {
            var textEdit = sender as TextEdit;
            this.UpdateproductsOrders = new List<ProductsOrder>();
            var productsOrder = this.productsOrderBindingSource.Current as ProductsOrder;
            if (textEdit != null & productsOrder != null)
            {
                productsOrder.Note1      = textEdit.Text;
                productsOrder.UpdateDate = DateTime.Now;
                productsOrder.SetDefaultValue();
                this.UpdateproductsOrders.Add(productsOrder);
                this.ProductsOrderUCO.UpdateOrders(this.UpdateproductsOrders);

                this.focusOrders.AddOrReplace(x => x.AutoID == productsOrder.AutoID, productsOrder);
                this.gridControl_FocusOrder.RefreshDataSource();
            }
        }

        /// <summary>
        /// 點選數量的值改變時，自動Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repository_Count_EditValueChanged(object sender, EventArgs e)
        {
            var spinEdit = sender as SpinEdit;
            this.UpdateproductsOrders = new List<ProductsOrder>();
            var productsOrder = this.productsOrderBindingSource.Current as ProductsOrder;
            if (spinEdit != null & productsOrder != null)
            {
                productsOrder.Count      = (int) spinEdit.Value;
                productsOrder.UpdateDate = DateTime.Now;
                var productsInfomations =
                    this.ProductsOrderUCO.GetProductPrice(productsOrder.ProductGroupID, productsOrder.ProductName);
                if (productsInfomations.Count == 0)
                {
                    throw new Exception("在編輯數量的時候，查詢此產品時未找到此" + productsOrder.ProductName + "的相關資料!");
                }

                productsOrder.TotalPrice  = (int) spinEdit.Value * productsInfomations[0].Price;
                productsOrder.TotalCost   = (int) spinEdit.Value * productsInfomations[0].Cost;
                productsOrder.TotalProfit = (int) spinEdit.Value * productsInfomations[0].Profit;
                productsOrder.SetDefaultValue();
                this.UpdateproductsOrders.Add(productsOrder);
                this.ProductsOrderUCO.UpdateOrders(this.UpdateproductsOrders);

                this.focusOrders.AddOrReplace(x => x.AutoID == productsOrder.AutoID, productsOrder);
                this.gridControl_FocusOrder.RefreshDataSource();
            }
        }

        #endregion
    }
}