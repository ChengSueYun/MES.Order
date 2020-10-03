using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MES.Order.DAL.EntityFramework;

namespace MES.Order.DAL
{
    public class ProductsOrderPO
    {
        internal ProductsDbContext productsDbContext
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

        public List<ProductsOrder> QueryAllOrders(string Area,        string   ProductGroupID, string   CustomerName,
                                                  string ProductName, DateTime orderDateTimeS, DateTime orderDateTimeE)
        {
            using (var db =
                ProductsDbContext.CreateAndOpen(this.productsDbContext.Database.Connection.ConnectionString))
            {
                var result = db.ProductsOrders.Where(x => x.OrderDate >= orderDateTimeS &&
                                                          x.OrderDate <= orderDateTimeE).ToList();
                if (Area != "*ALL")

                    result = result.Where(x => x.Area == Area).ToList();

                if (ProductGroupID != "*ALL")

                    result = result.Where(x => x.ProductGroupID == ProductGroupID).ToList();

                if (CustomerName != "*ALL")

                    result = result.Where(x => x.CustomName == CustomerName).ToList();

                if (ProductName != "*ALL")

                    result = result.Where(x => x.ProductName == ProductName).ToList();

                return result;
            }
        }

        #region Save

        public int SaveOrder(List<ProductsOrder> insertProductsOrders)
        {
           
            var result = 0;

            foreach (var insertOrder in insertProductsOrders)
            {
                this.productsDbContext.ProductsOrders.Attach(insertOrder);
                this.productsDbContext.Entry(insertOrder).State = EntityState.Added;
            }

            result = this.productsDbContext.SaveChanges();
            return result;
        }

        #endregion

        #region MyRegion

        public int DeleteOrder(List<ProductsOrder> deletOders)
        {
            var result = 0;

            foreach (var deletOder in deletOders)
            {
                this.productsDbContext.ProductsOrders.Attach(deletOder);
                this.productsDbContext.Entry(deletOder).State = EntityState.Deleted;
            }

            result = this.productsDbContext.SaveChanges();
            return result;
        }

        #endregion
    }
}