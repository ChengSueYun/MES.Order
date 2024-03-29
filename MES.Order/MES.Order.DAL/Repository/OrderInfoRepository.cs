using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MES.Order.DAL.Mapper;
using MES.Order.DAL.NewEntityFramework;
using MES.Order.Infrastructure.NewViewModel;
using MES.Order.Infrastructure.NewViewModel.Filter;

namespace MES.Order.DAL.Repository
{
    public class OrderInfoRepository
    {
    #region Contructure

        private readonly CoupleOrderDbContext mDbContext;

        public OrderInfoRepository(string conn)
        {
            this.mDbContext = CoupleOrderDbContext.Create(conn);
        }

        private          bool mDisposed;
        private readonly bool mIsDisposeConnection = true;

        ~OrderInfoRepository()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.mDisposed)
            {
                if (disposing)
                    if (this.mIsDisposeConnection && this.mDbContext != null)
                        this.mDbContext.Dispose();
                this.mDisposed = true;
            }
        }

    #endregion

    #region Query

        public List<OrderInfoViewModel> Query(FilterOrderInfo _filter)
        {
            var result = new List<OrderInfoViewModel>();
            var asQueryable = this.mDbContext.OrderInfoes.Where(x => x.OrderDate >= _filter.OrderDateStart &&
                                                                     x.OrderDate <= _filter.OrderDateEnd).AsQueryable();
            if (!string.IsNullOrEmpty(_filter.Area) && _filter.Area != "全部")
            {
                asQueryable = asQueryable.Where(x => x.Area == _filter.Area);
            }
            if (!string.IsNullOrEmpty(_filter.Customer) && _filter.Customer != "全部")
            {
                asQueryable = asQueryable.Where(x => x.Customer == _filter.Customer);
            }
            if (!string.IsNullOrEmpty(_filter.Factory) && _filter.Factory != "全部")
            {
                asQueryable = asQueryable.Where(x => x.Factory == _filter.Factory);
            }
            if (!string.IsNullOrEmpty(_filter.Product) && _filter.Product != "全部")
            {
                asQueryable = asQueryable.Where(x => x.Product == _filter.Product);
            }
            if (asQueryable.Any())
            {
                DefaultMapper.Map(asQueryable.AsNoTracking().ToList(), result);
            }
            return result;
        }

    #endregion
    }
}