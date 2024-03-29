using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.DAL;
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
                    this._ProductGroupIDPO = new ProductGroupIDPO();
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
    }
}