using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using MES.Order.DAL.Mapper;
using MES.Order.DAL.NewEntityFramework;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;

namespace MES.Order.DAL.Repository
{
    public class CustomerInfoRepository
    {
    #region Contructure

        private readonly CoupleOrderDbContext mDbContext;

        public CustomerInfoRepository(string conn)
        {
            this.mDbContext = CoupleOrderDbContext.Create(conn);
        }

        private          bool mDisposed;
        private readonly bool mIsDisposeConnection = true;

        ~CustomerInfoRepository()
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

        public async Task<List<KeyAndName>> DistinctCustomer(string pArea)
        {
            try
            {
                var filter = this.mDbContext.CustomInfoes.AsQueryable();
                if (!string.IsNullOrWhiteSpace(pArea) && pArea != "全部")
                {
                    filter = filter.Where(x => x.Area == pArea);
                }

                var result = await (from a in filter
                                    select new KeyAndName
                                           {
                                               Code = a.Customer, LocalDescription = a.Area
                                           }).Distinct().ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public async Task<List<KeyAndName>> DistinctCustomerAsync()
        {
            try
            {
                var result = await this.mDbContext.CustomInfoes.Select(a => new KeyAndName
                                                                            {
                                                                                Code             = a.Customer
                                                                              , LocalDescription = a.Area
                                                                            })
                                       .Distinct().AsNoTracking().ToListAsync();

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public async Task<List<CustomInfoViewModel>> GetAll()
        {
            try
            {
                var result    = new List<CustomInfoViewModel>();
                var queryable = this.mDbContext.CustomInfoes.AsQueryable();
                if (queryable.Any())
                {
                    DefaultMapper.Map(await queryable.AsNoTracking().ToListAsync(), result);
                }

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public async Task<List<CustomInfoViewModel>> Get(string pArea, string pCustom)
        {
            try
            {
                var result = new List<CustomInfoViewModel>();
                var queryable = this.mDbContext.CustomInfoes.Where(x => x.Area     == pArea &&
                                                                        x.Customer == pCustom).AsQueryable();
                if (queryable.Any())
                {
                    DefaultMapper.Map(await queryable.AsNoTracking().ToListAsync(), result);
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

        public async Task<bool> AddOrUpdate(CustomInfoViewModel FromUi)
        {
            try
            {
                var        result  = false;
                CustomInfo request = new CustomInfo();
                DefaultMapper.Map(FromUi, request);
                this.mDbContext.CustomInfoes.AddOrUpdate(x => new { x.Area, x.Customer }, request);
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

        public async Task<bool> Delete(string pArea, string pCustom)
        {
            try
            {
                var result = false;
                var customInfos = this.mDbContext.CustomInfoes.Where(x => x.Area     == pArea &&
                                                                          x.Customer == pCustom);
                if (customInfos.Any())
                {
                    this.mDbContext.CustomInfoes.RemoveRange(customInfos);
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

    #endregion
    }
}