using System.Collections.Generic;
using MES.Order.DAL;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;

namespace MES.Order.Adapter
{
    public class CustomerAdapter : ICustomerAdapter
    {
        internal CustomerPO customerPo
        {
            get
            {
                if (this._customerPO == null)
                {
                    this._customerPO = new CustomerPO();
                }

                return this._customerPO;
            }
            set => this._customerPO = value;
        }

        private CustomerPO _customerPO;

        public List<KeyAndNameForCombo> DistinctCustomer(string pArea)
        {
            return this.customerPo.DistinctCustomer(pArea);
        }

        public List<Custom> QueryAllCustoms(string pArea, string pCustomName)
        {
            return this.customerPo.QueryAllCustoms(pArea, pCustomName);
        }

        public List<Custom> QueryAll()
        {
            return this.customerPo.QueryAll();
        }

        public int SaveCustomers(List<Custom> insertCustoms)
        {
            return this.customerPo.SaveCustomers(insertCustoms);
        }

        public int DeleteCustomers(List<Custom> deleteCustoms)
        {
            return this.customerPo.DeleteCustomers(deleteCustoms);
        }
    }
}