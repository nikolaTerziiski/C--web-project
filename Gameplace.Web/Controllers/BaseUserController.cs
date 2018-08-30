using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarParadise.Models.UserAndTopics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarParadise.Web.Controllers
{
    [Authorize]
    public class BaseUserController : Controller
    {
        protected readonly UserManager<User> userManager;

        protected BaseUserController(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
    }
}