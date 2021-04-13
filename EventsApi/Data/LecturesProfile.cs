using AutoMapper;
using EventsApi.Models.DTO;
using EventsApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApi.Data
{
    public class LecturesProfile : Profile
    {
        public LecturesProfile()
        {
            //CreateMap<Lecture, LectureDto>().ReverseMap();
            CreateMap<Lecture, LectureDto>().ReverseMap();
        }
    }
}
