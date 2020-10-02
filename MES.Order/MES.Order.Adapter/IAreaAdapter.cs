using System.Collections.Generic;
using MES.Order.DAL.ViewModel;

namespace MES.Order.Adapter
{
    public interface IAreaAdapter
    {
        List<KeyAndNameForCombo> GetArea();
    }
}