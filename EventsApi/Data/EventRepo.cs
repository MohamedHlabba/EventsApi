using EventsApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApi.Data
{
    public class EventRepo
    {
        private readonly EventsApiContext db;

        public EventRepo(EventsApiContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<EventDay>> GetAllAsync(bool includeLectures)
        {
            return includeLectures ? await db.EventDays
                                             .Include(e => e.Location)
                                             .Include(e => e.Lectures)
                                             .ThenInclude(e => e.Speaker)
                                             .ToListAsync() :
                                    await db.EventDays
                                             .Include(e => e.Location)
                                             .ToListAsync();
        }
    }
}
