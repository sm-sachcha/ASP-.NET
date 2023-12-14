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
    [EnableCors("*","*","*")]
    public class CustomerController : ApiController
    {
        [HttpGet]
        [Route("api/customer/all")]

        public HttpResponseMessage AllCustomer()
        {
            try
            {
                var data = CustomerServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/customer/{id}")]

        public HttpResponseMessage CustomerById(int id)
        {
            try
            {
                var data = CustomerServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/customer/add")]
        public HttpResponseMessage Add(CustomerDTO cstDTO)
        {
            try
            {
                var data = CustomerServices.Add(cstDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/customer/edit")]

        public HttpResponseMessage Edit(CustomerDTO customer)
        {
            try
            {
                var data = CustomerServices.Edit(customer);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
        [HttpPost]
        [Route("api/customer/delete")]

        public HttpResponseMessage Delete(CustomerDTO customer)
        {
            try
            {
                var data = CustomerServices.Delete(customer);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

    }
}
