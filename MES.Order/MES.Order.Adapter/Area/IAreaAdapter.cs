using System.Collections.Generic;
using MES.Order.DAL.ViewModel;
using System.Threading.Tasks;
using MES.Order.DAL.EntityFramework;

namespace MES.Order.Adapter
{
    public interface IAreaAdapter
    {
        List<KeyAndNameForCombo> GetArea();

        Task GetAreaAsync();

        List<Areas> QueryAll();
    }
}