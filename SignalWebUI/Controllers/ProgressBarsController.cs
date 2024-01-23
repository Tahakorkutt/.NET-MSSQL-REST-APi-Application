using Microsoft.AspNetCore.Mvc;

namespace SignalWebUI.Controllers
{
    public class ProgressBarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
