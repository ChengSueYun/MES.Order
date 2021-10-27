using System.Collections.Generic;
using THS.MES.MAS.DAL.EntityModel;
using THS.MES.MAS.Infrastructure.ViewModel;

namespace THS.MES.MAS.Adapter.Interface
{
    public interface IWorkTypeAdapter
    {
        #region Query

        List<WorkTypeViewModel> QueryAll();

        WorkTypeViewModel QueryAllByWorkType(string pWorkType);

        List<WorkTypeViewModel> QueryAllByWorkTypes(List<string> pWorkType);

        #endregion

        #region Insert

        bool Insert(List<WorkTypes> insertWorkTypesList);

        bool Insert(WorkTypes insertWorkTypes);

        #endregion

        #region Delete

        bool Delete(List<WorkTypes> deleteWorkTypesList);

        bool Delete(WorkTypes deleteWorkTypes);

        #endregion

        #region Update

        bool Update(List<WorkTypes> updateWorkTypesList);

        bool Update(WorkTypes updateWorkTypes);

        #endregion
    }
}