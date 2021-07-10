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

        #region Save

        public int SaveOrder(List<ProductsOrder> insertProductsOrders)
        {
            var result = 0;
            using (var db = ProductsDbContext.Create(this.productsDbContext.Database.Connection.ConnectionString))
            {
                insertProductsOrders.ForEach(x => x.Note3 = "");
                db.ProductsOrders.AddRange(insertProductsOrders);
                result = db.Save();
            }

            return result;
        }

        #endregion

        #region Delete

        public int DeleteOrder(List<ProductsOrder> deletOders)
        {
            using (var db = ProductsDbContext.Create(this.productsDbContext.Database.Connection.ConnectionString))
            {
                foreach (var deletOder in deletOders)
                {
                    deletOder.Note3 = "";
                    db.ProductsOrders.Attach(deletOder);
                    db.Entry(deletOder).State = EntityState.Deleted;
                }

                var result = db.Save();
                return result;
            }
        }

        #endregion

        #region Update

        public int UpdateOrder(List<ProductsOrder> updateOrders)
        {
            using (var db = ProductsDbContext.Create(this.productsDbContext.Database.Connection.ConnectionString))
            {
                foreach (var updateOrder in updateOrders)
                {
                    updateOrder.Note3 = "";
                    db.ProductsOrders.Attach(updateOrder);
                    db.Entry(updateOrder).State = EntityState.Modified;
                }

                var result = db.Save();
                return result;
            }
        }

        #endregion
    }
}