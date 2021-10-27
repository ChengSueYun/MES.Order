using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;
using THS.MES.MAS.BLL.WebApi;
using THS.MES.MAS.Infrastructure.ViewModel;
using THS.MES.MAS.Utility;
using THS.MES.MAS.WebAPI.Modules;
using static THS.MES.MAS.WebAPI.Modules.GlobalPara;

namespace THS.MES.MAS.WebAPI.Controllers
{
    public class WorkTypeController  : ApiController
    {
        private WorkTypeUCO _workTypeUco;

        private const string pLocationId = "H";

        #region Initial

        private WorkTypeController()
        {
            this.InitialUtility();
        }

        private void InitialUtility()
        {
            var configConnectionName = GetConfigConnectionName(pLocationId, GlobalPara.DB.MAS);

            MASUtility.ConnectionString = ConfigurationManager.ConnectionStrings[configConnectionName].ConnectionString;
            this._workTypeUco           = new WorkTypeUCO();
        }

        #endregion

        [HttpGet]
        [Route("api/WorkTypes/GetWorkTypes")]
        public List<WorkTypeViewModel> GetWorkTypes([FromUri] List<string> WorkTypes)
        {
            try
            {
                var result = this._workTypeUco.QueryAllByWorkTypes(WorkTypes);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        [HttpGet]
        [Route("api/WorkType/GetWorkType")]
        public WorkTypeViewModel GetWorkType([FromUri] string WorkType)
        {
            try
            {
                var result = this._workTypeUco.QueryAllByWorkType(WorkType);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        // // GET api/values
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }
        //
        // // GET api/values/5
        // public string Get(int id)
        // {
        //     return "value";
        // }
        //
        // // POST api/values
        // public void Post([FromBody] string value)
        // {
        // }
        //
        // // PUT api/values/5
        // public void Put(int id, [FromBody] string value)
        // {
        // }
        //
        // // DELETE api/values/5
        // public void Delete(int id)
        // {
        // }
    }
}