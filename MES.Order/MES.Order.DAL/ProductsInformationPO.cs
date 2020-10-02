using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;

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
            var result = 0;

            foreach (var deleteProducts in delProductsInfomations)
            {
                this.ProductsDbContext.ProductsInfomations.Attach(deleteProducts);
                this.ProductsDbContext.Entry(deleteProducts).State = EntityState.Deleted;
            }

            result = this.ProductsDbContext.SaveChanges();
            return result;
        }

        #endregion

        #region Insert

        public int SaveProductsInfomations(List<ProductsInfomation> insertProductsInfomations)
        {
            var result = 0;

            foreach (var insertProducts in insertProductsInfomations)
            {
                this.ProductsDbContext.ProductsInfomations.Attach(insertProducts);
                this.ProductsDbContext.Entry(insertProducts).State = EntityState.Added;
            }

            result = this.ProductsDbContext.SaveChanges();
            return result;
        }

        #endregion

        #region Query

        public List<KeyAndNameForCombo> DistinctProducts()
        {
            try
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductsInfomation> QueryAllProducts(string productGroupId, string productName)
        {
            try
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<KeyAndNameForCombo> DistinctProductName(string productGroupId)
        {
            try
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductsInfomation> QueryAll()
        {
            try
            {
                using (var db =
                    ProductsDbContext.CreateAndOpen(this.ProductsDbContext.Database.Connection.ConnectionString))
                {
                    return db.ProductsInfomations
                             .ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}