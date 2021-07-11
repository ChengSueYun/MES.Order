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
            foreach (var deleteCustom in deleteCustoms)
            {
                this.ProductsDbContext.Customs.Attach(deleteCustom);
                this.ProductsDbContext.Entry(deleteCustom).State = EntityState.Deleted;
            }

            var result = this.ProductsDbContext.SaveChangesAsync().Result;
            return result;
        }

        #endregion

        #region Save

        public int SaveCustomers(List<Custom> insertCustoms)
        {
            this.ProductsDbContext.Customs.AddRange(insertCustoms);
            var result = this.ProductsDbContext.SaveChangesAsync().Result;
            return result;
        }

        #endregion

        #region Query

        public List<KeyAndNameForCombo> DistinctCustomer(string pArea)
        {
            var filter = this.ProductsDbContext.Customs.ToListAsync().Result;
            if (string.IsNullOrWhiteSpace(pArea) == false && pArea != "*ALL")
            {
                filter = filter.Where(x => x.Address == pArea).ToList();
            }

            var result = (from a in filter
                          select new KeyAndNameForCombo
                          {
                              Code             = a.CustomName,
                              LocalDescription = a.Address
                          }).Distinct().ToList();
            return result;
        }

        public List<Custom> QueryAllCustoms(string pArea, string pCustomName)
        {
            var result = this.ProductsDbContext.Customs.ToListAsync().Result;

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

        public List<Custom> QueryAll()
        {
            return this.ProductsDbContext.Customs.ToListAsync().Result;
        }

        public string QuerySpecifcName(string pCustomName)
        {
            var result = this.ProductsDbContext.Customs.Where(x => x.CustomName == pCustomName).ToListAsync().Result;

            return result.Select(x => x.Address).FirstOrDefault();
        }

        #endregion
    }
}