using CreateViewComponent.Models.ViewComponentModels;
using Microsoft.AspNetCore.Mvc;

namespace CreateViewComponent.ViewComponents
{
    public class ProductViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(ProductModel product) {
            
            return View("Index", product);
        }
    }
}
