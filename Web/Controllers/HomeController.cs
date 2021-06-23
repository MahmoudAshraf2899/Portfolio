using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PortfolioItem> _PortfolioItem;


        public HomeController(IUnitOfWork<Owner>Owner,
            IUnitOfWork<PortfolioItem>PortfolioItem )
        {
            _owner = Owner;
            _PortfolioItem = PortfolioItem;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Owner = _owner.Entity.GetAll().First(),
                PortfolioItems = _PortfolioItem.Entity.GetAll().ToList(),
            };
            return View(homeViewModel);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
