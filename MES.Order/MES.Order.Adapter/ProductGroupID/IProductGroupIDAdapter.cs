using System.Collections.Generic;
using System.Threading.Tasks;
using MES.Order.DAL.EntityFramework;
using MES.Order.DAL.ViewModel;

namespace MES.Order.Adapter
{
    public interface IProductGroupIDAdapter
    {
        List<KeyAndNameForCombo> QueryProductGroupIds();
        
        Task GetProductGroupIdAsync();

        List<ProductsGroupID> QueryAll();
    }
}