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
            using (var db =
                ProductsDbContext.CreateAndOpen(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                return (from a in db.ProductsInfomations
                        select new KeyAndNameForCombo
                        {
                            Code             = a.ProductName,
                            LocalDescription = a.ProductName
                        }).Distinct().ToList();
            }
        }

        public List<ProductsInfomation> QueryAllProducts(string productGroupId, string productName)
        {
            using (var db =
                ProductsDbContext.CreateAndOpen(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                var result = db.ProductsInfomations
                               .ToList();
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
        }

        public List<KeyAndNameForCombo> DistinctProductName(string productGroupId)
        {
            using (var db =
                ProductsDbContext.CreateAndOpen(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                var filter = db.ProductsInfomations
                               .ToList();
                if (string.IsNullOrWhiteSpace(productGroupId) == false && productGroupId != "*ALL")
                {
                    filter = filter.Where(x => x.ProductGroupID == productGroupId).ToList();
                }

                var result = (from a in filter
                              select new KeyAndNameForCombo
                              {
                                  Code             = a.ProductName,
                                  LocalDescription = a.ProductName
                              }).Distinct().ToList();
                return result;
            }
        }

        public List<ProductsInfomation> QueryAll()
        {
            using (var db =
                ProductsDbContext.CreateAndOpen(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                return db.ProductsInfomations
                         .ToList();
            }
        }

        public List<ProductsInfomation> GetProdctPrice(string ProductGroupID, string ProductName)
        {
            using (var db =
                ProductsDbContext.CreateAndOpen(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                var filter = db.ProductsInfomations.ToList();
                if (string.IsNullOrWhiteSpace(ProductGroupID) == false && ProductGroupID != "*ALL")
                {
                    filter = filter.Where(x => x.ProductGroupID == ProductGroupID).ToList();
                }

                var result = filter.Where(x => x.ProductName == ProductName).ToList();
                return result;
            }
        }

        public List<ProductsInfomation> GetProdctCost(string ProductGroupID, string ProductName)
        {
            using (var db =
                ProductsDbContext.CreateAndOpen(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                return db.ProductsInfomations
                         .Where(x => x.ProductGroupID == ProductGroupID && x.ProductName == ProductName).ToList();
            }
        }

        #endregion
    }
}