using Microsoft.AspNetCore.Mvc;

namespace SignalWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
