using Microsoft.AspNetCore.Mvc;
using Mot.Models.Pages;
using EPiServer.Web.Mvc;

namespace Mot.Controllers.Pages
{
    public class HomepageController : PageController<Homepage>
    {
        public IActionResult Index(Homepage currentContent)
        {
            return View(currentContent);
        }
    }
}
