using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventsApi.Data;
using EventsApi.Models.Entities;

namespace EventsApi.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventDaysController : ControllerBase
    {
        private readonly EventsApiContext _context;

        public EventDaysController(EventsApiContext context)
        {
            _context = context;
        }

        // GET: api/EventDays
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<EventDay>>> GetEventDay()
        //{
           
        //}


    }
}
