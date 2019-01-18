using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CakesWebApplication.Models;

namespace CakesWebApplication.Components
{
    public class CategoryMenu : ViewComponent
    {
        private ICategoryRepository _CatagoryRepos;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _CatagoryRepos = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var cats = _CatagoryRepos.Categories;
            return View(cats);
        }
    }
}
