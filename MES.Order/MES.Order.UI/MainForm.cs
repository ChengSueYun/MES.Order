using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MES.Order.UI
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();

            // Handling the QueryControl event that will populate all automatically generated Documents
            this.tabbedView1.QueryControl += tabbedView1_QueryControl;
        }

        // Assigning a required content for each auto generated Document
        void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Document == this.document1)
                e.Control = new MES.Order.UI.Order();
            if (e.Document == this.document2)
                e.Control = new MES.Order.UI.Customer();
            if (e.Document == this.document3)
                e.Control = new MES.Order.UI.ProductInformation();
            if (e.Document == this.chartDataDocument)
                e.Control = new MES.Order.UI.ChartData();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }

        private void document1_IsSelectedChanged(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            // if (e.Document == this.document1)
            //     new MES.Order.UI.Order().InitialControls();
        }
    }
}