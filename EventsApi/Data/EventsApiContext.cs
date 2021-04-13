using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventsApi.Models.Entities;

namespace EventsApi.Data
{
    public class EventsApiContext : DbContext
    {
        public DbSet<EventDay> EventDays { get; set; }
        public DbSet<Lecture> Lectures { get; set; }

        public EventsApiContext (DbContextOptions<EventsApiContext> options)
            : base(options)
        {
        }

    }
}
