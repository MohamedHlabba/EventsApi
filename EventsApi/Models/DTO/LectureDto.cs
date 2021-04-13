using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApi.Models.DTO
{
    public class LectureDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Level { get; set; }
        public int SpeakerId { get; set; }
        public int EventDayId { get; set; }
        public string EventDayName { get; set; }



    }
}
