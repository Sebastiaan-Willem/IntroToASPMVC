using AutoMapper;
using IntroToASPMVC.Data.Weather;
using IntroToASPMVC.DTOs;
using IntroToASPMVC.Models;
using IntroToASPMVC.ViewModels;
using IntroToASPMVC.ViewModels.Contacts;
using IntroToASPMVC.ViewModels.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Movie, MovieDTO>()
                .ReverseMap();
            CreateMap<Movie, MovieDetailViewModel>()
                .ReverseMap();
            CreateMap<Movie, MovieCreateViewModel>()
                .ReverseMap();
            CreateMap<Movie, MovieEditViewModel>()
                .ReverseMap();
            CreateMap<Movie, MovieDeleteViewModel>()
                .ReverseMap();

            CreateMap<Cursist, CursistViewModel>()
                .ForMember(x => x.Gender, opt => opt.MapFrom(z => z.Gender)) //optional
                .ReverseMap();


            CreateMap<Contact, ContactDTO>()
                .ReverseMap();
            CreateMap<Contact, ContactDetailViewModel>()
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Address.City))
                .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Address.Street))
                .ForMember(dest => dest.HouseNumber, opt => opt.MapFrom(src => src.Address.HouseNumber))
                .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.Address.PostalCode))
                .ForMember(dest => dest.Unit, opt => opt.MapFrom(src => src.Address.Unit))
                .ReverseMap();
            CreateMap<Contact, ContactEditViewModel>()
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Address.City))
                .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Address.Street))
                .ForMember(dest => dest.HouseNumber, opt => opt.MapFrom(src => src.Address.HouseNumber))
                .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.Address.PostalCode))
                .ForMember(dest => dest.Unit, opt => opt.MapFrom(src => src.Address.Unit))
                .ForMember(dest => dest.AddressId, opt => opt.MapFrom(src => src.Address.Id))               
                .ReverseMap();
            CreateMap<Contact, ContactCreateViewModel>()
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Address.City))
                .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Address.Street))
                .ForMember(dest => dest.HouseNumber, opt => opt.MapFrom(src => src.Address.HouseNumber))
                .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.Address.PostalCode))
                .ForMember(dest => dest.Unit, opt => opt.MapFrom(src => src.Address.Unit))
                .ReverseMap();
            CreateMap<Contact, ContactDeleteViewModel>()
                .ReverseMap();

            CreateMap<Address, ContactDetailViewModel>()
                .ReverseMap();
            CreateMap<Address, ContactEditViewModel>()
                .ReverseMap();
            CreateMap<Address, ContactCreateViewModel>()
                .ReverseMap();
            CreateMap<Address, ContactDeleteViewModel>()
                .ReverseMap();


            //WEATHER

            CreateMap<WeatherEntity, Models.Weather>()
                .ForMember(dst => dst.Location, opt => opt.MapFrom(src => src.name))
                .ForMember(dst => dst.Temperature, opt => opt.MapFrom(src => src.main.temp))
                .ForMember(dst => dst.MaxTemperature, opt => opt.MapFrom(src => src.main.temp_max))
                .ForMember(dst => dst.MinTemperature, opt => opt.MapFrom(src => src.main.temp_min))
                .ForMember(dst => dst.WeatherType, opt => opt.MapFrom(src => src.weather[0].description));


        }
    }
}
