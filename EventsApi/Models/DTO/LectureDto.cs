using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApi.Models.DTO
{
    public class LectureDto
    {
        public string Title { get; set; }
        public int Level { get; set; }
        public int SpeakerId { get; set; }

    }
}
