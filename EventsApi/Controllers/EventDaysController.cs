using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventsApi.Data;
using EventsApi.Models.Entities;
using AutoMapper;
using EventsApi.Models.DTO;

namespace EventsApi.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventDaysController : ControllerBase
    {
        private readonly IMapper mapper;
        private EventRepo eventDayRepo;

        public EventDaysController(EventsApiContext context,IMapper mapper)
        {
            eventDayRepo = new EventRepo(context);
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventDay>>> GetAllEvent(bool includeLectures = false)
        {
            var result = await eventDayRepo.GetAllAsync(includeLectures);
            var dto = mapper.Map<EventDayDto>(result);
            return Ok(dto);
        }


    }
}
