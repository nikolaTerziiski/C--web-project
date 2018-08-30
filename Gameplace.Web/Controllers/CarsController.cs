using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarParadise.Models.UserAndTopics;
using CarParadise.Web.Areas.Admin.Models.ViewModels;
using Gameplace.MyModels.ViewModels;
using Gameplace.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarParadise.Web.Controllers
{
    public class CarsController : BaseUserController
    {
        private IMapper Mapper;

        public CarParadiseContext Context { get; }

        protected CarsController(UserManager<User> userManager, CarParadiseContext context, IMapper mapper) : base(userManager)
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

        [HttpGet]
        public IActionResult Details(int id)
        {
            var carFromDb = this.Context.Cars.Find(id);
            if (carFromDb == null)
            {
                return NotFound();
            }
            var carConsiceViewModel = new CarConsiceViewModel();
            var carToDisplay = this.Mapper.Map<CarConsiceViewModel>(carFromDb);
            var nameOfCarType = this.Context.CarTypes.FirstOrDefault(e => e.Id == carFromDb.CarTypeId);
            carToDisplay.TypeOfCar = nameOfCarType.Type;

            return this.View(carToDisplay);
        }
    }
}