using System.Collections.Generic;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;

namespace MES.Order.Adapter
{
    public interface ICustomerAdapter
    {
        int DeleteCustomers(List<Custom> deleteCustoms);

        List<KeyAndNameForCombo> DistinctCustomer(string pArea);

        List<Custom> QueryAll();

        List<Custom> QueryAllCustoms(string pArea, string pCustomName);
        string QuerySpecifcName(string pCustomName);


        int SaveCustomers(List<Custom> insertCustoms);
    }
}