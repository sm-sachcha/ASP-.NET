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
    public class ClubManagerController : ApiController
    {
        [HttpGet]
        [Route("api/clubmanager/all")]
        public HttpResponseMessage AllClubManager()
        {
            try
            {
                var data = ClubManagerServices.GetALL();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/clubmanager/{id}")]
        public HttpResponseMessage ClubManagerById(int id)
        {
            try
            {
                var data = ClubManagerServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/clubmanager/add")]
        public HttpResponseMessage Add(ClubManagerDTO clubManager)
        {
            try
            {
                var data = ClubManagerServices.Add(clubManager);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/clubmanager/edit")]
        public HttpResponseMessage Edit(ClubManagerDTO clubManager)
        {
            try
            {
                var data = ClubManagerServices.Edit(clubManager);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/clubmanager/delete")]
        public HttpResponseMessage Delete(ClubManagerDTO clubManager)
        {
            try
            {
                var data = ClubManagerServices.Delete(clubManager);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
