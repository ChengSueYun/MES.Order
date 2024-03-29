using System;
using System.Data.Entity;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using MES.Order.BLL;
using MES.Order.DAL.EntityFramework;
using MES.Order.UI.New;

namespace MES.Order.UI
{
    public partial class MainForm : XtraForm
    {
        private static readonly SynchronizationContext _context        = SynchronizationContext.Current;
        private static readonly int                    tempRefreshData = 30; //資料載入時間暫存(每30秒)

        public MainForm()
        {
            this.InitializeComponent();
            this.tabbedView1.QueryControl += this.tabbedView1_QueryControl;
            AntWorkManager.Start(() =>
                                 {
                                     //TODO:看要衝啥，就寫在這裡

                                     //讀資料
                                     // Extension.GetAreaAsync();
                                     // Extension.GetCustomerAsync();
                                     // Extension.GetProductGroupIdAsync();
                                     // Extension.GetProductAsync();
                                     NewExtension.GetAreaAsync();
                                     NewExtension.GetCustomerAsync();
                                     NewExtension.GetProductAsync();
                                     NewExtension.GetFactoryIdAsync();
                                     NewExtension.GetProductTypeAsync();

                                     // Thread.Sleep(500);
                                 }, _context, new TimeSpan(0, 0, 0, tempRefreshData));

            // Handling the QueryControl event that will populate all automatically generated Documents
        }

        // Assigning a required content for each auto generated Document
        private void tabbedView1_QueryControl(object sender, QueryControlEventArgs e)
        {
            if (e.Document == this.document1)
            {
                e.Control = new Order();
            }

            if (e.Document == this.document2)
            {
                e.Control = new Customer();
            }

            if (e.Document == this.document3)
            {
                e.Control = new ProductInformation();
            }

            if (e.Document == this.chartDataDocument)
            {
                e.Control = new ChartData();
            }

            if (e.Document == this.orderNewDocument)
            {
                e.Control = new OrderNew();
            }

            if (e.Control == null)
            {
                e.Control = new Control();
            }
        }
    }
}