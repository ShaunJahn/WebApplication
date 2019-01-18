using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesWebApplication.Models;
using CakesWebApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace CakesWebApplication.Controllers
{
    [Route("pie")]
    public class PieController : Controller
    {
        private IPieRepository _pieRepos;

        public PieController(IPieRepository pieRepository)
        {
            _pieRepos = pieRepository;
        }

        [Route("List/{category?}")]
        public IActionResult List(string category)
        {
            var result = new PieListViewModel();
            if (category == null)
            {
                result.Pies = _pieRepos.Pies;
                result.CurrentCategory = "all";
            }
            else
            {
                result.Pies = _pieRepos.PiesWithCategory(category);
                result.CurrentCategory = category;
            }


            return View(result);
        }
        [Route("Details/{Id}")]
        public IActionResult Details(int Id)
        {
            var returnPie =  _pieRepos.PieById(Id);
            return View(returnPie);
        }

    }
}