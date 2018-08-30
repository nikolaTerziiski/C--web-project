using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarParadise.Models.CarInfo;
using CarParadise.Web.Areas.Admin.Models.BindingModels;
using CarParadise.Web.Areas.Admin.Models.ViewModels;
using Gameplace.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace CarParadise.Web.Areas.Admin.Controllers
{
    public class CarsController : AdminController
    {
        public CarParadiseContext Context { get; set; }
        public IMapper Mapper { get; set; }

        public CarsController(CarParadiseContext context, IMapper mapper)
        {
            this.Context = context;
            this.Mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(CreateCarBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }
            if (!this.Context.CarTypes.Any(e => e.Type == model.TypeOfCar))
            {
                this.ViewData["InvalidCarType"] = "Invalid car type!!!";
                return this.View();
            }

            var carModel = this.Context.CarTypes.FirstOrDefault(e => e.Type == model.TypeOfCar);

            var car = this.Mapper.Map<Car>(model);

            car.CarTypeId = carModel.Id;

            car.ProduceDate = DateTime.Now;

            using (this.Context)
            {
                this.Context.Cars.Add(car);
                this.Context.SaveChanges();
            }

            return this.RedirectToAction("Details", new { id = car.Id });
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