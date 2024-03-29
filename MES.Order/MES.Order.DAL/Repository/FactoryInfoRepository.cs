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
    public class FactoryInfoRepository
    {
    #region Contructure

        private readonly CoupleOrderDbContext mDbContext;

        public FactoryInfoRepository(string conn)
        {
            this.mDbContext = CoupleOrderDbContext.Create(conn);
        }

        private          bool mDisposed;
        private readonly bool mIsDisposeConnection = true;

        ~FactoryInfoRepository()
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

        public async Task<List<FactoryInfoViewModel>> Get()
        {
            var result    = new List<FactoryInfoViewModel>();
            var queryable = this.mDbContext.FactoryInfoes.AsQueryable();
            if (queryable.Any())
            {
                DefaultMapper.Map(await queryable.AsNoTracking().ToListAsync(), result);
            }
            return result;
        }

        public async Task<List<KeyAndName>> GetFactoryIdAsync()
        {
            var filter = await this.mDbContext.FactoryInfoes.Select(a => new KeyAndName
                                                                         {
                                                                             Code = a.Factory
                                                                           , LocalDescription =
                                                                                 a.Factory
                                                                         }).Distinct().ToListAsync();
            return filter;
        }

    #endregion

    #region AddOrUpdate

        public async Task<bool> AddOrUpdate(IEnumerable<FactoryInfoViewModel> FromUi)
        {
            try
            {
                var                      result  = false;
                IEnumerable<FactoryInfo> request = new List<FactoryInfo>();
                DefaultMapper.Map(FromUi, request);
                foreach (var areaInfo in request)
                {
                    this.mDbContext.FactoryInfoes.AddOrUpdate(x => x.Factory, areaInfo);
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