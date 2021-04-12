using AutoMapper;
using EventsApi.Models.DTO;
using EventsApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApi.Data
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<EventDay, EventDayDto>().ReverseMap();
            CreateMap<Lecture, LectureDto>().ReverseMap();
        }
    }
}
