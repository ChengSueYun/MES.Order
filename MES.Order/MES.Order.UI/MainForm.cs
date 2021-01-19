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
        }



        private void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            var             tempAssembly = Assembly.GetExecutingAssembly();
            var             FormAssembly = e.Document.ControlTypeName;
            XtraUserControl Form         = null;

            Form = (XtraUserControl) tempAssembly.CreateInstance(FormAssembly);

            e.Control      = Form;
            e.Control.Dock = DockStyle.Fill;
            e.Control.Show();
            return;
        }
    }
}
