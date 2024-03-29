using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraPivotGrid;
using MES.Order.BLL;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.UI.Order;
using MES.Order.UI.Mappers;
using MES.Order.UI.Module;
using THS.Infrastructure.Extensions;
using AddOrderViewModel = MES.Order.DAL.ViewModel.AddOrderViewModel;

namespace MES.Order.UI.New
{
    public partial class OrderNew : XtraUserControl
    {
        private static readonly List<AddOrderViewModel>    addOrderView    = new List<AddOrderViewModel>();
        public static readonly  WhetherGetStock            whetherGetStock = new WhetherGetStock();
        private static readonly List<KeyAndNameForCombo>   whetherCombos   = new List<KeyAndNameForCombo>();
        private static readonly List<ProductsOrder>        focusOrders     = new List<ProductsOrder>();
        private static          FilterProductsOrderRequest _filterProductsOrderRequest;
        private static          List<ProductsOrder>        productsOrders = new List<ProductsOrder>();

        #region Property

        private static List<KeyAndNameForCombo> _queryProductsList
        {
            get => s_queryProductsList ?? new List<KeyAndNameForCombo>();
            set => s_queryProductsList = value;
        }

        private static List<KeyAndNameForCombo> s_queryProductsList;

        #endregion

        public OrderNew()
        {
            InitializeComponent();
            try
            {
                InitialControls();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void Order_Enter(object sender, EventArgs e)
        {
        }

        #region Initial

        public void InitialControls()
        {
            InitialWhetherStock();
            this.filterProductsOrderRequestBindingSource.AddNew();
            _filterProductsOrderRequest =
                this.filterProductsOrderRequestBindingSource.Current as FilterProductsOrderRequest;
            _filterProductsOrderRequest.SetDefaultValue();

            //地區
            this.QueryAreaLookUpEdit.Properties.DataSource = Const.AreaList;
            // _filterProductsOrderRequest.Area               = @"*ALL";

            //客戶
            this.QueryCustomerNameCheckComboBoxEdit.Properties.DataSource = Const.CustomerNameList;
            // _filterProductsOrderRequest.CustomerName                      = @"*ALL";

            //廠商
            this.QueryProductGroupIDLookUpEdit.Properties.DataSource = Const.ProductGroupIDList;
            // _filterProductsOrderRequest.ProductGroupID               = @"*ALL";

            //產品
            this.QueryProductNameLookUpEdit.Properties.DataSource = Const.ProductsList;
            // _filterProductsOrderRequest.ProductName               = @"*ALL";
        }

        private void InitialWhetherStock()
        {
            whetherGetStock.SetDefaultValue();
            whetherCombos.Add(whetherGetStock.Get);
            whetherCombos.Add(whetherGetStock.unGet);
            whetherCombos.Add(whetherGetStock.AllNone);
            whetherCombos.Add(whetherGetStock.AllGet);

            this.repository_WhetherStock.DataSource = whetherCombos;
        }

        #endregion

        #region Query

        private void button_Query_Click(object sender, EventArgs e)
        {
            _filterProductsOrderRequest.CustomerNames.AddRange(this.QueryCustomerNameCheckComboBoxEdit.EditValue as
                                                                   List<string> ?? new List<string>());
        }

        private void QueryAreaLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.QueryAreaLookUpEdit.EditValue.ToString() != @"*ALL")
            {
                this.QueryCustomerNameCheckComboBoxEdit.Properties.DataSource =
                    Const.CustomerNameList.FindAll(x => x.LocalDescription ==
                                                        this.QueryAreaLookUpEdit.EditValue.ToString());
            }
            else
            {
                this.QueryCustomerNameCheckComboBoxEdit.Properties.DataSource = Const.CustomerNameList;
            }
        }

        private void QueryProductGroupIDLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.QueryProductGroupIDLookUpEdit.EditValue.ToString() != @"*ALL")
            {
                this.QueryProductNameLookUpEdit.Properties.DataSource =
                    Const.ProductsList.FindAll(x => x.LocalDescription ==
                                                    this.QueryProductGroupIDLookUpEdit.EditValue.ToString());
            }
            else
            {
                _filterProductsOrderRequest.ProductName = @"*ALL";
            }
        }

        #endregion
    }
}