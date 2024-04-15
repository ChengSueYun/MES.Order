using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.FluentDesignSystem;

namespace MES.Order.UI.New
{
    public partial class FluentMainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FluentMainForm()
        {
            InitializeComponent();
        }

        private void Menu_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            var assembly = Assembly.GetExecutingAssembly();

            var assemblyName = "MES.Order.UI.New." + e.Element.Tag;

            XtraForm currentForm = (XtraForm)assembly.CreateInstance(assemblyName);
            if (currentForm == null)
            {
                return;
            }

            //不要顯示Title
            currentForm.FormBorderStyle = FormBorderStyle.None;

            //非最上層
            currentForm.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            currentForm.Visible = true;

            //設定From位置
            currentForm.Dock = DockStyle.Fill;

            //將Form加入tabPage中
            fluentDesignFormContainer1.Controls.Add(currentForm);
            this.Menu.CollapseAll();
        }
    }
}