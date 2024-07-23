using CreateViewComponent.Models.ViewComponentModels;
using Microsoft.AspNetCore.Mvc;

namespace CreateViewComponent.ViewComponents
{
    public class BestSellingViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(string Title) { 
        List<ProductModel> products = new List<ProductModel>() { 
        new ProductModel{Id=1,Name="Iphone 1",Description="Description 1",Price=1000 },
        new ProductModel{Id=1,Name="Iphone 2",Description="Description 2",Price=2000 },
        new ProductModel{Id=1,Name="Iphone 3",Description="Description 3",Price=3000 },
        new ProductModel{Id=1,Name="Iphone 4",Description="Description 4",Price=4000 },
        };
           ViewBag.Title=Title;
        return View("Index", products);
        }
    }
}
