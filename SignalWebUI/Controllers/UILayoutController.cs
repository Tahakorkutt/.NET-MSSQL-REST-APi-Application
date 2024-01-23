using Microsoft.AspNetCore.Mvc;

namespace SignalWebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
