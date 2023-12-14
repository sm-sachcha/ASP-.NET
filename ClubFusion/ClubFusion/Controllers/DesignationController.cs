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
    public class DesignationController : ApiController
    {
        [HttpGet]
        [Route("api/designation/all")]
        public HttpResponseMessage AllDesignation()
        {
            try
            {
                var data = DesignationServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/designation/{id}")]
        public HttpResponseMessage DesignationById(int id)
        {
            try
            {
                var data = DesignationServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/designation/add")]
        public HttpResponseMessage Add(DesignationDTO designation)
        {
            try
            {
                var data = DesignationServices.Add(designation);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/designation/edit")]
        public HttpResponseMessage Edit(DesignationDTO designation)
        {
            try
            {
                var data = DesignationServices.Edit(designation);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/designation/delete")]
        public HttpResponseMessage Delete(DesignationDTO designation)
        {
            try
            {
                var data = DesignationServices.Delete(designation);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
