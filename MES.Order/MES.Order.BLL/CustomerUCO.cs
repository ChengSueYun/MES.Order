using System.Collections.Generic;
using MES.Order.Adapter;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;

namespace MES.Order.BLL
{
    public class CustomerUCO
    {
        internal ICustomerAdapter ICustomerAdapter
        {
            get
            {
                if (this._ICustomerAdapter == null)
                {
                    this._ICustomerAdapter = new CustomerAdapter();
                }

                return this._ICustomerAdapter;
            }
            set => this._ICustomerAdapter = value;
        }

        internal IAreaAdapter IAreaAdapter
        {
            get
            {
                if (this._IAreaAdapter == null)
                {
                    this._IAreaAdapter = new AreaAdapter();
                }

                return this._IAreaAdapter;
            }
            set => this._IAreaAdapter = value;
        }

        private IAreaAdapter     _IAreaAdapter;
        private ICustomerAdapter _ICustomerAdapter;

        #region Delete

        public int DeleteCustomers(List<Custom> deleteCustoms)
        {
            return this.ICustomerAdapter.DeleteCustomers(deleteCustoms);
        }

        #endregion

        #region Save

        public int SaveCustomers(List<Custom> insertCustoms)
        {
            return this.ICustomerAdapter.SaveCustomers(insertCustoms);
        }

        #endregion

        #region Query

        public List<KeyAndNameForCombo> DistinctCustomer(string pArea)
        {
            var result = this.ICustomerAdapter.DistinctCustomer(pArea);
            this.AddAllSelectRow(ref result);
            return result;
        }

        public List<Custom> QueryAllCustoms(string pArea, string pCustomName)
        {
            return this.ICustomerAdapter.QueryAllCustoms(pArea, pCustomName);
        }

        public List<Custom> QueryAll()
        {
            return this.ICustomerAdapter.QueryAll();
        }

        public List<KeyAndNameForCombo> GetArea()
        {
            var result = this.IAreaAdapter.GetArea();
            this.AddAllSelectRow(ref result);
            return result;
        }

        private void AddAllSelectRow(ref List<KeyAndNameForCombo> Result)
        {
            var all = new KeyAndNameForCombo();
            all.Code             = "*ALL";
            all.LocalDescription = "全部";
            Result.Insert(0, all);
        }

        #endregion
    }
}