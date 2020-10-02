using System.Collections.Generic;
using MES.Order.DAL.ViewModel;

namespace MES.Order.Adapter
{
    public interface IProductGroupIDAdapter
    {
        List<KeyAndNameForCombo> QueryProductGroupIds();
    }
}