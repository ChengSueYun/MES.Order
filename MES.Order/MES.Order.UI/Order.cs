using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
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
        private ProductsOrderUCO    ProductsOrderUCO;

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
            this.dateEdit_OrderDateS.DateTime = DateTime.Today.AddDays(-15);
            this.dateEdit_OrderDateE.DateTime = DateTime.Today;
        }

        private void InitialProductName()
        {
            var result = this.ProductsOrderUCO.GetProductName("*ALL");
            this.lookUpEdit_ProductName.Properties.DataSource = result;
            this.lookUpEdit_ProductName.EditValue             = "*ALL";
            this.repository_ProductName.DataSource            = result.Where(x => x.Code != "*ALL").ToList();
        }

        private void InitialCusomterName()
        {
            var result = this.ProductsOrderUCO.GetCustomerName("*ALL");
            this.lookUpEdit_CustomerName.Properties.DataSource = result;
            this.lookUpEdit_CustomerName.EditValue             = "*ALL";
            this.repository_CustomerName.DataSource            = result.Where(x => x.Code != "*ALL").ToList();
            ;
        }

        private void InitialProductGroupID()
        {
            var result = this.ProductsOrderUCO.GetProductGroupID();
            this.lookUpEdit_ProductGroupID.Properties.DataSource = result;
            this.lookUpEdit_ProductGroupID.EditValue             = "*ALL";
            this.repository_ProductGroupID.DataSource            = result.Where(x => x.Code != "*ALL").ToList();
            ;
        }

        private void InitialArea()
        {
            var result = this.ProductsOrderUCO.GetArea();
            this.lookUpEdit_Area.Properties.DataSource = result;
            this.lookUpEdit_Area.EditValue             = "*ALL";
            this.repository_Area.DataSource            = result.Where(x => x.Code != "*ALL").ToList();
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
            var Area           = this.lookUpEdit_Area.EditValue.ToString();
            var CusomerName    = this.lookUpEdit_CustomerName.EditValue.ToString();
            var ProductGroupID = this.lookUpEdit_ProductGroupID.EditValue.ToString();
            var ProductName    = this.lookUpEdit_ProductName.EditValue.ToString();
            var OrderDateS     = this.dateEdit_OrderDateS.DateTime;
            var OrderDateE     = this.dateEdit_OrderDateE.DateTime;

            this.productsOrders =
                this.ProductsOrderUCO.QueryAllOrders(Area, ProductGroupID, CusomerName, ProductName, OrderDateS,
                                                     OrderDateE);
            this.gridControl_ProductOrder.DataSource = this.productsOrders;
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
            this.gridColumn4.ColumnEdit             = repository_CustomerName;
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
            var countSpinEdit    = sender as CalcEdit;
            var count            = countSpinEdit.Value;
            var current          = this.AddproductsOrderBindingSource.Current;
            var ProductGroupID   = ((ProductsOrder) current).ProductGroupID;
            var productName      = ((ProductsOrder) current).ProductName;
            var result           = this.ProductsOrderUCO.GetProductPrice(ProductGroupID, productName).FirstOrDefault();
            var resultTotalPrice = count * result.Price; //總售價
            this.gridView_AddProductOrder.SetFocusedRowCellValue(this.gridColumn_Price,      result.Price);
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
                        List<ProductsOrder>((IEnumerable<ProductsOrder>) this
                                                                         .AddproductsOrderBindingSource.List);
                foreach (ProductsOrder addproductsOrder in this.AddproductsOrders)
                {
                    addproductsOrder.SetDefaultValue();
                }

                var actualSaveCount = this.ProductsOrderUCO.SaveOrders(this.AddproductsOrders);
                MessageBox.Show("已存檔" + actualSaveCount + "筆資料", "存檔訊息", MessageBoxButtons.OKCancel);
                this.AddproductsOrderBindingSource.Clear();

                this.productsOrders = this
                                      .ProductsOrderUCO.QueryAllOrders("*ALL", "*ALL", "*ALL", "*ALL",
                                                                       DateTime.Today, DateTime.Today)
                                      .OrderByDescending(x => x.AutoID).ToList();
                this.gridControl_ProductOrder.DataSource = this.productsOrders;
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
                var deleteList   = new List<ProductsOrder>();
                this.productsOrders = this.productsOrders.OrderByDescending(x => x.AutoID).ToList();
                foreach (var row in selectedRows)
                {
                    var deleteRow = new ProductsOrder();

                    deleteRow = this.productsOrders[row];
                    deleteList.Add(deleteRow);
                }

                var actualDeleteCount = this.ProductsOrderUCO.DeleteOrders(deleteList);
                MessageBox.Show("已刪除" + actualDeleteCount + "筆資料", "存檔訊息", MessageBoxButtons.OKCancel);
                this.btn_Query.PerformClick();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        #endregion

    }
}