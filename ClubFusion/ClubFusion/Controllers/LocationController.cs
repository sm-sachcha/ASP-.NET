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
    public class LocationController : ApiController
    {
        [HttpGet]
        [Route("api/location/all")]
        public HttpResponseMessage AllLocation()
        {
            try
            {
                var data = LocationServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/location/{id}")]
        public HttpResponseMessage LocationById(int id)
        {
            try
            {
                var data = LocationServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }


        [HttpPost]
        [Route("api/location/add")]
        public HttpResponseMessage Add(LocationDTO Location)
        {
            try
            {
                var data = LocationServices.Add(Location);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/location/edit")]
        public HttpResponseMessage Edit(LocationDTO Location)
        {
            try
            {
                var data = LocationServices.Edit(Location);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/location/delete")]
        public HttpResponseMessage Delete(LocationDTO Location)
        {
            try
            {
                var data = LocationServices.Delete(Location);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
