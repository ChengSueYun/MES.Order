using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;

namespace MES.Order.Adapter.Interface
{
    public interface IFactoryInfoAdapter
    {
        Task<List<FactoryInfoViewModel>> Get();

        Task<bool> AddOrUpdate(IEnumerable<FactoryInfoViewModel> FromUi);

        Task<bool> AddOrUpdate(FactoryInfoViewModel FromUi);

        Task<List<KeyAndName>> GetFactoryIdAsync();
    }
}