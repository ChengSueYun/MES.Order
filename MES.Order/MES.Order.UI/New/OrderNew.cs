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
using MES.Order.Infrastructure.NewViewModel.Filter;
using MES.Order.Infrastructure.UI.Order;
using MES.Order.UI.Mappers;
using MES.Order.UI.Module;
using THS.Infrastructure.Extensions;
using AddOrderViewModel = MES.Order.DAL.ViewModel.AddOrderViewModel;

namespace MES.Order.UI.New
{
    public partial class OrderNew : XtraUserControl
    {
        public static readonly  WhetherGetStock          whetherGetStock = new WhetherGetStock();
        private static readonly List<KeyAndNameForCombo> whetherCombos   = new List<KeyAndNameForCombo>();
        private static          FilterOrderInfo          _filter         = new FilterOrderInfo();

    #region Property

 

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
            this.filterOrderInfoBindingSource.AddNew();
            _filter = this.filterOrderInfoBindingSource.Current as FilterOrderInfo;
            _filter.SetDefaultValue();

            //地區
            this.QueryAreaLookUpEdit.Properties.DataSource = Const.AreaInfoList;
            this.AreaKeybindingSource.DataSource           = Const.AreaInfoList;
            this.QueryAreaLookUpEdit.Properties.DataSource = Const.AreaInfoList;
            //客戶
            this.QueryCustomerNameCheckComboBoxEdit.Properties.DataSource = Const.CustomerNameInfoList;
            this.CustomerKeybindingSource.DataSource                      = Const.CustomerNameList;

            //廠商
            this.QueryProductGroupIDLookUpEdit.Properties.DataSource = Const.FactoryInfoList;
            this.FactoryKeybindingSource.DataSource                  = Const.FactoryInfoList;

            //產品
            this.QueryProductNameLookUpEdit.Properties.DataSource = Const.ProductsNameInfoList;
            this.ProductKeybindingSource.DataSource               = Const.ProductsNameInfoList;
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
            // if (this.QueryProductGroupIDLookUpEdit.EditValue.ToString() != @"*ALL")
            // {
            //     this.QueryProductNameLookUpEdit.Properties.DataSource =
            //         Const.ProductsList.FindAll(x => x.LocalDescription ==
            //                                         this.QueryProductGroupIDLookUpEdit.EditValue.ToString());
            // }
            // else
            // {
            //     _filterProductsOrderRequest.ProductName = @"*ALL";
            // }
        }

    #endregion
    }
}