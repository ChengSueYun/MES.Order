using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.NewEntityFramework;
using MES.Order.DAL.ViewModel;
using MES.Order.Infrastructure;
using KeyAndNameForCombo = MES.Order.DAL.ViewModel.KeyAndNameForCombo;

namespace MES.Order.DAL
{
    public class AreaPO
    {
        private string mConn = "";
        internal ProductsDbContext ProductsDbContext
        {
            get
            {
                if (this._productsDbContext == null)
                {
                    this._productsDbContext =  ProductsDbContext.Create(mConn);
                }

                return this._productsDbContext;
            }
            set => this._productsDbContext = value;
        }

        private ProductsDbContext _productsDbContext;

        public AreaPO(string conn)
        {
            mConn = conn;
        }

        public List<KeyAndNameForCombo> GetArea()
        {
            var filter = this.ProductsDbContext.Areas.ToListAsync().Result;
            var result = (from a in filter
                          select new KeyAndNameForCombo
                          {
                              Code             = a.AreaName,
                              LocalDescription = a.AreaName
                          }).Distinct().ToList();
            return result;
        }

        /// <summary>
        /// Get Area Data List
        /// </summary>
        public async Task GetAreaAsync()
        {
            var dbUsecaseParameters = await this.ProductsDbContext.Areas
                                                .Select(a => new KeyAndName
                                                {
                                                    Code             = a.AreaName,
                                                    LocalDescription = a.AreaName
                                                })
                                                .Distinct().AsNoTracking().ToListAsync();

            if (dbUsecaseParameters.Any())
            {
                Const.AreaList.AddRange(dbUsecaseParameters);
            }
        }

        /// <summary>
        /// Get Area Data List
        /// </summary>
        public List<Areas> QueryAll()
        {
            return this.ProductsDbContext.Areas.ToListAsync().Result;
        }
    }
}