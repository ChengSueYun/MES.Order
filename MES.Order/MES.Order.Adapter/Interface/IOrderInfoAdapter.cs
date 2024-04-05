using MES.Order.Infrastructure.NewViewModel.Filter;
using MES.Order.Infrastructure.NewViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.Infrastructure.NewViewModel.Request;

namespace MES.Order.Adapter.Interface
{
    public interface IOrderInfoAdapter
    {
        Task<List<OrderInfoViewModel>> Query(FilterOrderInfo _filter);

        Task<bool> AddOrUpdate(IEnumerable<OrderInfoRequest> fromUi);

        Task<bool> AddOrUpdate(IEnumerable<OrderInfoViewModel> fromUi);

        Task<bool> AddOrUpdate(OrderInfoViewModel fromUi);

        Task<bool> AddOrUpdate(OrderInfoRequest fromUi);

        Task<bool> Delete(OrderInfoViewModel request);

        Task<bool> Delete(List<OrderInfoViewModel> request);
    }
}