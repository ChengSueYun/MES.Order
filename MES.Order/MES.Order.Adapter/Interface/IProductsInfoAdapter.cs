using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.Infrastructure;
using MES.Order.Infrastructure.NewViewModel;

namespace MES.Order.Adapter.Interface
{
    public interface IProductsInfoAdapter
    {
        Task<List<ProductsInfoViewModel>> Get();

        Task<bool> AddOrUpdate(IEnumerable<ProductsInfoViewModel> FromUi);
        Task<bool> AddOrUpdate(ProductsInfoViewModel FromUi);

        Task<bool> Delete(string pFactory, string pProduct);

        Task<List<KeyAndName>> GetProductNameAsync();

        Task<List<KeyAndName>> GetProductTypeAsync();
    }
}