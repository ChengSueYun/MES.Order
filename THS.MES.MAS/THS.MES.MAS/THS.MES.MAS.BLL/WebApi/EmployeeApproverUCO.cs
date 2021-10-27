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
    public class EmployeeApproverUCO
    {
        private IEmployeeApproverAdapter _employeeApproverAdapter;

        internal IEmployeeApproverAdapter employeeApproverAdapter
        {
            get => this._employeeApproverAdapter ?? (this._employeeApproverAdapter = new EmployeeApproverAdapter());
            set => this._employeeApproverAdapter = value;
        }

        #region Implementation of IEmployeeApproverAdapter

        public List<EmployeeApproverViewModel> QueryAll() => this.employeeApproverAdapter.QueryAll();

        public List<EmployeeApproverViewModel> QueryByName(string name) =>
            this.employeeApproverAdapter.QueryByName(name);

        public List<EmployeeApproverViewModel> QueryByNames(List<string> names) =>
            this.employeeApproverAdapter.QueryByNames(names);

        public List<EmployeeApproverViewModel> QueryByDeptId(string deptId) =>
            this.employeeApproverAdapter.QueryByDeptId(deptId);

        public List<EmployeeApproverViewModel> QueryByDeptIds(List<string> deptIds) =>
            this.employeeApproverAdapter.QueryByDeptIds(deptIds);

        public List<EmployeeApproverViewModel> QueryBySalaryDeptId(string SalaryDeptId) =>
            this.employeeApproverAdapter.QueryBySalaryDeptId(SalaryDeptId);

        public List<EmployeeApproverViewModel> QueryBySalaryDeptIds(List<string> SalaryDeptIds) =>
            this.employeeApproverAdapter.QueryBySalaryDeptIds(SalaryDeptIds);

        public List<EmployeeApproverViewModel> StartWithDeptId(string deptId) =>
            this.employeeApproverAdapter.StartWithDeptId(deptId);

        public EmployeeApproverViewModel QueryByEmployeeId(string employeeId) =>
            this.employeeApproverAdapter.QueryByEmployeeId(employeeId);

        public List<EmployeeApproverViewModel> QueryByEmployeeIds(List<string> employeeIds) =>
            this.employeeApproverAdapter.QueryByEmployeeIds(employeeIds);

        public EmployeeApproverViewModel QueryByAutoId(int autoId) =>
            this.employeeApproverAdapter.QueryByAutoId(autoId);

        #endregion
    }
}