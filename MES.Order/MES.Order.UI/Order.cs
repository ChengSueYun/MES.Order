using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using MES.Order.BLL;
using MES.Order.DAL.EntityFramework;

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
            this.dateEdit_OrderDateS.DateTime = DateTime.Today;
            this.dateEdit_OrderDateE.DateTime = DateTime.Today.AddDays(-15);
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
            this.gridColumn4.ColumnEdit = repository_CustomerName;
            this.repository_CustomerName.DataSource  = result;
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
            var countSpinEdit  = sender as SpinEdit;
            var count          = countSpinEdit.Value;
            var current        = this.AddproductsOrderBindingSource.Current;
            var ProductGroupID = ((ProductsOrder) current).ProductGroupID;
            var productName    = ((ProductsOrder) current).ProductName;
            var result           = this.ProductsOrderUCO.GetProductPrice(ProductGroupID, productName).FirstOrDefault();
            var resultTotalPrice = count * result.Price;
            this.gridView_AddProductOrder.SetFocusedRowCellValue(this.gridColumn_Price,      result.Price);
            this.gridView_AddProductOrder.SetFocusedRowCellValue(this.gridColumn_TotalPrice, resultTotalPrice);
        }
        #endregion
    }
}