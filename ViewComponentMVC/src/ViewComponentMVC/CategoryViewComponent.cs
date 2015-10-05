using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ViewComponentMVC.Models;

namespace ViewComponentMVC
{
    [ViewComponent(Name = "ProductCategoriesComponent")]
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           var categories = new List<Category>()
           {
               new Category {CategoryId = 1, Name = "Clothes",Description = "Men and women's clothes"},
               new Category {CategoryId = 2, Name = "Elentronics", Description = "Eletronics"}
           };
            return View(categories);
        }

    }
}