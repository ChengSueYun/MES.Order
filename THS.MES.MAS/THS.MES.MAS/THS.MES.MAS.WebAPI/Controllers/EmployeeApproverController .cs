using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Swagger.Net.Annotations;
using THS.MES.MAS.BLL.WebApi;
using THS.MES.MAS.Infrastructure.ViewModel;
using THS.MES.MAS.Utility;
using THS.MES.MAS.WebAPI.Modules;
using static THS.MES.MAS.WebAPI.Modules.GlobalPara;

namespace THS.MES.MAS.WebAPI.Controllers
{
  /// <summary>
  /// 員工基本資料
  /// </summary>
    [RoutePrefix("api/EmployeeApprover")]
    public class EmployeeApproverController : ApiController
    {
        private EmployeeApproverUCO _uco;

        private const string pLocationId = "H";

        #region Initial

        private EmployeeApproverController()
        {
            this.InitialUtility();
        }

        private void InitialUtility()
        {
            var configConnectionName = GetConfigConnectionName(pLocationId, GlobalPara.DB.MAS);

            MASUtility.ConnectionString = ConfigurationManager.ConnectionStrings[configConnectionName].ConnectionString;
            this._uco                   = new EmployeeApproverUCO();
        }

        /// <summary>
        /// 取得所有員工基本資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("QueryAll")]
        [ResponseType(typeof(List<EmployeeApproverViewModel>))]
        [SwaggerOperation(Tags = new[] {"員工基本資料"})]
        public List<EmployeeApproverViewModel> QueryAll() => this._uco.QueryAll();

        /// <summary>
        /// 取得單一員工姓名的基本資料
        /// </summary>
        /// <param name="name">員工姓名</param>
        /// <returns></returns>
        [HttpGet]
        [Route("QueryByName")]
        [SwaggerExample("name", "鄭素雲")]
        [ResponseType(typeof(List<EmployeeApproverViewModel>))]
        [SwaggerOperation(Tags = new[] {"取得員工基本資料"})]
        public async Task<HttpResponseMessage> QueryByName([FromUri] string name)
        {
            var employeeApproverViewModels = this._uco.QueryByName(name);
            return this.Request.CreateResponse(HttpStatusCode.OK, employeeApproverViewModels);
        }

        /// <summary>
        /// 取得多位員工姓名的基本資料
        /// </summary>
        /// <param name="names">員工姓名</param>
        /// <returns></returns>
        [HttpGet]
        [Route("QueryByNames")]
        [SwaggerExample("names", "鄭素雲")]
        [ResponseType(typeof(List<EmployeeApproverViewModel>))]
        [SwaggerOperation(Tags = new[] {"取得員工基本資料"})]
        public async Task<HttpResponseMessage> QueryByNames([FromUri] List<string> names)
        {
            var employeeApproverViewModels = this._uco.QueryByNames(names);
            return this.Request.CreateResponse(HttpStatusCode.OK, employeeApproverViewModels);
        }

        /// <summary>
        /// 取得單一部門的員工基本資料
        /// </summary>
        /// <param name="deptId">部門代號</param>
        /// <returns></returns>
        [HttpGet]
        [Route("QueryByDeptId")]
        [SwaggerExample("deptId", "S030")]
        [ResponseType(typeof(List<EmployeeApproverViewModel>))]
        [SwaggerOperation(Tags = new[] {"取得員工基本資料"})]
        public async Task<HttpResponseMessage> QueryByDeptId([FromUri] string deptId)
        {
            var employeeApproverViewModels = this._uco.QueryByDeptId(deptId);
            return this.Request.CreateResponse(HttpStatusCode.OK, employeeApproverViewModels);
        }

        /// <summary>
        /// 取得多個部門員工的基本資料
        /// </summary>
        /// <param name="deptIds">部門代號</param>
        /// <returns></returns>
        [HttpGet]
        [Route("QueryByDeptIds")]
        [SwaggerExample("deptIds", "S030")]
        [ResponseType(typeof(List<EmployeeApproverViewModel>))]
        [SwaggerOperation(Tags = new[] {"取得員工基本資料"})]
        public async Task<HttpResponseMessage> QueryByDeptIds([FromUri] List<string> deptIds)
        {
            var employeeApproverViewModels = this._uco.QueryByDeptIds(deptIds);
            return this.Request.CreateResponse(HttpStatusCode.OK, employeeApproverViewModels);
        }

