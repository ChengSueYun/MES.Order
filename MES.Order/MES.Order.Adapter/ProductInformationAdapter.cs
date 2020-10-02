using System.Collections.Generic;
using MES.Order.DAL;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;

namespace MES.Order.Adapter
{
    public class ProductInformationAdapter : IProductsInformationAdapter
    {
        internal ProductsInformationPO productsInformationPo
        {
            get
            {
                if (this._productsInformationPo == null)
                {
                    this._productsInformationPo = new ProductsInformationPO();
                }

                return this._productsInformationPo;
            }
            set => this._productsInformationPo = value;
        }

        private ProductsInformationPO _productsInformationPo;

        public List<ProductsInfomation> QueryAllProducts(string ProductGroupID, string ProductName)
        {
            return this.productsInformationPo.QueryAllProducts(ProductGroupID, ProductName);
        }

        public List<KeyAndNameForCombo> DistinctProductName(string ProductGroupID)
        {
            return this.productsInformationPo.DistinctProductName(ProductGroupID);
        }

        public List<KeyAndNameForCombo> DistinctProductName()
        {
            return this.productsInformationPo.DistinctProducts();
        }

        public int SaveProductsInfomations(List<ProductsInfomation> insertProductsInfomations)
        {
            return this.productsInformationPo.SaveProductsInfomations(insertProductsInfomations);
        }

        public int DeleteProductsInfomations(List<ProductsInfomation> deleteProductsInfomations)
        {
            return this.productsInformationPo.DeleteProductsInfomations(deleteProductsInfomations);
        }
    }
}