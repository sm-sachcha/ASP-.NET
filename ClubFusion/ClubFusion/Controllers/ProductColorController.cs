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
    public class ProductColorController : ApiController
    {
        [HttpGet]
        [Route("api/productcolor/all")]
        public HttpResponseMessage AllColor()
        {
            try
            {
                var data = ProductColorServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPost]
        [Route("api/productcolor/add")]
        public HttpResponseMessage AddGet(ProductColorDTO productColor)
        {
            try
            {
                var data = ProductColorServices.Add(productColor);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        
        [HttpPost]
        [Route("api/productcolor/edit")]
        public HttpResponseMessage Edit(ProductColorDTO productColor)
        {
            try
            {
                var data = ProductColorServices.Edit(productColor);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/productcolor/delete")]
        public HttpResponseMessage DeletePost(ProductColorDTO productColor)
        {
            try
            {
                var data = ProductColorServices.Delete(productColor);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
