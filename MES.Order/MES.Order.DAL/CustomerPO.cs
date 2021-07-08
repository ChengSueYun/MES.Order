using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;
using THS.Data.Entity.Extension;

namespace MES.Order.DAL
{
    public class CustomerPO
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

        internal DateTime Now
        {
            get
            {
                if (this._now.HasValue == false)
                {
                    this._now = DateTime.Now;
                }

                return this._now.Value;
            }
            set => this._now = value;
        }

        private DateTime? _now;

        private ProductsDbContext _productsDbContext;

        #region Delete

        public int DeleteCustomers(List<Custom> deleteCustoms)
        {
            using (var db = ProductsDbContext.Create(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                foreach (var deleteCustom in deleteCustoms)
                {
                    db.Customs.Attach(deleteCustom);
                    db.Entry(deleteCustom).State = EntityState.Deleted;
                }

                var result = db.Save();
                return result;
            }
        }

        #endregion

        #region Save

        public int SaveCustomers(List<Custom> insertCustoms)
        {
            using (var db = ProductsDbContext.Create(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                db.Customs.AddRange(insertCustoms);
                var result = db.Save();
                return result;
            }
        }

        #endregion

        #region Query

        public List<KeyAndNameForCombo> DistinctCustomer(string pArea)
        {
            using (var db =
                ProductsDbContext.CreateAndOpen(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                var filter = db.Customs
                               .ToList();
                if (string.IsNullOrWhiteSpace(pArea) == false && pArea != "*ALL")
                {
                    filter = filter.Where(x => x.Address == pArea).ToList();
                }

                var result = (from a in filter
                              select new KeyAndNameForCombo
                              {
                                  Code             = a.CustomID,
                                  LocalDescription = a.CustomName
                              }).Distinct().ToList();
                return result;
            }
        }

        public List<Custom> QueryAllCustoms(string pArea, string pCustomName)
        {
            using (var db =
                ProductsDbContext.CreateAndOpen(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                var result = db.Customs
                               .ToList();
                if (string.IsNullOrWhiteSpace(pArea) == false && pArea != "*ALL")
                {
                    result = result.Where(x => x.Address == pArea).ToList();
                }

                if (string.IsNullOrWhiteSpace(pCustomName) == false && pCustomName != "*ALL")
                {
                    result = result.Where(x => x.CustomName == pCustomName).ToList();
                }

                return result;
            }
        }

        public List<Custom> QueryAll()
        {
            using (var db =
                ProductsDbContext.CreateAndOpen(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                return db.Customs.ToList();
            }
        }

        public string QuerySpecifcName(string pCustomName)
        {
            using (var db =
                ProductsDbContext.CreateAndOpen(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                var result = db.Customs.Where(x => x.CustomName == pCustomName).AsNoTracking();

                return result.Select(x => x.Address).FirstOrDefault();
            }
        }

        #endregion
    }
}