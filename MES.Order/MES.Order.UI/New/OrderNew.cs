using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
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
                this.button_Query_Click(null, null);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

    #region FocusEvent

        private void gridView_ProductOrder_SelectionChanged(object                    sender
                                                          , SelectionChangedEventArgs e)
        {
            try
            {
                if (!IfFocusData)
                {
                    return;
                }

                var focusRow = this.orderInfoViewModelBindingSource.Current as OrderInfoViewModel;
                if (focusRow != null && focusRow.Selection)
                {
                    var exists = _FocusData.Exists(x => x.Area     == focusRow.Area     &&
                                                        x.Customer == focusRow.Customer &&
                                                        x.Factory  == focusRow.Factory  &&
                                                        x.Product  == focusRow.Product);
                    if (!exists)
                    {
                        _FocusData.Add(focusRow);
                    }
                }
                else if (focusRow != null && !focusRow.Selection)
                {
                    var exists = _FocusData.Exists(x => x.Area     == focusRow.Area     &&
                                                        x.Customer == focusRow.Customer &&
                                                        x.Factory  == focusRow.Factory  &&
                                                        x.Product  == focusRow.Product);
                    if (exists)
                    {
                        _FocusData.Remove(focusRow);
                    }
                }

                this.pivotGrid_FocusOrder.DataSource = _FocusData;
                this.pivotGrid_FocusOrder.RefreshDataAsync().ConfigureAwait(true);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }

    #endregion

        private void Order_Enter(object sender, EventArgs e)
        {
        }

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
            _filter  = this.filterOrderInfoBindingSource.Current as FilterOrderInfo;
            _Request = this.orderInfoRequestBindingSource.Current as OrderInfoRequest;
            _filter.SetDefaultValue();
            _Request.SetDefaultValue();
            if (_filter != null)
            {
                _filter.OrderDateStart = DateTime.Today.AddDays(-7);
                _filter.OrderDateEnd   = DateTime.Today;
            }
            this.CustomerTextEdit.Properties.TextEditStyle = TextEditStyles.Standard;
        }

        private void BindAddPanelControl()
        {
            this.AreaKeybindingSource.DataSource         = Const.AllAreaView;
            this.CustomerKeybindingSource.DataSource     = Const.AllCustomerView;
            this.FactoryKeybindingSource.DataSource      = Const.AllFactoryView;
            this.ProductKeybindingSource.DataSource      = Const.AllProductsView;
            this.SizSpecTextEdit.Properties.DataSource   = Const.SizeSpecEnum;
            this.ColorSpecTextEdit.Properties.DataSource = Const.ColorSpecEnums;

            // this.Area_Repository.DataSource = Const.AllAreaView;

            // this.Factory_Repository.DataSource=Const.AllFactoryView;
        }

    #endregion

    #region Add Event

        private void CustomerTextEdit_EditValueChanging(object            sender
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

        private void ProductTextEdit_EditValueChanging(object            sender
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
                // this.orderInfoViewModelBindingSource.DataSource = await BasicUtility.OrderInfoAdapter.Query(_filter);
                // this.gridView_ProductOrder.BestFitColumns();


            
                var accessToken = "EAAOAT9rhCCsBO4mSiVtdTR86wBCmYcubHGkfVVaitKUTv6XsBSFFm4vWPdGQENgURa7LjawZA4BGjDfQYkbg6x8yKBqzmW1worpi91LAZCu8ZC95h9uT7ibaDOTikU6BTCuKT5ZBLggM49i8pdgv3GDwaKQOhA0SDjxvKmQtFQoZAZBx0dJDQhF57fIQvzcn3hnveiMNSz4j5lrVMr9AZDZD";
                var recipientId = "7704016049622006";
                var message     = "Hello, this is a test message.";
                
                var url = $"https://graph.facebook.com/v2.6/me/messages?access_token={accessToken}";
                var content =
                    new
                        StringContent($"{{\"recipient\": {{\"id\": \"{recipientId}\"}}, \"message\": {{\"text\": \"{message}\"}}}}"
                                    , Encoding.UTF8, "application/json");
                
                using (var httpClient = new HttpClient())
                {
                    var    response       = await httpClient.PostAsync(url, content);
                    string responseString = await response.Content.ReadAsStringAsync();
                    XtraMessageBox.Show(responseString);
                }
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
                    this.button_Query_Click(null, null);
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
                var delete        = await BasicUtility.OrderInfoAdapter.Delete(deleteRequest);
                if (delete)
                {
                    this.MessageTextBox.Text +=
                        $@"{DateTime.Now:yyyy-MM-dd hh:mm:ss} 已刪除{deleteRequest.Customer}:{deleteRequest.Product}{Environment.NewLine}";
                    this.button_Query_Click(null, null);
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
                IfFocusData                  = false;
                this.barItem_LockRow.Caption = @"鎖定列";
            }
            else
            {
                IfFocusData                  = true;
                this.barItem_LockRow.Caption = @"解除鎖定列";
            }
            _FocusData = new List<OrderInfoViewModel>();
        }

    #endregion

    #region 新增地區

        private void gridView_AddArea_EditFormHidden(object sender, EditFormHiddenEventArgs e)
        {
            try
            {
                if (e.Result == EditFormResult.Update)
                {
                    if (this.AreaKeybindingSource.Current is AreaInfoViewModel request)
                    {
                        request.SetDefaultValue();

                        var addOrUpdate = BasicUtility.AreaInfoAdapter.AddOrUpdateAsync(request);
                        while (addOrUpdate.IsCompleted)
                        {
                            Const.AllAreaView                        = BasicUtility.AreaInfoAdapter.GetAsync().Result;
                            this.CustomerKeybindingSource.DataSource = Const.AllCustomerView;
                        }
                        _Request.Area = request.Area;
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }

    #endregion

    #region 新增客戶

        private void gridView_AddCustomer_EditFormHidden(object                  sender
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
                            Const.AllCustomerView                    = BasicUtility.CustomerInfoAdapter.GetAll().Result;
                            this.CustomerKeybindingSource.DataSource = Const.AllCustomerView;
                        }
                        _Request.Area     = request.Area;
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
                            Const.AllProductsView                   = BasicUtility.ProductsInfoAdapter.Get().Result;
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

        private void ProductImage_Repository_EditValueChanging(object sender, ChangingEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.NewValue.ToString())) return;

                string filePath =
                    $"D:\\{_Request.Factory}圖片\\{_Request.Product.Substring(0,5)}_{DateTime.Now.ToTaiwanCalendar("yMMd")}.{ImageFormat.Png}";
                if (!Directory.Exists(filePath))
                {
                    //新增資料夾
                    Directory.CreateDirectory(filePath);
                }
                this.SaveImage(e.NewValue.ToString()
                             , filePath
                             , ImageFormat.Png);
            }
            catch (ExternalException)
            {
                return;
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }

        public void SaveImage(string imageUrl, string filename, ImageFormat format)
        {
            WebClient client = new WebClient();
            Stream    stream = client.OpenRead(imageUrl);
            Bitmap    bitmap;
            bitmap = new Bitmap(stream);

            if (bitmap != null)
            {
                bitmap.Save(filename, format);
            }

            stream.Flush();
            stream.Close();
            client.Dispose();
        }

    #endregion

    #region 新增廠商

        private void gridView_AddFactory_EditFormHidden(object sender, EditFormHiddenEventArgs e)
        {
            try
            {
                if (e.Result == EditFormResult.Update)
                {
                    if (this.FactoryKeybindingSource.Current is FactoryInfoViewModel request)
                    {
                        request.SetDefaultValue();

                        var addOrUpdate = BasicUtility.FactoryInfoAdapter.AddOrUpdate(request);
                        while (addOrUpdate.IsCompleted)
                        {
                            Const.AllFactoryView                    = BasicUtility.FactoryInfoAdapter.Get().Result;
                            this.FactoryKeybindingSource.DataSource = Const.AllFactoryView;
                        }
                        if (this.ProductKeybindingSource.Current is ProductsInfoViewModel ProductRequest)
                        {
                            ProductRequest.Factory = request.Factory;
                        }
                        _Request.Factory = request.Factory;
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