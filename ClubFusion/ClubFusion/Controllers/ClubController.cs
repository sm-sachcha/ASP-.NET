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
    public class ClubController : ApiController
    {
        [HttpGet]
        [Route("api/club/all")]
        public HttpResponseMessage AllEmployee()
        {
            try
            {
                var data = ClubServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/club/{id}")]
        public HttpResponseMessage EmployeeById(int id)
        {
            try
            {
                var data = ClubServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }


        [HttpPost]
        [Route("api/club/add")]
        public HttpResponseMessage Add(ClubDTO clubDTO)
        {
            try
            {
                var data = ClubServices.Add(clubDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/club/edit")]
        public HttpResponseMessage Edit(ClubDTO club)
        {
            try
            {
                var data = ClubServices.Edit(club);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/club/delete")]
        public HttpResponseMessage Delete(ClubDTO club)
        {
            try
            {
                var data = ClubServices.Delete(club);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
