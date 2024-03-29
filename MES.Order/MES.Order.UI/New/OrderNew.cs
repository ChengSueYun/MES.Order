using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using MES.Order.Adapter;
using MES.Order.DAL.ViewModel;
using MES.Order.Infrastructure.NewViewModel.Filter;
using MES.Order.UI.Module;
using THS.Infrastructure.Extensions;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel.Request;
using Const = MES.Order.Infrastructure.Const;

namespace MES.Order.UI.New
{
    public partial class OrderNew : XtraForm
    {
        public static readonly WhetherGetStock whetherGetStock = new WhetherGetStock();
        private static readonly List<KeyAndNameForCombo> whetherCombos = new List<KeyAndNameForCombo>();
        private static FilterOrderInfo _filter = new FilterOrderInfo();


        public OrderNew()
        {
            InitializeComponent();
            try
            {
                InitialControls();
                BindAddPanelControl();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void Order_Enter(object sender, EventArgs e)
        {
        }

        #region Query

        private async void button_Query_Click(object sender, EventArgs e)
        {
            try
            {
                this.orderInfoViewModelBindingSource.DataSource = await BasicUtility.OrderInfoAdapter.Query(_filter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        #endregion

        #region Property

        private static OrderInfoRequest _request;
        public static OrderInfoRequest _Request
        {
            get => _request ?? new OrderInfoRequest();

            set => _request = value;
        }

        #endregion

        #region Initial

        public void InitialControls()
        {
            InitialWhetherStock();
            filterOrderInfoBindingSource.AddNew();
            _filter = filterOrderInfoBindingSource.Current as FilterOrderInfo;
            _filter.SetDefaultValue();
            if (_filter != null)
            {
                _filter.OrderDateStart = DateTime.Today.AddDays(-7);
                _filter.OrderDateEnd = DateTime.Today;
            }
        }

        private void BindAddPanelControl()
        {
            orderInfoRequestBindingSource.AddNew();
            _Request = orderInfoRequestBindingSource.Current as OrderInfoRequest;
            _Request.SetDefaultValue();
            this.AreaKeybindingSource.DataSource = Const.AreaInfoList;
            this.CustomerKeybindingSource.DataSource = Const.CustomerNameInfoList;
            this.FactoryKeybindingSource.DataSource = Const.FactoryInfoList;
            this.ProductKeybindingSource.DataSource = Const.ProductsNameInfoList;
        }

        private void InitialWhetherStock()
        {
            whetherGetStock.SetDefaultValue();
            whetherCombos.Add(whetherGetStock.Get);
            whetherCombos.Add(whetherGetStock.unGet);
            whetherCombos.Add(whetherGetStock.AllNone);
            whetherCombos.Add(whetherGetStock.AllGet);

            repository_WhetherStock.DataSource = whetherCombos;
        }

        #endregion

        #region EditValueChange

        private void CustomNameTextEdit_EditValueChanging(object sender,
            DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                _Request.Customer = e.NewValue.ToString();
                _Request.Area = AddCustomView.GetFocusedRowCellValue("LocalDescription").ToString();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }

        #endregion

        private void ProductNameTextEdit_EditValueChanging(object sender,
            DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                _Request.Product = e.NewValue.ToString();

                _Request.Factory = AddProductNameView.GetFocusedRowCellValue("LocalDescription").ToString();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }
    }
}