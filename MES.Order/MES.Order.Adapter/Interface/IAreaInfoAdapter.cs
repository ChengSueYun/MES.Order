using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;

namespace MES.Order.Adapter.Interface
{
    public interface IAreaInfoAdapter
    {
        Task<List<AreaInfoViewModel>> GetAsync();
        Task<bool>                    AddOrUpdateAsync(IEnumerable<AreaInfoViewModel> FromUi);

        Task<List<KeyAndName>> GetAreaAsync();
    }
}