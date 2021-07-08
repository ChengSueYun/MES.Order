using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet;
using MES.Order.BLL;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;
using THS.Infrastructure.Extensions;

namespace MES.Order.UI
{
    public partial class Customer : XtraUserControl
    {
        private List<Custom> Add_Customers = new List<Custom>();
        private List<Custom> customers     = new List<Custom>();
        private CustomerUCO  customerUCO;

        public Customer()
        {
            try
            {
                this.InitializeComponent();
                this.InitialUCO();
                this.InitialControls();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        #region Initial

        private void InitialUCO()
        {
            this.customerUCO = new CustomerUCO();
        }

        private void InitialControls()
        {
            this.InitialArea();
            this.InitialCustomerName();
        }

        private void InitialArea()
        {
            var result = this.customerUCO.GetArea();
            this.lookUpEdit_Area.Properties.DataSource = result;
            this.repository_Area.DataSource            = result.Where(x => x.Code != "*ALL").ToList();
            this.lookUpEdit_Area.EditValue             = "*ALL";
        }

        private void InitialCustomerName()
        {
            var pArea = this.lookUpEdit_Area.EditValue.ToString();
            var result
                = this.customerUCO.DistinctCustomer(pArea);
            this.lookUpEdit_CustomerName.Properties.DataSource = result;
            this.lookUpEdit_CustomerName.EditValue             = "*ALL";
        }

        #endregion

        #region Button Event

        private void lookUpEdit_Area_EditValueChanged(object sender, EventArgs e)
        {
            var pArea = this.lookUpEdit_Area.EditValue.ToString();
            var result
                = this.customerUCO.DistinctCustomer(pArea);
            this.lookUpEdit_CustomerName.Properties.DataSource = result;
            this.lookUpEdit_CustomerName.EditValue             = "*ALL";
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            var pArea         = this.lookUpEdit_Area.EditValue.ToString();
            var pCustomerName = this.lookUpEdit_CustomerName.EditValue.ToString();
            this.customers                       = this.customerUCO.QueryAllCustoms(pArea, pCustomerName);
            this.gridControl_Customer.DataSource = this.customers;
        }

        //Delete
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            var selectedRows = this.gridView_Customer.GetSelectedRows();
            var deleteList   = new List<Custom>();
            this.customers = this.customers.OrderByDescending(x => x.AutoID).ToList();
            foreach (var row in selectedRows)
            {
                var deleteRow = new Custom();

                deleteRow = this.customers[row];
                deleteList.Add(deleteRow);
            }

            var actualDeleteCount = this.customerUCO.DeleteCustomers(deleteList);
            if (actualDeleteCount == deleteList.Count)
            {
                MessageBox.Show(@"已刪除" + actualDeleteCount + @"筆資料", @"存檔訊息", MessageBoxButtons.OKCancel);
                this.btn_Query.PerformClick();
            }
            else
            {
                throw new Exception("btn_Cancel_Click 刪除發生錯誤!");
            }
        }

        //Save
        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Add_Customers =
                new
                    List<Custom>((IEnumerable<Custom>) this
                                                       .AddcustomBindingSource.List);
            foreach (var addCustomer in this.Add_Customers)
            {
                addCustomer.SetDefaultValue();
            }

            var actualSaveCount = this.customerUCO.SaveCustomers(this.Add_Customers);
            if (actualSaveCount == this.Add_Customers.Count)
            {
                MessageBox.Show(@"已存檔" + actualSaveCount + @"筆資料", @"存檔訊息", MessageBoxButtons.OKCancel);
            }
            else
            {
                throw new Exception("btn_Save_Click 儲存發生錯誤!");
            }

            this.AddcustomBindingSource.Clear();

            this.customers = this.customerUCO.QueryAllCustoms("*ALL", "*ALL")
                                 .OrderByDescending(x => x.AutoID).ToList();
            this.gridControl_Customer.DataSource = this.customers;
        }

        #endregion
    }
}