using Microsoft.AspNetCore.Mvc;

namespace MyWebsiteApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            // Contact information to be passed to the Contact view
            var contactInfo = new List<string>
            {
                "Phone: 555-123-4567",
                "Email: me@mywebsite.com",
                "Facebook: facebook.com/mywebsite"
            };

            ViewBag.ContactInfo = contactInfo;

            return View();
        }
    }
}
