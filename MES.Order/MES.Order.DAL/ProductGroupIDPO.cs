using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;
using MES.Order.Infrastructure;

namespace MES.Order.DAL
{
    public class ProductGroupIDPO
    {
        internal ProductsDbContext ProductsDbContext
        {
            get
            {
                if (this._productsDbContext == null)
                {
                    this._productsDbContext = ProductsDbContext.Create(mConn);
                }

                return this._productsDbContext;
            }

            set => this._productsDbContext = value;
        }

        private ProductsDbContext _productsDbContext;
        private readonly string mConn;

        public ProductGroupIDPO(string conn)
        {
            mConn = conn;
        }
        public List<KeyAndNameForCombo> QueryAllProductsGroupID()
        {
            var filter = this.ProductsDbContext.ProductGroupIDs.ToListAsync().Result;
            var result = (from a in filter
                select new KeyAndNameForCombo
                {
                    Code = a.ProductGroupID,
                    LocalDescription = a.ProductGroupName
                }).Distinct().ToList();

            return result;
        }

        public async Task GetProductGroupIdAsync()
        {
            var filter = await this.ProductsDbContext.ProductGroupIDs.Select(a => new KeyAndName
            {
                Code = a.ProductGroupID,
                LocalDescription = a.ProductGroupName
            }).Distinct().ToListAsync();
            if (filter.Any())
            {
                Const.ProductGroupIDList.AddRange(filter);
            }
        }

        public List<ProductsGroupID> QueryAll()
        {
            return this.ProductsDbContext.ProductGroupIDs.ToListAsync().Result;
        }
    }
}