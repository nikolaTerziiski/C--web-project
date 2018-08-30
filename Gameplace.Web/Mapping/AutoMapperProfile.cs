using AutoMapper;
using CarParadise.Models.CarInfo;
using CarParadise.Web.Areas.Admin.Models.BindingModels;
using CarParadise.Web.Areas.Admin.Models.ViewModels;
using Gameplace.MyModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftUniClone.Web.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<CreateCarBindingModel, Car>();
            this.CreateMap<Car, CarConsiceViewModel>();
            this.CreateMap<Car, UserCarConsiceViewModel>();
        }
    }
}
