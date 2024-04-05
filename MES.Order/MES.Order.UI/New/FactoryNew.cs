using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MES.Order.Adapter;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;
using THS.Infrastructure.Extensions;

namespace MES.Order.UI.New
{
    public partial class FactoryNew : XtraForm
    {
        public FactoryNew()
        {
            InitializeComponent();
            Application.DoEvents();
            factoryInfoViewModelBindingSource.DataSource = Const.AllFactoryView;
        }

        private void gridView_Factory_EditFormHidden(object sender,
            EditFormHiddenEventArgs e)
        {
            try
            {
                if (e.Result == EditFormResult.Update)
                    if (factoryInfoViewModelBindingSource.Current is FactoryInfoViewModel request)
                    {
                        request.SetDefaultValue();

                        var addOrUpdate = BasicUtility.FactoryInfoAdapter.AddOrUpdate(request);
                        while (addOrUpdate.IsCompleted)
                        {
                            Const.AllFactoryView = BasicUtility.FactoryInfoAdapter.Get().Result;
                            factoryInfoViewModelBindingSource.DataSource = Const.AllFactoryView;
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