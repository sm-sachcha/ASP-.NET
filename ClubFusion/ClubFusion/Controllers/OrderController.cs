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
    public class OrderController : ApiController
    {
        [HttpGet]
        [Route("api/order/all")]
        public HttpResponseMessage AllOrder()
        {
            try
            {
                var data = OrderServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/order/{id}")]
        public HttpResponseMessage OrderById(int id)
        {
            try
            {
                var data = OrderServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/order/add")]
        public HttpResponseMessage Add(OrderDTO order)
        {
            try
            {
                var data = OrderServices.Add(order);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/order/edit")]
        public HttpResponseMessage Edit(OrderDTO order)
        {
            try
            {
                var data = OrderServices.Edit(order);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/order/delete")]
        public HttpResponseMessage Delete (OrderDTO order)
        {
            try
            {
                var data = OrderServices.Delete(order);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
