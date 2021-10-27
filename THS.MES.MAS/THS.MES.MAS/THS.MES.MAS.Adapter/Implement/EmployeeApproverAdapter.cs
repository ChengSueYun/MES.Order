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
    public class EmployeeApproverAdapter : IEmployeeApproverAdapter
    {
        private EmployeeApproverRepository _repository;

        internal EmployeeApproverRepository Repository
        {
            get => this._repository ??
                   (this._repository = new EmployeeApproverRepository(Utility.MASUtility.MasDbContext));
            set => this._repository = value;
        }

        #region Implementation of IEmployeeApproverAdapter

        public List<EmployeeApproverViewModel> QueryAll() => this.Repository.QueryAll();

        public List<EmployeeApproverViewModel> QueryByName(string name) => this.Repository.QueryByName(name);

        public List<EmployeeApproverViewModel> QueryByNames(List<string> names) => this.Repository.QueryByNames(names);

        public List<EmployeeApproverViewModel> QueryByDeptId(string deptId) => this.Repository.QueryByDeptId(deptId);

        public List<EmployeeApproverViewModel> QueryByDeptIds(List<string> deptIds) =>
            this.Repository.QueryByDeptIds(deptIds);

        public List<EmployeeApproverViewModel> QueryBySalaryDeptId(string SalaryDeptId) =>
            this.Repository.QueryBySalaryDeptId(SalaryDeptId);

        public List<EmployeeApproverViewModel> QueryBySalaryDeptIds(List<string> SalaryDeptIds) =>
            this.Repository.QueryBySalaryDeptIds(SalaryDeptIds);

        public List<EmployeeApproverViewModel> StartWithDeptId(string deptId) =>
            this.Repository.StartWithDeptId(deptId);

        public EmployeeApproverViewModel QueryByEmployeeId(string employeeId) =>
            this.Repository.QueryByEmployeeId(employeeId);

        public List<EmployeeApproverViewModel> QueryByEmployeeIds(List<string> employeeIds) =>
            this.Repository.QueryByEmployeeIds(employeeIds);

        public EmployeeApproverViewModel QueryByAutoId(int autoId) => this.Repository.QueryByAutoId(autoId);

        public bool Insert(List<EmployeeApprover> insertList) => this.Repository.Insert(insertList);

        public bool Insert(EmployeeApprover insert) => this.Repository.Insert(insert);

        public bool Delete(List<EmployeeApprover> deleteList) => this.Repository.Delete(deleteList);

        public bool Delete(EmployeeApprover delete) => this.Repository.Delete(delete);

        public bool Update(List<EmployeeApprover> updateList) => this.Repository.Update(updateList);

        public bool Update(EmployeeApprover update) => this.Repository.Update(update);

        #endregion
    }
}