using ASPNetCoreMVC.Models;
using ASPNetCoreMVC.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //Controller tarafında yapılması beklenen işlemler için sürekli nesne üretimi olmaması ve daha düzenli bir görünüm için dependency injection kullanılarak servis sınıfları oluşturulur.
        private readonly IHomeService _service;
        public HomeController(
            ILogger<HomeController> logger, 
            IHomeService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string Hello(string id)
        {
            return id+", Hello world!!!";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contact()
        {
            //ContactViewModel model = new ContactViewModel();
            //model.Title = "Contact Us!!!";
            //model.SubTitle = "Lorem ipsum dolor sit amed.";
            //model.Email = "a@a.net";
            return View(_service.GetContactPage());
        }

        [HttpPost]
        public IActionResult ContactResponse(ContactFormViewModel collection)
        {
            
            return View(collection);
        }

        public IActionResult Signup()
        {
            return View();
        }
    }
}
