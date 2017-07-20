using Microsoft.AspNetCore.Mvc;

namespace Fiver.Security.Redirects.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => Content("Home");
        public IActionResult About() => Content("About");
        public IActionResult Exception() => Content("Exception");
        public IActionResult Error() => Content("Error");

        public IActionResult GoLocalRedirect(string url) => LocalRedirect(url);

        public IActionResult GoIsLocalUrl(string url)
        {
            if (Url.IsLocalUrl(url))
                return Redirect(url); 
            else
                return RedirectToAction("Error", "Home");
        }
    }
}
