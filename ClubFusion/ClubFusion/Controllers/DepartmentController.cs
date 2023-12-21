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
    public class DepartmentController : ApiController
    {
        [HttpGet]
        [Route("api/dept/all")]
        public HttpResponseMessage AllDept()
        {
            try
            {
                var data = DepartmentServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/dept/add")]
        public HttpResponseMessage Add(DepartmentDTO department)
        {
            try
            {
                var data = DepartmentServices.Add(department);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (InvalidOperationException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("api/dept/edit")]
        public HttpResponseMessage Edit(DepartmentDTO department)
        {
            try
            {
                var data = DepartmentServices.Edit(department);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (InvalidOperationException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpPost]
        [Route("api/dept/delete")]
        public HttpResponseMessage Delete(DepartmentDTO department)
        {
            try
            {
                var data = DepartmentServices.Delete(department);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
