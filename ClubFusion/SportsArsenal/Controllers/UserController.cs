using SportsArsenal.Clients;
using SportsArsenal.Models;
using SportsArsenal.Utils.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsArsenal.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var apiUrl = AppSetting.baseUrl.ToString() + "/user/all";
            var data = ClubFusionClientGet.Get<List<User>>(apiUrl);
            return View(data);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(User user)
        {
            var data = ClubFusionClientPost.Post<User>("user/add", user);
            return RedirectToAction("Index");
        }
    }
}