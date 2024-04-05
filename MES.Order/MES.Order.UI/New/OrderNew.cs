using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Data.Helpers;
using DevExpress.Utils;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using MES.Order.Adapter;
using MES.Order.DAL.EntityFramework;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;
using MES.Order.Infrastructure.NewViewModel.Filter;
using MES.Order.Infrastructure.NewViewModel.Request;
using MES.Order.UI.Module;
using THS.Infrastructure.Extensions;

namespace MES.Order.UI.New
{
    public partial class OrderNew : XtraForm
    {
        #region Infrastructure

        public OrderNew()
        {
            this.InitializeComponent();
            try
            {
                this.InitialControls();
                this.BindAddPanelControl();
                this.button_Query_Click(null, null);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void Order_Enter(object sender, EventArgs e)
        {
        }

        #endregion

        #region FocusEvent

        private void gridView_ProductOrder_SelectionChanged(object sender
            , SelectionChangedEventArgs e)
        {
            try
            {
                if (IfFocusData)
                {
                    var focusRow = this.orderInfoViewModelBindingSource.Current as OrderInfoViewModel;
                    if (focusRow != null && focusRow.Selection)
                    {
                        focusRow.Status = GlobalCollection.OrderStatusCollection.LastOrDefault();
                        _FocusData.AddOrReplace(x => x.Area == focusRow.Area &&
                                                     x.Customer == focusRow.Customer &&
                                                     x.Factory == focusRow.Factory &&
                                                     x.Product == focusRow.Product, focusRow);
                        this.MessageTextBox.Text +=
                            $@"{DateTime.Now:yyyy-MM-dd hh:mm:ss} 已拉單{focusRow.Area}-{focusRow.Customer}:{focusRow.Product}{Environment.NewLine}";
                    }
                    else if (focusRow != null && !focusRow.Selection)
                    {
                        focusRow.Status = string.Empty;
                        var exists = _FocusData.Exists(x => x.Area == focusRow.Area &&
                                                            x.Customer == focusRow.Customer &&
                                                            x.Factory == focusRow.Factory &&
                                                            x.Product == focusRow.Product);
                        if (exists)
                        {
                            _FocusData.Remove(focusRow);
                            this.MessageTextBox.Text +=
                                $@"{DateTime.Now:yyyy-MM-dd hh:mm:ss} 已取消拉單{focusRow.Area}-{focusRow.Customer}:{focusRow.Product}{Environment.NewLine}";
                        }
                    }

                    BasicUtility.OrderInfoAdapter.AddOrUpdate(focusRow);
                    focusTabPage.Text = $@"拉單({_FocusData.Count})";

                    this.pivotGrid_FocusOrder.DataSource = _FocusData;
                    this.pivotGrid_FocusOrder.RefreshDataAsync().ConfigureAwait(true);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }

        #endregion

        #region Property

        private static OrderInfoRequest _request;

        public static OrderInfoRequest _Request
        {
            get => _request ?? (_request = new OrderInfoRequest());

            set => _request = value;
        }

        private static FilterOrderInfo s_filter;

        private static FilterOrderInfo _filter
        {
            get => s_filter ?? new FilterOrderInfo();

            set => s_filter = value;
        }

        private static List<OrderInfoViewModel> _FocusData { get; set; }

        private static bool IfFocusData;

        #endregion

        #region Initial

        public void InitialControls()
        {
            this.orderInfoRequestBindingSource.AddNew();
            this.filterOrderInfoBindingSource.AddNew();
            _filter = this.filterOrderInfoBindingSource.Current as FilterOrderInfo;
            _Request = this.orderInfoRequestBindingSource.Current as OrderInfoRequest;
            _filter.SetDefaultValue();
            _Request.SetDefaultValue();
            if (_filter != null)
            {
                _filter.OrderDateStart = DateTime.Today.AddDays(-7);
                _filter.OrderDateEnd = DateTime.Today;
            }

            this.CustomerTextEdit.Properties.TextEditStyle = TextEditStyles.Standard;
        }

        private void BindAddPanelControl()
        {
            this.AreaKeybindingSource.DataSource = Const.AllAreaView;
            this.CustomerKeybindingSource.DataSource = Const.AllCustomerView;
            this.FactoryKeybindingSource.DataSource = Const.AllFactoryView;
            this.ProductKeybindingSource.DataSource = Const.AllProductsView;
            this.SizSpecTextEdit.Properties.DataSource = GlobalCollection.SiezSpcCollection;
            this.ColorSpecTextEdit.Properties.DataSource = GlobalCollection.ColorSpeCollection;
            this.ProductType_ComboBox.Items.AddRange(GlobalCollection.ProductTypeCollection);
        }

        #endregion

        #region Add Event

        private void CustomerTextEdit_EditValueChanging(object sender
            , ChangingEventArgs e)
        {
            try
            {
                //設定客戶
                if (e.NewValue != null)
                {
                    _Request.Customer = e.NewValue.ToString();

                    //設定地區
                    _Request.Area = Const.AllCustomerView.Find(x => x.Customer == _Request.Customer)?.Area;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }

        private void ProductTextEdit_EditValueChanging(object sender
            , ChangingEventArgs e)
        {
            if (e.NewValue != null)
            {
                //設定產品
                _Request.Product = e.NewValue.ToString();

                //設定廠商
                _Request.Factory = Const.AllProductsView.Find(x => x.Product == _request.Product)?.Factory;
            }
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

                case Keys.F3:
                    this.barItem_Delete.PerformClick();
                    break;

                // case Keys.F2:
                //     this.btn_UnFocus.PerformClick();
                //     break;
                // case Keys.Enter:
                //     this.btn_Query.PerformClick();
                //     break;
            }
        }

        private async void barItem_Save_ItemClick(object sender, ItemClickEventArgs e)
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
                    this.MessageTextBox.Text +=
                        $@"{DateTime.Now:yyyy-MM-dd hh:mm:ss} 已新增{_Request.Customer}:{_Request.Product}{Environment.NewLine}";
                    this.btn_Query.PerformClick();
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }

        private async void barItem_Delete_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var deleteRequest = this.orderInfoViewModelBindingSource.Current as OrderInfoViewModel;
                var delete = await BasicUtility.OrderInfoAdapter.Delete(deleteRequest);
                if (delete)
                {
                    this.MessageTextBox.Text +=
                        $@"{DateTime.Now:yyyy-MM-dd hh:mm:ss} 已刪除{deleteRequest.Customer}:{deleteRequest.Product}{Environment.NewLine}";
                    this.btn_Query.PerformClick();
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }

        private void barItem_LockRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IfFocusData)
            {
                IfFocusData = false;
                this.barItem_LockRow.Caption = @"鎖定列";

                
            }
            else
            {
                IfFocusData = true;
                this.barItem_LockRow.Caption = @"解除鎖定列";
            }

            _FocusData = new List<OrderInfoViewModel>();
        }

        #endregion

        #region 新增客戶

        private void gridView_AddCustomer_EditFormHidden(object sender
            , EditFormHiddenEventArgs e)
        {
            try
            {
                if (e.Result == EditFormResult.Update)
                {
                    if (this.CustomerKeybindingSource.Current is CustomInfoViewModel request)
                    {
                        request.SetDefaultValue();
                        request.CreateUser = Environment.MachineName;
                        request.CreateDate = DateTime.Now;
                        var addOrUpdate = BasicUtility.CustomerInfoAdapter.AddOrUpdate(request);
                        while (addOrUpdate.IsCompleted)
                        {
                            Const.AllCustomerView = BasicUtility.CustomerInfoAdapter.GetAll().Result;
                            this.CustomerKeybindingSource.DataSource = Const.AllCustomerView;
                        }

                        _Request.Area = request.Area;
                        _Request.Customer = request.Customer;
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }

        #endregion

        #region 新增產品

        private void gridView_AddProduct_EditFormHidden(object sender, EditFormHiddenEventArgs e)
        {
            try
            {
                if (e.Result == EditFormResult.Update)
                {
                    if (this.ProductKeybindingSource.Current is ProductsInfoViewModel request)
                    {
                        request.SetDefaultValue();

                        var addOrUpdate = BasicUtility.ProductsInfoAdapter.AddOrUpdate(request);
                        while (addOrUpdate.IsCompleted)
                        {
                            Const.AllProductsView = BasicUtility.ProductsInfoAdapter.Get().Result;
                            this.ProductKeybindingSource.DataSource = Const.AllProductsView;
                        }

                        _Request.Factory = request.Factory;
                        _Request.Product = request.Product;
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }

        #endregion
    }
}