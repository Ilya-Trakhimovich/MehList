using AutoMapper;
using DAL.EF.Entities;
using MehList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MehList.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddMechanismVM, Mechanism>()
                .ForMember(dest =>
                dest.FuelConsumption,
                src => src.MapFrom(src => Double.Parse(src.FuelСonsumption)));
        }
    }
}
