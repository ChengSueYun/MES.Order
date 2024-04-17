using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;
using MES.Order.Infrastructure;
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
                    this._productsDbContext = ProductsDbContext.Create(mConn);
                }

                return this._productsDbContext;
            }
            set => this._productsDbContext = value;
        }
        public CustomerPO(string conn)
        {
            mConn = conn;
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
        private readonly string mConn;

        #region Delete

        public int DeleteCustomers(List<Custom> deleteCustoms)
        {
            using (var db = new ProductsDbContext())
            {
                foreach (var deleteCustom in deleteCustoms)
                {
                    db.Customs.Attach(deleteCustom);
                    db.Entry(deleteCustom).State = EntityState.Deleted;
                }

                var result = db.SaveChangesAsync().Result;
                return result;
            }
        }

        #endregion

        #region Save

        public int SaveCustomers(List<Custom> insertCustoms)
        {
            using (var db = new ProductsDbContext())
            {
                db.Customs.AddRange(insertCustoms);
                var result = db.SaveChangesAsync().Result;
                return result;
            }
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

        public async Task DistinctCustomerAsync()
        {
            List<KeyAndName> result = new List<KeyAndName>();

            result = await this.ProductsDbContext.Customs.Select(a => new KeyAndName
                               {
                                   Code             = a.CustomName,
                                   LocalDescription = a.Address
                               })
                               .Distinct().AsNoTracking().ToListAsync();

            if (result.Any())
            {
                Const.CustomerNameList.AddRange(result);
            }
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