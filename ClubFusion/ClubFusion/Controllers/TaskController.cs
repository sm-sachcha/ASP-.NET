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
    public class TaskController : ApiController
    {
        [HttpGet]
        [Route("api/task/all")]
        public HttpResponseMessage AllTask()
        {
            try
            {
                var data = TaskServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/task/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = TaskServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/task/add")]
        public HttpResponseMessage Add(TaskDTO task)
        {
            try
            {
                var data = TaskServices.Add(task);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/task/edit")]
        public HttpResponseMessage Edit(TaskDTO task)
        {
            try
            {
                var data = TaskServices.Edit(task);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/task/delete")]
        public HttpResponseMessage Delete (TaskDTO task)
        {
            try
            {
                var data = TaskServices.Delete(task);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
