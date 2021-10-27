using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THS.MES.MAS.Adapter.Interface;
using THS.MES.MAS.DAL.EntityModel;
using THS.MES.MAS.DAL.Repository;
using THS.MES.MAS.Infrastructure.ViewModel;

namespace THS.MES.MAS.Adapter.Implement
{
    public class WorkTypeAdapter : IWorkTypeAdapter
    {
        private WorkTypeRepository _workTypeRepository;

        internal WorkTypeRepository WorkTypeRepository
        {
            get => this._workTypeRepository ??
                   (this._workTypeRepository = new WorkTypeRepository(Utility.MASUtility.MasDbContext));
            set => this._workTypeRepository = value;
        }

        #region Implementation of IWorkTypeAdapter

        public List<WorkTypeViewModel> QueryAll() => this._workTypeRepository.QueryAll();

        public WorkTypeViewModel QueryAllByWorkType(string pWorkType) =>
            this.WorkTypeRepository.QueryAllByWorkType(pWorkType);

        public List<WorkTypeViewModel> QueryAllByWorkTypes(List<string> pWorkType) =>
            this.WorkTypeRepository.QueryAllByWorkTypes(pWorkType);

        public bool Insert(List<WorkTypes> insertWorkTypesList) => this.WorkTypeRepository.Insert(insertWorkTypesList);

        public bool Insert(WorkTypes insertWorkTypes) => this.WorkTypeRepository.Insert(insertWorkTypes);

        public bool Delete(List<WorkTypes> deleteWorkTypesList) => this.WorkTypeRepository.Delete(deleteWorkTypesList);

        public bool Delete(WorkTypes deleteWorkTypes) => this.WorkTypeRepository.Delete(deleteWorkTypes);

        public bool Update(List<WorkTypes> updateWorkTypesList) => this.WorkTypeRepository.Update(updateWorkTypesList);

        public bool Update(WorkTypes updateWorkTypes) => this.WorkTypeRepository.Update(updateWorkTypes);

        #endregion
    }
}