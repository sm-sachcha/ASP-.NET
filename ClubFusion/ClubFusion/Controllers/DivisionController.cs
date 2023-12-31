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
    public class DivisionController : ApiController
    {
        [HttpGet]
        [Route("api/division/all")]
        public HttpResponseMessage AllDivisions()
        {
            try
            {
                var data = DivisionServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/division/{id}")]
        public HttpResponseMessage DivisionByID(int id)
        {
            try
            {
                var data = DivisionServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/division/add")]
        public HttpResponseMessage Add(DivisionDTO div)
        {
            try
            {
                var data = DivisionServices.Add(div);
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
        [Route("api/division/edit")]
        public HttpResponseMessage Edit(DivisionDTO division)
        {
            try
            {
                var data = DivisionServices.Edit(division);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (InvalidOperationException ex)
            {
                if (ex.Message.Contains("Employee & Monitoring Manager can edit the Division"))
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Employee & Monitoring Manager can edit the Division");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error editing Division");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }



        [HttpPost]
        [Route("api/division/delete")]
        public HttpResponseMessage Delete(DivisionDTO division)
        {
            try
            {
                var data = DivisionServices.Delete(division);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
