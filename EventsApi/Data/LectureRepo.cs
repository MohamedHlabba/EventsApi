using EventsApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApi.Data
{
    public class LectureRepo
    {
        private readonly EventsApiContext db;
        public LectureRepo(EventsApiContext db)
        {
            this.db = db;
        }
        public async Task<Lecture[]> GetAllLecturesAsync(string name, bool includeSpeakers)
        {
            var query = db.Lectures.AsQueryable();

            query = includeSpeakers ? query.Include(l => l.Speaker) : query;

            query = query.Where(l => l.EventDay.Name == name.ToUpper());

            return await query.ToArrayAsync();
        }

        public bool EventExists(string EventDayName)
        {
            return  db.EventDays.Any(e => e.Name == EventDayName);

        }

        public Lecture GetLecture(string name , int id)
        {
            return db.Lectures.Where(e => e.EventDay.Name == name && e.Id == id).FirstOrDefault();

        }
    }
}
