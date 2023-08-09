﻿using AutoMapper;
using HotelListingM.Data;
using HotelListingM.Models.Country;
using HotelListingM.Models.Hotel;

namespace HotelListingM.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Country,CreateCountryDto>().ReverseMap();
            CreateMap<Country,GetCountryDto>().ReverseMap();
            CreateMap<Country,CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();


            CreateMap<Hotel,HotelDto>().ReverseMap();
           
        }
    }
}
