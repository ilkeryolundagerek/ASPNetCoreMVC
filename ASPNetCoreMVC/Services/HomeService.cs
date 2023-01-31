using ASPNetCoreMVC.Controllers;
using ASPNetCoreMVC.Models;
using Microsoft.Extensions.Logging;

namespace ASPNetCoreMVC.Services
{
    public interface IHomeService
    {
        ContactViewModel GetContactPage();
    }

    public class HomeService : IHomeService
    {
        private readonly ILogger<HomeController> _logger;
        public HomeService(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ContactViewModel GetContactPage()
        {
            ContactViewModel model = new ContactViewModel();
            model.Title = "Contact Us!!!";
            model.SubTitle = "Lorem ipsum dolor sit amed.";
            model.Email = "a@a.net";
            return model;
        }
    }
}
