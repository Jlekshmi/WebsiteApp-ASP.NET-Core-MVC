using Microsoft.AspNetCore.Mvc;

namespace MyWebsiteApp.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        public IActionResult Index(string id)
        {
            if (id == "Page1")
            {
                return View("Page1");
            }
            else if (id == "Page2")
            {
                return View("Page2");
            }
            else if (id == "Page3")
            {
                return View("Page3");
            }
            return View("Page1"); // Default to Page1 if no id is provided
        }
    }
}
