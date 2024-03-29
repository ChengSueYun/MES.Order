﻿using System;
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
    public class ProductsInfoRepository
    {
    #region Contructure

        private readonly CoupleOrderDbContext mDbContext;

        public ProductsInfoRepository(string conn)
        {
            this.mDbContext = CoupleOrderDbContext.Create(conn);
        }

        private          bool mDisposed;
        private readonly bool mIsDisposeConnection = true;

        ~ProductsInfoRepository()
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

        public async Task<List<ProductsInfoViewModel>> Get()
        {
            var result    = new List<ProductsInfoViewModel>();
            var queryable = this.mDbContext.ProductsInfoes.AsQueryable();
            if (queryable.Any())
            {
                DefaultMapper.Map(await queryable.AsNoTracking().ToListAsync(), result);
            }
            return result;
        }

        public async Task<List<KeyAndName>> GetProductNameAsync()
        {
            var result = await this.mDbContext.ProductsInfoes.Select(a => new KeyAndName()
                                                                          {
                                                                              Code             = a.Product
                                                                            , LocalDescription = a.ProductType
                                                                          }).Distinct().ToListAsync();
            return result;
        }

        public async Task<List<KeyAndName>> GetProductTypeAsync()
        {
            var result = await this.mDbContext.ProductsInfoes.Select(a => new KeyAndName()
                                                                          {
                                                                              Code             = a.ProductType
                                                                            , LocalDescription = a.ProductType
                                                                          }).Distinct().ToListAsync();
            return result;
        }

    #endregion

    #region AddOrUpdate

        public async Task<bool> AddOrUpdate(IEnumerable<ProductsInfoViewModel> FromUi)
        {
            try
            {
                var                       result  = false;
                IEnumerable<ProductsInfo> request = new List<ProductsInfo>();
                DefaultMapper.Map(FromUi, request);
                foreach (var areaInfo in request)
                {
                    this.mDbContext.ProductsInfoes.AddOrUpdate(x => new { x.Factory, x.Product }, areaInfo);
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

        public async Task<bool> AddOrUpdate(ProductsInfoViewModel FromUi)
        {
            try
            {
                var result  = false;
                var request = new ProductsInfo();
                DefaultMapper.Map(FromUi, request);

                this.mDbContext.ProductsInfoes.AddOrUpdate(x => new { x.Factory, x.Product }, request);

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

        public async Task<bool> Delete(string pFactory, string pProduct)
        {
            try
            {
                var result = false;
                var productsInfos = this.mDbContext.ProductsInfoes.Where(x => x.Factory == pFactory &&
                                                                              x.Product == pProduct);
                if (productsInfos.Any())
                {
                    this.mDbContext.ProductsInfoes.RemoveRange(productsInfos);
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