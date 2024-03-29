﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using MES.Order.DAL.Mapper;
using MES.Order.DAL.NewEntityFramework;
using MES.Order.Infrastructure.NewViewModel;
using MES.Order.Infrastructure.NewViewModel.Filter;
using MES.Order.Infrastructure.NewViewModel.Request;

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

        private bool mDisposed;
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

        public  async Task<List<OrderInfoViewModel>> Query(FilterOrderInfo _filter)
        {
            try
            {
                var result = new List<OrderInfoViewModel>();
                var asQueryable = await this.mDbContext.OrderInfoes.Where(x => x.OrderDate >= _filter.OrderDateStart &&
                                                                               x.OrderDate <= _filter.OrderDateEnd)
                    .ToListAsync();

                if (asQueryable.Any())
                {
                    DefaultMapper.Map(asQueryable, result);
                }

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        #endregion

        #region AddOrUpdate

        public async Task<bool> AddOrUpdate(IEnumerable<OrderInfoRequest> fromUi)
        {
            try
            {
                var result = false;
                IEnumerable<OrderInfo> request = new List<OrderInfo>();
                DefaultMapper.Map(fromUi, request);
                foreach (var areaInfo in request)
                {
                    this.mDbContext.OrderInfoes.AddOrUpdate(x => new {x.Area, x.Customer, x.Factory, x.Product},
                        areaInfo);
                }

                if (await this.mDbContext.SaveChangesAsync() > 0)
                {
                    result = true;
                }

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public async Task<bool> AddOrUpdate(OrderInfoRequest fromUi)
        {
            try
            {
                var result = false;
                var request = new OrderInfo();
                DefaultMapper.Map(fromUi, request);

                this.mDbContext.OrderInfoes.AddOrUpdate(x => new {x.Area, x.Customer, x.Factory, x.Product}, request);

                if (await this.mDbContext.SaveChangesAsync() > 0)
                {
                    result = true;
                }

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        #endregion

        #region Delete

        public async Task<bool> Delete(OrderInfoViewModel request)
        {
            try
            {
                var result = false;
                var productsInfos = this.mDbContext.OrderInfoes.Where(x => x.Area == request.Area &&
                                                                           x.Product == request.Product &&
                                                                           x.Factory == request.Factory &&
                                                                           x.Customer == request.Customer);
                if (productsInfos.Any())
                {
                    this.mDbContext.OrderInfoes.RemoveRange(productsInfos);
                    if (await this.mDbContext.SaveChangesAsync() > 0)
                    {
                        result = true;
                    }
                }

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public async Task<bool> Delete(List<OrderInfoViewModel> request)
        {
            try
            {
                var result = false;
                foreach (var orderInfoViewModel in request)
                {
                    var productsInfos = this.mDbContext.OrderInfoes.Where(x => x.Area == orderInfoViewModel.Area &&
                                                                               x.Product ==
                                                                               orderInfoViewModel.Product &&
                                                                               x.Factory ==
                                                                               orderInfoViewModel.Factory &&
                                                                               x.Customer ==
                                                                               orderInfoViewModel.Customer);
                    if (productsInfos.Any())
                    {
                        this.mDbContext.OrderInfoes.RemoveRange(productsInfos);
                    }
                }

                if (await this.mDbContext.SaveChangesAsync() > 0)
                {
                    result = true;
                }

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        #endregion
    }
}