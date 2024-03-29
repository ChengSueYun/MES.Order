using MES.Order.Infrastructure.NewViewModel.Filter;
using MES.Order.Infrastructure.NewViewModel;
using System.Collections.Generic;

namespace MES.Order.Adapter.Interface
{
    public interface IOrderInfoAdapter
    {
        List<OrderInfoViewModel> Query(FilterOrderInfo _filter);
    }
}