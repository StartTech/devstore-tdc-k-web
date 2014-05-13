using Microsoft.AspNet.Mvc;

namespace DevStore.Tdc.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}