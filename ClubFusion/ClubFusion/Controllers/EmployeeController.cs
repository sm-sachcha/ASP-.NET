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
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/employee/all")]
        public HttpResponseMessage AllEmployee()
        {
            try
            {
                var data = EmployeeServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/employee/{id}")]
        public HttpResponseMessage EmployeeById(int id)
        {
            try
            {
                var data = EmployeeServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/employee/add")]
        public HttpResponseMessage Add(EmployeeDTO employee)
        {
            try
            {
                var data = EmployeeServices.Add(employee);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/employee/edit")]
        public HttpResponseMessage Edit(EmployeeDTO employee)
        {
            try
            {
                var data = EmployeeServices.Edit(employee);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/employee/delete")]
        public HttpResponseMessage Delete(EmployeeDTO employee)
        {
            try
            {
                var data = EmployeeServices.Delete(employee);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