        /// <summary>
        /// 取得單一授薪部門員工的基本資料
        /// </summary>
        /// <param name="SalaryDeptId">授薪部門代號</param>
        /// <returns></returns>
        [HttpGet]
        [Route("QueryBySalaryDeptId")]
        [SwaggerExample("SalaryDeptId", "S030")]
        [ResponseType(typeof(List<EmployeeApproverViewModel>))]
        [SwaggerOperation(Tags = new[] {"取得員工基本資料"})]
        public async Task<HttpResponseMessage> QueryBySalaryDeptId([FromUri] string SalaryDeptId)
        {
            var queryBySalaryDeptId = this._uco.QueryBySalaryDeptId(SalaryDeptId);
            return this.Request.CreateResponse(HttpStatusCode.OK, queryBySalaryDeptId);
        }

        /// <summary>
        /// 取得多個授薪部門員工的基本資料
        /// </summary>
        /// <param name="SalaryDeptIds">授薪部門代號</param>
        /// <returns></returns>
        [HttpGet]
        [Route("QueryBySalaryDeptIds")]
        [SwaggerExample("SalaryDeptIds", "S030")]
        [ResponseType(typeof(List<EmployeeApproverViewModel>))]
        [SwaggerOperation(Tags = new[] {"取得員工基本資料"})]
        public async Task<HttpResponseMessage> QueryBySalaryDeptIds([FromUri] List<string> SalaryDeptIds)
        {
            var queryBySalaryDeptIds = this._uco.QueryBySalaryDeptIds(SalaryDeptIds);
            return this.Request.CreateResponse(HttpStatusCode.OK, queryBySalaryDeptIds);
        }

        /// <summary>
        /// 取得多個部門員工的基本資料
        /// </summary>
        /// <param name="deptId">部門代號</param>
        /// <returns></returns>
        [HttpGet]
        [Route("StartWithDeptId")]
        [SwaggerExample("deptId", "H14")]
        [ResponseType(typeof(List<EmployeeApproverViewModel>))]
        [SwaggerOperation(Tags = new[] {"取得員工基本資料"})]
        public async Task<HttpResponseMessage> StartWithDeptId([FromUri] string deptId)
        {
            var employeeApproverViewModels = this._uco.StartWithDeptId(deptId);
            return this.Request.CreateResponse(HttpStatusCode.OK, employeeApproverViewModels);
        }

        /// <summary>
        /// 取得單一員工的基本資料
        /// </summary>
        /// <param name="employeeId">工號</param>
        /// <returns></returns>
        [HttpGet]
        [Route("QueryByEmployeeId")]
        [SwaggerExample("employeeId", "H462")]
        [ResponseType(typeof(List<EmployeeApproverViewModel>))]
        [SwaggerOperation(Tags = new[] {"取得員工基本資料"})]
        public async Task<HttpResponseMessage> QueryByEmployeeId([FromUri] string employeeId)
        {
            var employeeApproverViewModel = this._uco.QueryByEmployeeId(employeeId);
            return this.Request.CreateResponse(HttpStatusCode.OK, employeeApproverViewModel);
        }

        /// <summary>
        /// 取得多個員工的基本資料
        /// </summary>
        /// <param name="employeeIds">工號</param>
        /// <returns></returns>
        [HttpGet]
        [Route("QueryByEmployeeIds")]
        [SwaggerExample("employeeIds", "H462")]
        [ResponseType(typeof(List<EmployeeApproverViewModel>))]
        [SwaggerOperation(Tags = new[] {"取得員工基本資料"})]
        public List<EmployeeApproverViewModel> QueryByEmployeeIds([FromUri] List<string> employeeIds)
        {
            return this._uco.QueryByEmployeeIds(employeeIds);
        }

        [HttpGet]
        [Route("QueryByAutoId")]
        [SwaggerOperation(Tags = new[] {"取得員工基本資料"})]
        public EmployeeApproverViewModel QueryByAutoId([FromUri] int autoId)
        {
            return this._uco.QueryByAutoId(autoId);
        }

        #endregion
    }
}