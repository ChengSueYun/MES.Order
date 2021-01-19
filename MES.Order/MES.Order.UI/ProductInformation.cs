using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MES.Order.BLL;
using MES.Order.DAL.EntityFramework;

namespace MES.Order.UI
{
    public partial class ProductInformation : XtraUserControl
    {
        private List<ProductsInfomation> Add_productsInfomations = new List<ProductsInfomation>();
        private ProductInformationUCO    ProductInformationUCO;
        private List<ProductsInfomation> productsInfomations = new List<ProductsInfomation>();

        public ProductInformation()
        {
            this.InitializeComponent();
            this.InitialUCO();
            this.InitialControl();
        }

        #region Initial

        private void InitialUCO()
        {
            this.ProductInformationUCO = new ProductInformationUCO();
        }

        private void InitialControl()
        {
            try
            {
                this.InitialProductGroupID();
                this.InitialProductName();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InitialProductGroupID()
        {
            var result = this.ProductInformationUCO.QueryProductGroupIds();
            this.lookUpEdit_ProductGroupID.Properties.DataSource = result;
            this.repository_ProductGroupID.DataSource            = result.Where(x => x.Code != "*ALL").ToList();
            this.lookUpEdit_ProductGroupID.EditValue             = "*ALL";
        }

        private void InitialProductName()
        {
            var result = this.ProductInformationUCO.DistinctProductName();
            this.lookUpEdit_ProductName.Properties.DataSource = result;
            this.lookUpEdit_ProductName.Properties.DataSource = result;
            this.lookUpEdit_ProductName.EditValue             = "*ALL";
        }

        #endregion

        #region Button_Event

        //查詢
        private void btn_Query_Click(object sender, EventArgs e)
        {
            var pProductGroupID = this.lookUpEdit_ProductGroupID.EditValue.ToString();
            var pProductName = this.lookUpEdit_ProductName.EditValue.ToString();
            this.productsInfomations = this.ProductInformationUCO.QueryProducts(pProductGroupID, pProductName);
            this.gridControl_ProductInfo.DataSource = this.productsInfomations;
            this.gridControl_AddProducts.DataSource = this.Add_productsInfomations;
        }

        private void lookUpEdit_ProductGroupID_EditValueChanged(object sender, EventArgs e)
        {
            var pProductGroupID = this.lookUpEdit_ProductGroupID.EditValue.ToString();
            var result          = this.ProductInformationUCO.DistinctProductName(pProductGroupID);
            this.lookUpEdit_ProductName.Properties.DataSource = result;
        }

        //計算利潤
        private void gridView_AddProducts_CustomUnboundColumnData(object sender,
                                                                  DevExpress.XtraGrid.Views.Base.
                                                                      CustomColumnDataEventArgs e)
        {
            var current = this.AddproductsInfomationBindingSource.Current;
            e.Value = ((ProductsInfomation) current).Price - ((ProductsInfomation) current).Cost;
            ((ProductsInfomation) current).Profit = Convert.ToInt32(e.Value);
        }

        //存檔
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.Add_productsInfomations =
                    new
                        List<ProductsInfomation>((IEnumerable<ProductsInfomation>) this
                                                     .AddproductsInfomationBindingSource.List);
                var actualSaveCount = this.ProductInformationUCO.SaveProductsInfomations(this.Add_productsInfomations);
                MessageBox.Show("已存檔" + actualSaveCount + "筆資料", "存檔訊息", MessageBoxButtons.OKCancel);
                this.AddproductsInfomationBindingSource.Clear();

                this.productsInfomations = this.ProductInformationUCO.QueryProducts("*ALL", "*ALL")
                                               .OrderByDescending(x => x.AutoID).ToList();
                this.gridControl_ProductInfo.DataSource = this.productsInfomations;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        //刪除
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = this.gridView_ProductInfo.GetSelectedRows();
                var deleteList   = new List<ProductsInfomation>();
                this.productsInfomations = this.productsInfomations.OrderByDescending(x => x.AutoID).ToList();
                foreach (var row in selectedRows)
                {
                    var deleteRow = new ProductsInfomation();

                    deleteRow = this.productsInfomations[row];
                    deleteList.Add(deleteRow);
                }

                var actualDeleteCount = this.ProductInformationUCO.DeleteProductsInfomations(deleteList);
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