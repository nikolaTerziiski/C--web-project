﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarParadise.Web.Areas.Admin.Controllers
{
    public class HomeController : UserController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}