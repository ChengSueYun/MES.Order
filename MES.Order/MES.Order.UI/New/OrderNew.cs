using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DataAccess.Native.Excel;
using DevExpress.DataProcessing;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using MES.Order.Adapter;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;
using MES.Order.Infrastructure.NewViewModel.Filter;
using MES.Order.Infrastructure.NewViewModel.Request;
using THS.Infrastructure.Extensions;

namespace MES.Order.UI.New
{
    public partial class OrderNew : XtraForm
    {
        public OrderNew()
        {
            this.InitializeComponent();
            try
            {
                this.InitialControls();
                this.BindAddPanelControl();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void Order_Enter(object sender, EventArgs e)
        {
        }

    #region Property

        private static OrderInfoRequest _request;

        public static OrderInfoRequest _Request
        {
            get { return _request ?? (_request = new OrderInfoRequest()); }

            set => _request = value;
        }

        private static FilterOrderInfo s_filter;

        private static FilterOrderInfo _filter
        {
            get => s_filter ?? new FilterOrderInfo();
            set => s_filter = value;
        }

        private static List<OrderInfoViewModel> s_focusData;

        private static List<OrderInfoViewModel> _FocusData
        {
            get => s_focusData;
            set => s_focusData = value;
        }

        private static bool IfFocusData = false;

    #endregion

    #region Initial

        public void InitialControls()
        {
            this.orderInfoRequestBindingSource.AddNew();
            this.filterOrderInfoBindingSource.AddNew();
            _filter  = this.filterOrderInfoBindingSource.Current as FilterOrderInfo;
            _Request = this.orderInfoRequestBindingSource.Current as OrderInfoRequest;
            _filter.SetDefaultValue();
            _Request.SetDefaultValue();
            if (_filter != null)
            {
                _filter.OrderDateStart = DateTime.Today.AddDays(-7);
                _filter.OrderDateEnd   = DateTime.Today;
            }
        }

        private void BindAddPanelControl()
        {
            this.AreaKeybindingSource.DataSource         = Const.AreaInfoList;
            this.CustomerKeybindingSource.DataSource     = Const.CustomerNameInfoList;
            this.FactoryKeybindingSource.DataSource      = Const.FactoryInfoList;
            this.ProductKeybindingSource.DataSource      = Const.ProductsNameInfoList;
            this.SizSpecTextEdit.Properties.DataSource   = Const.SizeSpecEnum;
            this.ColorSpecTextEdit.Properties.DataSource = Const.ColorSpecEnums;
            this.StatusRepositoryEdit.DataSource         = Const.OrderStatusEnums;
            this.ColorRepositoryEdit.DataSource          = Const.ColorSpecEnums;
            this.SizeRepositoryEdit.DataSource           = Const.SizeSpecEnum;
        }

    #endregion

    #region Add Event

        private void CustomerTextEdit_EditValueChanging(object                                            sender
                                                      , DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //設定客戶
            _Request.Customer = e.NewValue.ToString();

            //設定地區
            _Request.Area = Const.CustomerNameInfoList.Find(x => x.Code == _request.Customer).LocalDescription;
        }

        private void ProductTextEdit_EditValueChanging(object                                            sender
                                                     , DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //設定產品
            _Request.Product = e.NewValue.ToString();

            //設定廠商
            _Request.Factory = Const.ProductsNameInfoList.Find(x => x.Code == _request.Product).LocalDescription;
        }

    #endregion

    #region Button

        private async void button_Query_Click(object sender, EventArgs e)
        {
            try
            {
                this.orderInfoViewModelBindingSource.DataSource = await BasicUtility.OrderInfoAdapter.Query(_filter);
                this.gridView_ProductOrder.BestFitColumns();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void OrderNew_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    this.barItem_Save.PerformClick();
                    break;

                case Keys.F1:
                    IfFocusData = true;

                    this.barItem_LockRow.PerformClick();

                    break;

                // case Keys.F3:
                //     this.btn_Cancel.PerformClick();
                //     break;
                // case Keys.F2:
                //     this.btn_UnFocus.PerformClick();
                //     break;
                // case Keys.Enter:
                //     this.btn_Query.PerformClick();
                //     break;
            }
        }

        private async void barItem_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var productInfo = Const.AllProductsView.Find(x => x.Product == _Request.Product &&
                                                                  x.Factory == _Request.Factory);
                _Request.ProductsInfo = productInfo;
                _Request.SetDefaultValue();
                var addOrUpdate = await BasicUtility.OrderInfoAdapter.AddOrUpdate(_Request);
                if (addOrUpdate)
                {
                    this.alertControl1.Show(this.ParentForm, "訊息",
                                            $"已存檔 {Environment.NewLine}{_Request.Customer}:{_Request.Product}");
                    button_Query_Click(null, null);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }

        private void barItem_LockRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IfFocusData = true;
            _FocusData  = new List<OrderInfoViewModel>();
        }

    #endregion

    #region FocusEvent

        private void gridView_ProductOrder_SelectionChanged(object                                    sender
                                                          , DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                var focusRow = this.orderInfoViewModelBindingSource.Current as OrderInfoViewModel;
                switch (e.Action)
                {
                    case CollectionChangeAction.Add:
                    
                        // _FocusData.AddOrReplace(x=>new {x.Area,x.Customer,x.Factory,x.Product}, focusRow);
                        break;
                    case CollectionChangeAction.Remove:
                        _FocusData.Remove(focusRow);

                        break;
                    case CollectionChangeAction.Refresh:
                        _FocusData.AddRange(this.orderInfoViewModelBindingSource.DataSource as List<OrderInfoViewModel>);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                this.pivotGrid_FocusOrder.DataSource = _FocusData;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }

    #endregion
    }
}