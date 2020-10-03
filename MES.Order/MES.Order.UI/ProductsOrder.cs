using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSpreadsheet;
using MES.Order.BLL;

namespace MES.Order.UI
{
    public partial class ProductsOrder : Form
    {
        private ProductsOrderUCO                        ProductsOrderUCO;
        private List<DAL.EntityFramework.ProductsOrder> productsOrders = new List<DAL.EntityFramework.ProductsOrder>();

        public ProductsOrder()
        {
            InitializeComponent();
            InitialUCO();
            InitialControls();
        }

        private void InitialControls()
        {
            InitialArea();
            InitialProductGroupID();
            InitialCusomterName();
            InitialProductName();
            this.dateEdit_OrderDateS.DateTime = DateTime.Today;
            this.dateEdit_OrderDateE.DateTime = DateTime.Today.AddDays(-15);
            ;
        }

        private void InitialProductName()
        {
            var result = this.ProductsOrderUCO.GetProductName("*ALL");
            this.lookUpEdit_ProductName.Properties.DataSource = result;
            this.lookUpEdit_ProductName.EditValue             = "*ALL";
        }

        private void InitialCusomterName()
        {
            var result = this.ProductsOrderUCO.GetCustomerName("*ALL");
            this.lookUpEdit_CustomerName.Properties.DataSource = result;
            this.lookUpEdit_CustomerName.EditValue             = "*ALL";
        }

        private void InitialProductGroupID()
        {
            var result = this.ProductsOrderUCO.GetProductGroupID();
            this.lookUpEdit_ProductGroupID.Properties.DataSource = result;
            this.lookUpEdit_ProductGroupID.EditValue             = "*ALL";
        }

        private void InitialArea()
        {
            var result = this.ProductsOrderUCO.GetArea();
            this.lookUpEdit_Area.Properties.DataSource = result;
            this.lookUpEdit_Area.EditValue             = "*ALL";
        }

        private void InitialUCO()
        {
            this.ProductsOrderUCO = new ProductsOrderUCO();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            var Area           = this.lookUpEdit_Area.EditValue.ToString();
            var CusomerName    = this.lookUpEdit_CustomerName.EditValue.ToString();
            var ProductGroupID = this.lookUpEdit_ProductGroupID.EditValue.ToString();
            var ProductName    = this.lookUpEdit_ProductName.EditValue.ToString();
            var OrderDateS     = this.dateEdit_OrderDateS.DateTime;
            var OrderDateE     = this.dateEdit_OrderDateE.DateTime;

            this.productsOrders = this.ProductsOrderUCO.QueryAllOrders(Area, ProductGroupID, CusomerName, ProductName, OrderDateS, OrderDateE);
            this.gridControl_ProductOrder.DataSource = this.productsOrders;
            this.gridView_ProductOrder.BestFitColumns();
        }
    }
}
