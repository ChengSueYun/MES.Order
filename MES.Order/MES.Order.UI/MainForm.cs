using System.Data.Entity;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using MES.Order.DAL.EntityFramework;

namespace MES.Order.UI
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            this.InitializeComponent();

            // Handling the QueryControl event that will populate all automatically generated Documents
            this.tabbedView1.QueryControl += this.tabbedView1_QueryControl;
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

            if (e.Control == null)
            {
                e.Control = new Control();
            }
        }
    }
}