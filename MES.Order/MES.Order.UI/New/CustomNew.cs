using System;
using System.Net.Mime;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MES.Order.Adapter;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;
using THS.Infrastructure.Extensions;

namespace MES.Order.UI.New
{
    public partial class CustomNew : XtraForm
    {
        public CustomNew()
        {
            InitializeComponent();
            Application.DoEvents();
            customInfoViewModelBindingSource.DataSource = Const.AllCustomerView;
            Area_ComboBox.Items.AddRange(Const.AllAreaView);
        }

        private void gridView_Custom_EditFormHidden(object sender,
            EditFormHiddenEventArgs e)
        {
            try
            {
                if (e.Result == EditFormResult.Update)
                    if (customInfoViewModelBindingSource.Current is CustomInfoViewModel request)
                    {
                        request.SetDefaultValue();
                        request.CreateUser = Environment.MachineName;
                        request.CreateDate = DateTime.Now;
                        var addOrUpdate = BasicUtility.CustomerInfoAdapter.AddOrUpdate(request);
                        while (addOrUpdate.IsCompleted)
                        {
                            Const.AllCustomerView = BasicUtility.CustomerInfoAdapter.GetAll().Result;
                            customInfoViewModelBindingSource.DataSource = Const.AllCustomerView;
                        }
                    }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }
    }
}