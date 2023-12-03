using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Portfolio.Data;
using Portfolio.Infrustructure.IRepository;
using Portfolio.Models;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactRepository _contactRepo;
        public HomeController(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PartialAbout()
        {
            return View();
        }

        /* [HttpGet]
        public IActionResult PartialContact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>PartialContact(Contact contact)
        {
            var contacts = await _contactRepo.GetAll();
            return View(contacts);
        }*/

        [HttpGet]
        public IActionResult PartialContact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PartialContact(Contact contact)
        {
            try 
            { 
            if (ModelState.IsValid)
            {
                _contactRepo.Add(contact);
                TempData["errorMessage"] = "Data Successfully Saved";
                return RedirectToAction(nameof(PartialContact));
            }
            
            else
            {
                TempData["errorMessage"] = "Model state is invalid";
                return View();
            }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }


        }

        

            

public IActionResult PartialProject()
        {
            return View();
        }


        public IActionResult PartialResume()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
