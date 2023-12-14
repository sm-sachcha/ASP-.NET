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
    public class UnitOfProductController : ApiController
    {
        [HttpGet]
        [Route("api/unit/all")]
        public HttpResponseMessage AllUnit()
        {
            try
            {
                var data = UnitOfProductServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/unit/{id}")]
        public HttpResponseMessage UnitById(int id)
        {
            try
            {
                var data = UnitOfProductServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/unit/add")]
        public HttpResponseMessage Add(UnitOfProductDTO unit)
        {
            try
            {
                var data = UnitOfProductServices.Add(unit);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/unit/edit")]
        public HttpResponseMessage Edit(UnitOfProductDTO unit)
        {
            try
            {
                var data = UnitOfProductServices.Edit(unit);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/unit/delete")]
        public HttpResponseMessage Delete(UnitOfProductDTO employee)
        {
            try
            {
                var data = UnitOfProductServices.Delete(employee);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
