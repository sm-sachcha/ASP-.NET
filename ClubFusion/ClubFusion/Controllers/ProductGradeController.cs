using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClubFusion.Controllers
{
    public class ProductGradeController : ApiController
    {
        [HttpGet]
        [Route("api/productgrade/all")]
        public HttpResponseMessage AllGrade()
        {
            try
            {
                var data = ProductGradeServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/productgrade/add")]
        public HttpResponseMessage Add(ProductGradeDTO product)
        {
            try
            {
                var data = ProductGradeServices.Add(product);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/productgrade/edit")]
        public HttpResponseMessage Edit(ProductGradeDTO product)
        {
            try
            {
                var data = ProductGradeServices.Edit(product);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [HttpPost]
        [Route("api/productgrade/delete")]
        public HttpResponseMessage Delete(ProductGradeDTO product)
        {
            try
            {
                var data = ProductGradeServices.Delete(product);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
