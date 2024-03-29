using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.Adapter.Interface;
using MES.Order.DAL.Repository;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;

namespace MES.Order.Adapter.Implement
{
    public class ProductsInfoAdapter : IProductsInfoAdapter
    {
        private ProductsInfoRepository mPo;

        private ProductsInfoRepository _po
        {
            get => this.mPo ?? new ProductsInfoRepository(BasicUtility.Conn);
            set => this.mPo = value;
        }

        /// <inheritdoc />
        public Task<List<ProductsInfoViewModel>> Get()
        {
            return this._po.Get();
        }

        /// <inheritdoc />
        public Task<bool> AddOrUpdate(IEnumerable<ProductsInfoViewModel> FromUi)
        {
            return this._po.AddOrUpdate(FromUi);
        }

        /// <inheritdoc />
        public Task<bool> AddOrUpdate(ProductsInfoViewModel FromUi)
        {
            return this._po.AddOrUpdate(FromUi);
        }

        /// <inheritdoc />
        public Task<bool> Delete(string pFactory, string pProduct)
        {
            return this._po.Delete(pFactory, pProduct);
        }

        /// <inheritdoc />
        public Task<List<KeyAndName>> GetProductNameAsync()
        {
            return this._po.GetProductNameAsync();
        }

        /// <inheritdoc />
        public Task<List<KeyAndName>> GetProductTypeAsync()
        {
            return this._po.GetProductTypeAsync();
        }
    }
}