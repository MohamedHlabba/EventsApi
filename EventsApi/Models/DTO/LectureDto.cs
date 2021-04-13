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
        public string SpeakerFirstName { get; set; }
        public string SpeakerLastName { get; set; }
        public string SpeakerCompany { get; set; }
        public string SpeakerCompanyUrl { get; set; }
        public string SpeakerBlogUrl { get; set; }
        public string SpeakerGitHub { get; set; }


    }
}
