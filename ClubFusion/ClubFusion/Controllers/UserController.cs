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
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("api/user/all")]
        public HttpResponseMessage AllUsers()
        {
            try
            {
                var data = UserServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/user/{id}")]
        public HttpResponseMessage UserById(int id)
        {
            try
            {
                var data = UserServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/user/add")]
        public HttpResponseMessage Add(UserDTO user)
        {
            try
            {
                var data = UserServices.Add(user);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/user/Edit")]
        public HttpResponseMessage Edit(UserDTO user)
        {
            try
            {
                var data = UserServices.Edit(user);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/user/Delete")]
        public HttpResponseMessage Delete(UserDTO user)
        {
            try
            {
                var data = UserServices.Delete(user);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
