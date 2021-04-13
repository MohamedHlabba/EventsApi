using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApi.Models.DTO
{
    public class CreateEventDto
    {
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public int Length { get; set; }

        public ICollection<LectureDto> Lectures { get; set; }
       // public int LectureId { get; set; }
        //public string LectureTitle { get; set; }
        //public int LectureLevel { get; set; }
        //public string SpeakerFirstName { get; set; }
        //public string SpeakerLastName { get; set; }
        //public string SpeakerCompany { get; set; }
        public string LocationAddress { get; set; }
        public string LocationCityTown { get; set; }
        public string LocationStateProvince { get; set; }
        public string LocationPostalCode { get; set; }
        public string LocationCountry { get; set; }
    }
}
