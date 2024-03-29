using System.Collections.Generic;
using MES.Order.Adapter.Interface;
using MES.Order.DAL.Repository;
using MES.Order.Infrastructure.NewViewModel;
using MES.Order.Infrastructure.NewViewModel.Filter;

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

        /// <inheritdoc />
        public List<OrderInfoViewModel> Query(FilterOrderInfo _filter) => repo.Query(_filter);

    #endregion
    }
}