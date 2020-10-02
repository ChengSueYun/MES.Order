using System.Collections.Generic;
using System.Linq;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;

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
            using (var db =
                ProductsDbContext.CreateAndOpen(this.ProductsDbContext.Database.Connection.ConnectionString))
            {
                var filter = db.Areas
                               .ToList();

                var result = (from a in filter
                              select new KeyAndNameForCombo
                              {
                                  Code             = a.AreaName,
                                  LocalDescription = a.AreaName
                              }).Distinct().ToList();
                return result;
            }
        }
    }
}