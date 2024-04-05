using System;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MES.Order.Adapter;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;
using THS.Infrastructure.Extensions;

namespace MES.Order.UI.New
{
    public partial class AreaNew : XtraForm
    {
        public AreaNew()
        {
            InitializeComponent();

            this.areaInfoViewModelBindingSource.DataSource = Const.AllAreaView;
        }

        private void gridView_Area_EditFormHidden(object sender,
            EditFormHiddenEventArgs e)
        {
            try
            {
                if (e.Result == EditFormResult.Update)
                    if (areaInfoViewModelBindingSource.Current is AreaInfoViewModel request)
                    {
                        request.SetDefaultValue();

                        var addOrUpdate = BasicUtility.AreaInfoAdapter.AddOrUpdateAsync(request);
                        while (addOrUpdate.IsCompleted)
                        {
                            Const.AllAreaView = BasicUtility.AreaInfoAdapter.GetAsync().Result;
                            this.areaInfoViewModelBindingSource.DataSource = Const.AllAreaView;
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