using AutoMapper;
using HotelListing.Models;
using HotelListing.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.Shared.Configuration
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, AddCountryDTO>().ReverseMap();
            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Hotel, AddHotelDTO>().ReverseMap();
            CreateMap<ApiUser, UserDTO>().ReverseMap();
        }
    }
}
