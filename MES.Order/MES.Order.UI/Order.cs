using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Data.Linq;
using DevExpress.PivotGrid.OLAP.AdoWrappers;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting.Native;
using MES.Order.BLL;
using MES.Order.DAL.EntityFramework;
using THS.Infrastructure.Extensions;

namespace MES.Order.UI
{
    public partial class Order : Form
    {
        private List<ProductsOrder> AddproductsOrders =
            new List<ProductsOrder>();

        private List<ProductsOrder> productsOrders = new List<ProductsOrder>();
        private ProductsOrderUCO ProductsOrderUCO;

        public Order()
        {
            this.InitializeComponent();
            this.InitialUCO();
            this.InitialControls();
        }

        private Dictionary<ProductsOrder, string> SetPickUpDate = new Dictionary<ProductsOrder, string>();

        #region Initial

        private void InitialControls()
        {
            this.InitialArea();
            this.InitialProductGroupID();
            this.InitialCusomterName();
            this.InitialProductName();
            this.dateEdit_OrderDateS.DateTime = DateTime.Today.AddDays(-15);
            this.dateEdit_OrderDateE.DateTime = DateTime.Today;
        }

        private void InitialProductName()
        {
            var result = this.ProductsOrderUCO.GetProductName("*ALL");
            this.lookUpEdit_ProductName.Properties.DataSource = result;
            this.lookUpEdit_ProductName.EditValue = "*ALL";
            this.repository_ProductName.DataSource = result.Where(x => x.Code != "*ALL").ToList();
        }

        private void InitialCusomterName()
        {
            var result = this.ProductsOrderUCO.GetCustomerName("*ALL");
            this.lookUpEdit_CustomerName.Properties.DataSource = result;
            this.lookUpEdit_CustomerName.EditValue = "*ALL";
            this.repository_CustomerName.DataSource = result.Where(x => x.Code != "*ALL").ToList();
            ;
        }

        private void InitialProductGroupID()
        {
            var result = this.ProductsOrderUCO.GetProductGroupID();
            this.lookUpEdit_ProductGroupID.Properties.DataSource = result;
            this.lookUpEdit_ProductGroupID.EditValue = "*ALL";
            this.repository_ProductGroupID.DataSource = result.Where(x => x.Code != "*ALL").ToList();
            ;
        }

        private void InitialArea()
        {
            var result = this.ProductsOrderUCO.GetArea();
            this.lookUpEdit_Area.Properties.DataSource = result;
            this.lookUpEdit_Area.EditValue = "*ALL";
            this.repository_Area.DataSource = result.Where(x => x.Code != "*ALL").ToList();
            ;
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
            var CusomerName = this.lookUpEdit_CustomerName.EditValue.ToString();
            var ProductGroupID = this.lookUpEdit_ProductGroupID.EditValue.ToString();
            var ProductName = this.lookUpEdit_ProductName.EditValue.ToString();
            var OrderDateS = this.dateEdit_OrderDateS.DateTime;
            var OrderDateE = this.dateEdit_OrderDateE.DateTime;

            this.productsOrders =
                this.ProductsOrderUCO.QueryAllOrders(Area, ProductGroupID, CusomerName, ProductName, OrderDateS,
                                                     OrderDateE);
            this.productsOrderBindingSource.DataSource = this.productsOrders;
            this.gridView_ProductOrder.BestFitColumns();
            this.gridView_AddProductOrder.BestFitColumns();
        }

        private void lookUpEdit_Area_EditValueChanged(object sender, EventArgs e)
        {
            var Area = this.lookUpEdit_Area.EditValue.ToString();
            this.lookUpEdit_CustomerName.Properties.DataSource = this.ProductsOrderUCO.GetCustomerName(Area);
        }

        private void lookUpEdit_ProductGroupID_EditValueChanged(object sender, EventArgs e)
        {
            var ProductGroupID = this.lookUpEdit_ProductGroupID.EditValue.ToString();
            this.lookUpEdit_ProductName.Properties.DataSource = this.ProductsOrderUCO.GetProductName(ProductGroupID);
        }

        private void repository_Area_EditValueChanged(object sender, EventArgs e)
        {
            var areaLookUpEdit = sender as LookUpEdit;
            this.gridView_AddProductOrder.SetFocusedRowCellValue(this.gridColumn_Area,
                                                                 areaLookUpEdit.EditValue.ToString());
            var result = this.ProductsOrderUCO.GetCustomerName(areaLookUpEdit.EditValue.ToString())
                             .Where(x => x.Code != "*ALL").ToList();
            this.gridColumn4.ColumnEdit = repository_CustomerName;
            this.repository_CustomerName.DataSource = result;

            this.gridView_AddProductOrder.SetFocusedRowCellValue(gridColumn10, DateTime.Today);
        }

