using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CakesWebApplication.ViewModels;
using CakesWebApplication.Models;

namespace CakesWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private IPieRepository _PieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _PieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var PiesOfTheWeek = new HomeViewModel
            {
                PiesOfTheWeek = _PieRepository.PiesOfTheWeek
            };
            return View(PiesOfTheWeek);
        }
    }
}