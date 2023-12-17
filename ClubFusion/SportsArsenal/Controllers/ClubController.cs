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
    public class ClubController : Controller
    {
        // GET: Club
        public ActionResult Index()
        {
            var apiUrl = AppSetting.baseUrl.ToString() + "/club/all";
            var data = ClubFusionClientGet.Get<List<Club>>(apiUrl);
            return View(data);
        }
    }
}