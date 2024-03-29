using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.Adapter.Interface;
using MES.Order.DAL.Repository;
using MES.Order.Infrastructure.NewViewModel;
using MES.Order.Infrastructure.NewViewModel.Filter;
using MES.Order.Infrastructure.NewViewModel.Request;

namespace MES.Order.Adapter.Implement
{
    public class OrderInfoAdapter : IOrderInfoAdapter
    {
        private OrderInfoRepository mRepo;

        public OrderInfoRepository repo
        {
            get => this.mRepo ?? new OrderInfoRepository(BasicUtility.Conn);

            set => this.mRepo = value;
        }

        #region Implementation of IOrderInfoAdapter

        Task<List<OrderInfoViewModel>> IOrderInfoAdapter.Query(FilterOrderInfo _filter)
        {
            return repo.Query(_filter);
        }

        public Task<bool> AddOrUpdate(IEnumerable<OrderInfoRequest> fromUi)
        {
            return repo.AddOrUpdate(fromUi);
        }

        public Task<bool> AddOrUpdate(OrderInfoRequest fromUi)
        {
            return repo.AddOrUpdate(fromUi);
        }

        public Task<bool> Delete(OrderInfoViewModel request)
        {
            return repo.Delete(request);
        }

        public Task<bool> Delete(List<OrderInfoViewModel> request)
        {
            return repo.Delete(request);
        }

        #endregion
    }
}