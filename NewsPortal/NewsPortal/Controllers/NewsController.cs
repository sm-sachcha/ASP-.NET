using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.Data;
using NewsPortal.Models;

namespace NewsPortal.Controllers
{
    public class NewsController : ApiController
    {
        [HttpGet]
        [Route("api/Catagory/all")]
        public HttpResponseMessage showAllCat()
        {
            var DBcontext = new NewsPortalEntities();
            var AllCatagory = (from table in DBcontext.Catagories select new { table.id, table.Name }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, AllCatagory);
        }

        [HttpPost]
        [Route("api/Catagory/Create")]
        public HttpResponseMessage insertCat(Catagory cat)
        {
            var DBcontext = new NewsPortalEntities();
            try
            {
                DBcontext.Catagories.Add(cat);
                DBcontext.SaveChanges();
                var notification = new
                {
                    Notification = "Your Catagory Inserted Successfully"
                };
                return Request.CreateResponse(HttpStatusCode.OK, notification);
            }
            catch (Exception exp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, exp.Message);
            }
        }

        [HttpPost]
        [Route("api/Catagory/Update")]
        public HttpResponseMessage updateCat(catagoryDTO cat)
        {
            var DBcontext = new NewsPortalEntities();
            var CatValue = DBcontext.Catagories.Find(cat.id);
            CatValue.Name = cat.Name;
            try
            {
                DBcontext.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Notification = "Your Catagory Updated Successfully" });
            }
            catch (Exception exp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, exp.Message);
            }
        }

        [HttpDelete]
        [Route("api/Catagory/Delete")]
        public HttpResponseMessage deleteCat(catagoryDTO cat)
        {
            var DBcontext = new NewsPortalEntities();
            var CatValue = DBcontext.Catagories.Find(cat.id);
            DBcontext.Catagories.Remove(CatValue);
            try
            {
                DBcontext.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Notification = "Catagory Deleted Successfully" });
            }
            catch (Exception exp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, exp.Message);
            }
        }

        [HttpGet]
        [Route("api/News/all")]
        public HttpResponseMessage showAllnews()
        {
            var DBcontext = new NewsPortalEntities();
            var AllNews = (from table in DBcontext.News select new { table.id, table.Title, table.Description, table.Date }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, AllNews);
        }

        [HttpPost]
        [Route("api/News/Create")]
        public HttpResponseMessage insertNews(News newsDT)
        {
            var DBcontext = new NewsPortalEntities();
            try
            {
                DBcontext.News.Add(newsDT);
                DBcontext.SaveChanges();
                var notification = new
                {
                    Notification = "Your News Inserted Successfully"
                };
                return Request.CreateResponse(HttpStatusCode.OK, notification);
            }
            catch (Exception exp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, exp.Message);
            }
        }

        [HttpPost]
        [Route("api/News/Update")]
        public HttpResponseMessage updateNews(NewsDTO DTnews)
        {
            var DBcontext = new NewsPortalEntities();
            var NewsValue = DBcontext.News.Find(DTnews.id);
            NewsValue.Title = DTnews.Title;
            try
            {
                DBcontext.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Notification = "Your News Updated Successfully" });
            }
            catch (Exception exp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, exp.Message);
            }
        }

        [HttpDelete]
        [Route("api/News/Delete")]
        public HttpResponseMessage deleteNews(NewsDTO DTnews)
        {
            var DBcontext = new NewsPortalEntities();
            var NewsValue = DBcontext.News.Find(DTnews.id);
            DBcontext.News.Remove(NewsValue);
            try
            {
                DBcontext.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Notification = "News Deleted Successfully" });
            }
            catch (Exception exp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, exp.Message);
            }
        }

        [HttpGet]
        [Route("api/News/{catName}")]
        public HttpResponseMessage showNewsCatwise(string catName)
        {
            var DBcontext = new NewsPortalEntities();
            var SearchValue = (from table in DBcontext.Catagories where table.Name.Contains(catName) select table.id).ToList();
            var NewsValue = (from table in DBcontext.News where SearchValue.Contains(table.cid) select new { table.Title, table.Date }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, NewsValue);
        }

        [HttpGet]
        [Route("api/Catagory/{catname}/{Date}")]
        public HttpResponseMessage showNewsCatDateWise (string catName, DateTime date)
        {
            var DBcontext = new NewsPortalEntities();
            var SearchValue = (from table in DBcontext.Catagories where table.Name.Contains(catName) select table.id).ToList();
            var NewsValue = (from table in DBcontext.News where SearchValue.Contains(table.cid) && table.Date == date select new { table.Title, table.Date }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, NewsValue);
        }
    }
}