        private void repository_ProductGroupID_EditValueChanged(object sender, EventArgs e)
        {
            var Productgroupid = sender as LookUpEdit;
            this.gridView_AddProductOrder.SetFocusedRowCellValue(this.gridColumn_ProductGroupID,
                                                                 Productgroupid.EditValue.ToString());
            var result = this.ProductsOrderUCO.GetProductName(Productgroupid.EditValue.ToString())
                             .Where(x => x.Code != "*ALL").ToList();
            this.repository_ProductName.DataSource = result;
        }

        private void repository_Count_EditValueChanged(object sender, EventArgs e)
        {
            var countSpinEdit = sender as CalcEdit;
            var count = countSpinEdit.Value;
            var current = this.AddproductsOrderBindingSource.Current;
            var ProductGroupID = ((ProductsOrder)current).ProductGroupID;
            var productName = ((ProductsOrder)current).ProductName;
            var result = this.ProductsOrderUCO.GetProductPrice(ProductGroupID, productName).FirstOrDefault();
            var resultTotalPrice = count * result.Price; //總售價
            this.gridView_AddProductOrder.SetFocusedRowCellValue(this.gridColumn_Price, result.Price);
            this.gridView_AddProductOrder.SetFocusedRowCellValue(this.gridColumn_TotalPrice, resultTotalPrice);

            var resultTotalCost = count * result.Cost; //總批價
            this.gridView_AddProductOrder.SetFocusedRowCellValue(this.gridColumn13, resultTotalCost);

            var totalProfit = resultTotalPrice - resultTotalCost; //總利潤
            this.gridView_AddProductOrder.SetFocusedRowCellValue(this.gridColumn14, totalProfit);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddproductsOrders =
                    new
                        List<ProductsOrder>((IEnumerable<ProductsOrder>)this
                                                                         .AddproductsOrderBindingSource.List);
                foreach (ProductsOrder addproductsOrder in this.AddproductsOrders)
                {
                    addproductsOrder.SetDefaultValue();
                }

                var actualSaveCount = this.ProductsOrderUCO.SaveOrders(this.AddproductsOrders);
                foreach (var item in AddproductsOrders)
                {
                    alertControl1.Show(this, "存檔訊息", "已存檔 " + Environment.NewLine + item.CustomName + ":" + item.ProductName);
                }
                this.AddproductsOrderBindingSource.Clear();

                this.productsOrders = this
                                      .ProductsOrderUCO.QueryAllOrders("*ALL", "*ALL", "*ALL", "*ALL",
                                                                       DateTime.Today, DateTime.Today)
                                      .OrderByDescending(x => x.AutoID).ToList();
                this.productsOrderBindingSource.DataSource = this.productsOrders;
            }
            catch (Exception exception)
            {
                throw new Exception("btn_Save_Click 存檔發生錯誤" + exception.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = this.gridView_ProductOrder.GetSelectedRows();
                var deleteList = new List<ProductsOrder>();
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
                    alertControl1.Show(this, "刪除訊息", "已刪除 " + Environment.NewLine + item.CustomName + ":" + item.ProductName);
                }

                this.btn_Query.PerformClick();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        private void btn_FocusRow_Click(object sender, EventArgs e)
        {
            var Selected = this.gridView_ProductOrder.GetSelectedRows();
            var CurrentList = this.productsOrderBindingSource.DataSource as List<ProductsOrder>;
            CurrentList = CurrentList.OrderByDescending(x => x.AutoID).ToList();
            List<ProductsOrder> updateList = new List<ProductsOrder>();
            foreach (var item in Selected)
            {
                CurrentList[item].Address = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString() + "已取貨";
                updateList.Add(CurrentList[item]);
            }
            this.ProductsOrderUCO.UpdateOrders(updateList);
            foreach (var item in updateList)
            {
                alertControl1.Show(this, "鎖定訊息", "已鎖定 " + Environment.NewLine + item.CustomName + ":" + item.ProductName);
            }
            this.btn_Query.PerformClick();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel|*.xls|Word|*.docx";
            saveFileDialog1.FileName = DateTime.Today.ToString("yyyyMMdd") + "拉單";
            saveFileDialog1.ShowDialog();
            this.gridControl_ProductOrder.ExportToXlsx(saveFileDialog1.FileName);

            Process.Start(saveFileDialog1.FileName);
        }
        #endregion
    }
}