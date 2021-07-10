using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;
using THS.Data.Entity.Extension;

namespace MES.Order.DAL
{
    public class ProductsInformationPO
    {
        internal ProductsDbContext ProductsDbContext
        {
            get
            {
                if (this._productsDbContext == null)
                {
                    this._productsDbContext = new ProductsDbContext();
                }

                return this._productsDbContext;
            }
            set => this._productsDbContext = value;
        }

        private ProductsDbContext _productsDbContext;

        #region Delete

        public int DeleteProductsInfomations(List<ProductsInfomation> delProductsInfomations)
        {
            using (var db = ProductsDbContext.Create(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                foreach (var delProductsInfomation in delProductsInfomations)
                {
                    db.ProductsInfomations.Attach(delProductsInfomation);
                    db.Entry(delProductsInfomation).State = EntityState.Deleted;
                }

                var result = db.Save();
                return result;
            }
        }

        #endregion

        #region Insert

        public int SaveProductsInfomations(List<ProductsInfomation> insertProductsInfomations)
        {
            using (var db = ProductsDbContext.Create(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                db.ProductsInfomations.AddRange(insertProductsInfomations);
                var result = db.Save();
                return result;
            }
        }

        #endregion

        #region Query

        public List<KeyAndNameForCombo> DistinctProducts()
        {
            return (from a in this.ProductsDbContext.ProductsInfomations
                    select new KeyAndNameForCombo
                    {
                        Code             = a.ProductName,
                        LocalDescription = a.ProductName
                    }).Distinct().ToList();
        }

        public List<ProductsInfomation> QueryAllProducts(string productGroupId, string productName)
        {
            var result = this.ProductsDbContext.ProductsInfomations.ToListAsync().Result;
            if (string.IsNullOrWhiteSpace(productGroupId) == false && productGroupId != "*ALL")
            {
                result = result.Where(x => x.ProductGroupID == productGroupId).ToList();
            }

            if (string.IsNullOrWhiteSpace(productName) == false && productName != "*ALL")
            {
                result = result.Where(x => x.ProductName == productName).ToList();
            }

            return result;
        }

        public List<KeyAndNameForCombo> DistinctProductName(string productGroupId)
        {
            var filter = this.ProductsDbContext.ProductsInfomations.ToListAsync().Result;
            if (string.IsNullOrWhiteSpace(productGroupId) == false && productGroupId != "*ALL")
            {
                filter = filter.Where(x => x.ProductGroupID == productGroupId).ToList();
            }

            var result = (from a in filter
                          select new KeyAndNameForCombo
                          {
                              Code             = a.ProductName,
                              LocalDescription = a.ProductGroupID
                          }).Distinct().ToList();
            return result;
        }

        public List<ProductsInfomation> QueryAll()
        {
            return this.ProductsDbContext.ProductsInfomations.ToListAsync().Result;
        }

        public List<ProductsInfomation> GetProdctPrice(string ProductGroupID, string ProductName)
        {
            var filter = this.ProductsDbContext.ProductsInfomations.ToListAsync().Result;
            if (string.IsNullOrWhiteSpace(ProductGroupID) == false && ProductGroupID != "*ALL")
            {
                filter = filter.Where(x => x.ProductGroupID == ProductGroupID).ToList();
            }

            if (string.IsNullOrWhiteSpace(ProductName) == false && ProductName != "*ALL")
            {
                filter = filter.Where(x => x.ProductName == ProductName).ToList();
            }

            return filter;
        }

        public List<ProductsInfomation> GetProdctCost(string ProductGroupID, string ProductName)
        {
            return this.ProductsDbContext.ProductsInfomations
                       .Where(x => x.ProductGroupID == ProductGroupID && x.ProductName == ProductName).ToListAsync().Result;
        }

        #endregion
    }
}