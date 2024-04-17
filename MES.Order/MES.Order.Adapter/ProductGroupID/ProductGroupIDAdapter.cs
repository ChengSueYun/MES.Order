using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.DAL;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;

namespace MES.Order.Adapter
{
    public class ProductGroupIDAdapter : IProductGroupIDAdapter
    {
        internal ProductGroupIDPO ProductGroupIDPO
        {
            get
            {
                if (this._ProductGroupIDPO == null)
                {
                    this._ProductGroupIDPO = new ProductGroupIDPO(BasicOldUtlity.OldConn);
                }

                return this._ProductGroupIDPO;
            }
            set => this._ProductGroupIDPO = value;
        }

        private ProductGroupIDPO _ProductGroupIDPO;

        public List<KeyAndNameForCombo> QueryProductGroupIds()
        {
            return this.ProductGroupIDPO.QueryAllProductsGroupID();
        }

        public async Task GetProductGroupIdAsync()
        {
            await this.ProductGroupIDPO.GetProductGroupIdAsync();
        }

        public List<ProductsGroupID> QueryAll()
        {
            return this.ProductGroupIDPO.QueryAll();
        }
    }
}