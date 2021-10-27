using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THS.MES.MAS.Adapter.Implement;
using THS.MES.MAS.Adapter.Interface;
using THS.MES.MAS.Infrastructure.ViewModel;

namespace THS.MES.MAS.BLL.WebApi
{
    public class WorkTypeUCO
    {
        public WorkTypeUCO()
        {

        }
        private IWorkTypeAdapter _WorkTypeAdapter;
        internal IWorkTypeAdapter workTypeAdapter
        {
            get => this._WorkTypeAdapter ?? (this._WorkTypeAdapter = new WorkTypeAdapter());
            set => this._WorkTypeAdapter = value;
            
        }
        #region Implementation of IWorkTypeAdapter

        public List<WorkTypeViewModel> QueryAll() => this.workTypeAdapter.QueryAll();

        public WorkTypeViewModel QueryAllByWorkType(string pWorkType) =>
            this.workTypeAdapter.QueryAllByWorkType(pWorkType);

        public List<WorkTypeViewModel> QueryAllByWorkTypes(List<string> pWorkType) =>
            this.workTypeAdapter.QueryAllByWorkTypes(pWorkType);

        #endregion
    }
}