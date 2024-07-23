using Microsoft.AspNetCore.Mvc;

namespace CreateViewComponent.ViewComponents
{
    public class FirstViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(string Text) { 
        ViewBag.Text = Text;

        return View("Index");
        }
    }
}
