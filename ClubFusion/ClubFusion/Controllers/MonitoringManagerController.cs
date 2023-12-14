using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ClubFusion.Controllers
{
    [EnableCors("*", "*", "*")]
    public class MonitoringManagerController : ApiController
    {
        [HttpGet]
        [Route("api/monitoringmanager/all")]
        public HttpResponseMessage AllMonitoringManager()
        {
            try
            {
                var data = MonitoringManagerServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/monitoringmanager/{id}")]
        public HttpResponseMessage MonitoringManagerById(int id)
        {
            try
            {
                var data = MonitoringManagerServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/monitoringmanager/add")]
        public HttpResponseMessage Add(MonitoringManagerDTO monitoringManager)
        {
            try
            {
                var data = MonitoringManagerServices.Add(monitoringManager);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPost]
        [Route("api/monitoringmanager/edit")]
        public HttpResponseMessage Edit(MonitoringManagerDTO monitoringManager)
        {
            try
            {
                var data = MonitoringManagerServices.Edit(monitoringManager);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/monitoringmanager/delete")]
        public HttpResponseMessage Delete(MonitoringManagerDTO monitoringManager)
        {
            try
            {
                var data = MonitoringManagerServices.Delete(monitoringManager);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
