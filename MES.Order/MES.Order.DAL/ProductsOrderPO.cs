using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MES.Order.DAL.EntityFramework;
using THS.Data.Entity.Extension;

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

        #region Query

        public List<ProductsOrder> QueryAllOrders(string Area,        string   ProductGroupID, string   CustomerName,
                                                  string ProductName, DateTime orderDateTimeS, DateTime orderDateTimeE)
        {
            var result = this.productsDbContext.ProductsOrders.Where(x => x.OrderDate >= orderDateTimeS &&
                                                                          x.OrderDate <= orderDateTimeE);
            if (Area != "*ALL")

                result = result.Where(x => x.Area == Area);

            if (ProductGroupID != "*ALL")

                result = result.Where(x => x.ProductGroupID == ProductGroupID);

            if (CustomerName != "*ALL")

                result = result.Where(x => x.CustomName == CustomerName);

            if (ProductName != "*ALL")

                result = result.Where(x => x.ProductName == ProductName);

            return result.ToListAsync().Result;
        }

        public List<ProductsOrder> QueryAllOrders(string       Area, string ProductGroupID, List<string> CustomerName,
                                                  List<string> ProductName, DateTime orderDateTimeS,
                                                  DateTime     orderDateTimeE)
        {
            var result = this.productsDbContext.ProductsOrders.Where(x => x.OrderDate >= orderDateTimeS &&
                                                                          x.OrderDate <= orderDateTimeE);
            if (Area != "*ALL")

                result = result.Where(x => x.Area == Area);

            if (ProductGroupID != "*ALL")

                result = result.Where(x => x.ProductGroupID == ProductGroupID);

            if (!CustomerName.Contains("*ALL") & CustomerName.Count > 0)

                result = result.Where(x => CustomerName.Contains(x.CustomName));

            if (!ProductName.Contains("*ALL") & ProductName.Count > 0)

                result = result.Where(x => ProductName.Contains(x.ProductName));

            return result.ToListAsync().Result;
        }

        #endregion

        #region Save

        public int SaveOrder(List<ProductsOrder> insertProductsOrders)
        {
            insertProductsOrders.ForEach(x => x.Note3 = "");
            using (var dbContext = new ProductsDbContext())
            {
                dbContext.ProductsOrders.AddRange(insertProductsOrders);
                var result = dbContext.SaveChangesAsync().Result;

                return result;
            }

            // this.productsDbContext.ProductsOrders.AddRange(insertProductsOrders);
            // var result = this.productsDbContext.SaveChangesAsync().Result;
            //
            // return result;
        }

        #endregion

        #region Delete

        public int DeleteOrder(List<ProductsOrder> deletOders)
        {
            using (var dbContext = new ProductsDbContext())
            {
                foreach (var deletOder in deletOders)
                {
                    deletOder.Note3 = "";
                    dbContext.ProductsOrders.Attach(deletOder);
                    dbContext.Entry(deletOder).State = EntityState.Deleted;
                }

                var result = dbContext.SaveChangesAsync().Result;
                return result;
            }

            // foreach (var deletOder in deletOders)
            // {
            //     deletOder.Note3 = "";
            //     this.productsDbContext.ProductsOrders.Attach(deletOder);
            //     this.productsDbContext.Entry(deletOder).State = EntityState.Deleted;
            // }
            //
            // var result = this.productsDbContext.SaveChangesAsync().Result;
            // return result;
        }

        #endregion

        #region Update

        public int UpdateOrder(List<ProductsOrder> updateOrders)
        {
            using (var dbContext = new ProductsDbContext())
            {
                foreach (var updateOrder in updateOrders)
                {
                    updateOrder.Note3 = "";
                    dbContext.ProductsOrders.Attach(updateOrder);
                    dbContext.Entry(updateOrder).State = EntityState.Modified;
                }

                var result = dbContext.SaveChangesAsync().Result;
                return result;
            }

            // foreach (var updateOrder in updateOrders)
            // {
            //     updateOrder.Note3 = "";
            //     this.productsDbContext.ProductsOrders.Attach(updateOrder);
            //     this.productsDbContext.Entry(updateOrder).State = EntityState.Modified;
            // }
            //
            // var result = this.productsDbContext.SaveChangesAsync().Result;
            // return result;
        }

        #endregion
    }
}