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
    public class AreaInfoRepository
    {
    #region Contructure

        private readonly CoupleOrderDbContext mDbContext;

        public AreaInfoRepository(string conn)
        {
            this.mDbContext = CoupleOrderDbContext.Create(conn);
        }

        private          bool mDisposed;
        private readonly bool mIsDisposeConnection = true;

        ~AreaInfoRepository()
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

        public async Task<List<KeyAndName>> GetAreaAsync()
        {
            try
            {
                var filter = await this.mDbContext.AreaInfoes.ToListAsync();
                var result = (from a in filter
                              select new KeyAndName
                                     {
                                         Code = a.Area, LocalDescription = a.Area
                                     }).Distinct().ToList();
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public async Task<List<AreaInfoViewModel>> Get()
        {
            try
            {
                var result    = new List<AreaInfoViewModel>();
                var queryable = this.mDbContext.AreaInfoes.AsQueryable();
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

        public async Task<bool> AddOrUpdate(IEnumerable<AreaInfoViewModel> FromUi)
        {
            try
            {
                var                   result  = false;
                IEnumerable<AreaInfo> request = new List<AreaInfo>();
                DefaultMapper.Map(FromUi, request);
                foreach (var areaInfo in request)
                {
                    this.mDbContext.AreaInfoes.AddOrUpdate(x => x.Area, areaInfo);
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