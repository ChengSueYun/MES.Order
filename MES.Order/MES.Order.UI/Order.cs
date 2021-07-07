using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using DevExpress.XtraEditors;
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
        private readonly WhetherGetStock          whetherGetStock       = new WhetherGetStock();
        private readonly List<KeyAndNameForCombo> whetherCombos         = new List<KeyAndNameForCombo>();
        List<string>                              filterProductNameList = new List<string>();
        List<string>                              filterCustomList      = new List<string>();

        public Order()
        {
            this.InitializeComponent();
            this.InitialUCO();
            this.InitialControls();
        }

        #region Initial

        private void InitialControls()
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
            this.lookUpEdit_ProductName.Properties.DataSource = result;
            this.lookUpEdit_ProductName.EditValue             = "*ALL";
            ;
            this.LookUpEdit_addProductName.Properties.DataSource = result.Where(x => x.Code != "*ALL").ToList();
        }

        private void InitialCusomterName()
        {
            var result = this.ProductsOrderUCO.GetCustomerName("*ALL");
            this.lookUpEdit_CustomerName.Properties.DataSource    = result;
            this.lookUpEdit_CustomerName.EditValue                = "*ALL";
            this.LookUpEdit_addCustomerName.Properties.DataSource = result.Where(x => x.Code != "*ALL").ToList();
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
            this.lookUpEdit_addArea.Properties.DataSource = result.Where(x => x.Code != "*ALL").ToList();
        }

        private void InitialUCO()
        {
            this.ProductsOrderUCO = new ProductsOrderUCO();
        }

        #endregion

        #region Button Event

        private void btn_Query_Click(object sender, EventArgs e)
        {
            var Area = this.lookUpEdit_Area.EditValue.ToString();
            var CusomerName    = this.lookUpEdit_CustomerName.EditValue.ToString();
            var ProductGroupID = this.lookUpEdit_ProductGroupID.EditValue.ToString();
            var ProductName    = this.lookUpEdit_ProductName.EditValue.ToString();
            var OrderDateS = this.dateEdit_OrderDateS.DateTime;
            var OrderDateE = this.dateEdit_OrderDateE.DateTime;
            this.productsOrders =
                this.ProductsOrderUCO.QueryAllOrders(Area, ProductGroupID, CusomerName, ProductName, OrderDateS,
                                                     OrderDateE);
            this.productsOrderBindingSource.DataSource = this.productsOrders;

            this.gridView_ProductOrder.BestFitColumns();
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
            keyAndNameForCombos.RemoveAt(0);
            this.LookUpEdit_addCustomerName.Properties.DataSource = keyAndNameForCombos;
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
                addOrderViewModel.Price      = productsInfomation.Price.Value;
                addOrderViewModel.Cost       = productsInfomation.Cost.Value;
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
            try
            {
                var saveOrders = new List<ProductsOrder>();
                DefaultMapper.Map(this.addOrderView, saveOrders);
                var actualSaveCount = this.ProductsOrderUCO.SaveOrders(saveOrders);
                foreach (var item in saveOrders)
                {
                    alertControl1.Show(this.ParentForm, "存檔訊息",
                                       "已存檔 " + Environment.NewLine + item.CustomName + ":" + item.ProductName);
                }

                this.productsOrders = this
                                      .ProductsOrderUCO.QueryAllOrders("*ALL", "*ALL", "*ALL", "*ALL",
                                                                       DateTime.Today, DateTime.Today)
                                      .OrderByDescending(x => x.AutoID).ToList();
                this.productsOrderBindingSource.DataSource = this.productsOrders;
            }
            catch (Exception exception)
            {
                throw new Exception("btn_Save_Click 存檔發生錯誤" + exception);
            }
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = this.gridView_ProductOrder.GetSelectedRows();
                var deleteList   = new List<ProductsOrder>();
                this.productsOrders = this.productsOrders.OrderByDescending(x => x.AutoID).ToList();
                foreach (var row in selectedRows)
                {
                    var deleteRow = new ProductsOrder();

                    deleteRow = this.productsOrders[row];
                    deleteList.Add(deleteRow);
                }

                var actualDeleteCount = this.ProductsOrderUCO.DeleteOrders(deleteList);
                foreach (var item in deleteList)
                {
                    alertControl1.Show(this.ParentForm, "刪除訊息",
                                       "已刪除 " + Environment.NewLine + item.CustomName + ":" + item.ProductName);
                }

                this.btn_Query.PerformClick();
            }
            catch (Exception exception)
            {
                throw new Exception("btn_Cancel_Click 刪除發生錯誤" + exception.ToString());
            }
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
            foreach (var item in Selected)
            {
                CurrentList[item].Address = "Y:" + DateTime.Today.ToSimpleTaiwanCalendar() + " 已取貨";
                updateList.Add(CurrentList[item]);
                if (this.FocusData.All(x => x.AutoID != CurrentList[item].AutoID))
                {
                    this.FocusData.Add(CurrentList[item]);
                }
            }

            this.ProductsOrderUCO.UpdateOrders(updateList);

            foreach (var item in updateList)
            {
                alertControl1.Show(this.ParentForm, "鎖定訊息",
                                   "已鎖定 " + Environment.NewLine + item.CustomName + ":" + item.ProductName);
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
            saveFileDialog1.Filter   = @"Excel|*.xls|Word|*.docx";
            saveFileDialog1.FileName = DateTime.Today.ToString("yyyyMMdd") + "拉單";
            saveFileDialog1.ShowDialog();

            // this.tileView_FocusOrder.ExportToDocx(saveFileDialog1.FileName);
            Process.Start(saveFileDialog1.FileName);
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

        #endregion

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            // if (this.toggleSwitch1.EditValue.ToString() == "True")
            // {
            //     gridControl_FocusOrder.Visible     = true;
            //     FocusData                          = new List<ProductsOrder>();
            //     this.FocusbindingSource.DataSource = FocusData;
            // }
            // else
            // {
            //     gridControl_FocusOrder.Visible = false;
            // }
        }

        public List<ProductsOrder> FocusData { get; set; }



    }
}