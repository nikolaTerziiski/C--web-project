using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gameplace.Web.Models;
using Gameplace.Web.Data;
using AutoMapper;
using Gameplace.MyModels.ViewModels;

namespace Gameplace.Web.Controllers
{
    public class HomeController : Controller
    {
        private IMapper Mapper;

        public CarParadiseContext Context { get; }

        protected HomeController( CarParadiseContext context, IMapper mapper)
        {
            this.Mapper = mapper;
            this.Context = context;
        }

        public IActionResult Index()
        {
            var contextCars = this.Context.Cars;
            var modelsForDisplay = this.Mapper.Map<UserCarConsiceViewModel>(contextCars);

            return View(modelsForDisplay);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
