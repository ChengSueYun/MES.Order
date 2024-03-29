using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;

namespace MES.Order.Adapter.Interface
{
    public interface ICustomerInfoAdapter
    {
        Task<List<CustomInfoViewModel>> GetAll();
        Task<bool>                      AddOrUpdate(CustomInfoViewModel FromUi);
        Task<bool>                      Delete(string                   pArea, string pCustom);
        Task<List<CustomInfoViewModel>> Get(string                      pArea, string pCustom);

        Task<List<KeyAndName>> DistinctCustomer(string pArea);

        Task<List<KeyAndName>> DistinctCustomerAsync();
    }
}