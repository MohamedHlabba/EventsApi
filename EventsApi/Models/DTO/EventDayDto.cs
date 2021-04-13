﻿using EventsApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApi.Models.DTO
{
    public class EventDayDto
    {
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        public DateTime EventDate { get; set; }

        [Range(0,200)]
        public int Length { get; set; }

        public ICollection<LectureDto> Lectures { get; set; }

        public string LocationAddress { get; set; }
        public string LocationCityTown { get; set; }
        public string LocationStateProvince { get; set; }
        public string LocationPostalCode { get; set; }
        public string LocationCountry { get; set; }
    }
}
