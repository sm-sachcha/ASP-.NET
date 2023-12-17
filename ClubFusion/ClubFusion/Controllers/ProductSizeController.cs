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
    public class ProductSizeController : ApiController
    {
        [HttpGet]
        [Route("api/productsize/all]")]
        public HttpResponseMessage AllColor()
        {
            try
            {
                var data = ProductSizeServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPost]
        [Route("api/productsize/add]")]
        public HttpResponseMessage Add(ProductSizeDTO productSize)
        {
            try
            {
                var data = ProductSizeServices.Add(productSize);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPost]
        [Route("api/productsize/delete]")]
        public HttpResponseMessage Delete(ProductSizeDTO productSize)
        {
            try
            {
                var data = ProductSizeServices.Delete(productSize);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/productsize/edit]")]
        public HttpResponseMessage Edit(ProductSizeDTO productSize)
        {
            try
            {
                var data = ProductSizeServices.Edit(productSize);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
