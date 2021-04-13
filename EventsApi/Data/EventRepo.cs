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

      

        public async Task<EventDay> GetEventAsync(string name, bool includeLectures)
        {
            //ToDo validate name

            var query = db.EventDays
                            .Include(e => e.Location)
                            .AsQueryable();

            if (includeLectures)
            {
                query = query.Include(e => e.Lectures);
            }

            return await query.FirstOrDefaultAsync(e => e.Name == name);
        }

        public async Task AddAsync<T>(T added)
        {
            await db.AddAsync(added);
        }

        public async Task<bool> SaveAsync()
        {
            return (await db.SaveChangesAsync()) >= 0;

        }
        //public async Task  Delete(string name)
        //{
        //   var item= db.EventDays.Where(e=>e.Name==name).FirstOrDefault();
        //  await  db.Remove(item);
        //}
    }
}
