﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApi.Models.Entities
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Level { get; set; }

        public int EventDayId { get; set; }
        public int SpeakerId { get; set; }

        public EventDay EventDay { get; set; }
        public Speaker Speaker { get; set; }
    }
}
