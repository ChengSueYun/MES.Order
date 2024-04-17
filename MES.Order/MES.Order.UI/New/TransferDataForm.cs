using DevExpress.XtraEditors;
using MES.Order.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES.Order.UI.New
{
    public partial class TransferDataForm : XtraForm
    {
        public TransferDataForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TransferDataUCO.StartTransfer();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
        }
    }
}