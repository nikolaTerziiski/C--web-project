using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarParadise.Web.Areas.Admin.Models.BindingModels;
using Microsoft.AspNetCore.Mvc;

namespace CarParadise.Web.Areas.Admin.Controllers
{
    public class TopicsController : AdminController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(CreateTopicBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            return null;
        }
    }
}