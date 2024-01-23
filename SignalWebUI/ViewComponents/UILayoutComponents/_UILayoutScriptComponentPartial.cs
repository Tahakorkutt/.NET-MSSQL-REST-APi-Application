using Microsoft.AspNetCore.Mvc;

namespace SignalWebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutScriptComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
