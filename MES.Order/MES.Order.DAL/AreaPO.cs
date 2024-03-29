using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;
using MES.Order.Infrastructure;
using KeyAndNameForCombo = MES.Order.DAL.ViewModel.KeyAndNameForCombo;

namespace MES.Order.DAL
{
    public class AreaPO
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
    }
}