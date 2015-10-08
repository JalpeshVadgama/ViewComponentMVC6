using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ViewComponentMVC.Models;

namespace ViewComponentMVC
{
    [ViewComponent(Name = "ProductCategoriesComponent")]
    public class CategoryViewComponent : ViewComponent
    {
        private readonly List<Category> _categories;
        private CategoryViewComponent()
        {
            _categories = new List<Category>()
           {
               new Category {CategoryId = 1, Name = "Clothes",Description = "Men and women's clothes"},
               new Category {CategoryId = 2, Name = "Elentronics", Description = "Eletronics"}
           };
        }
        public IViewComponentResult Invoke()
        {
          
            return View(_categories);
        }

        public IViewComponentResult Invoke(int categoryId)
        {
            var category = _categories.FindAll(c => c.CategoryId == categoryId).ToList();
           return View(category);
        }
    }
}