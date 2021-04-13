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
        private EventRepo repo;

        public EventDaysController(EventsApiContext context, IMapper mapper)
        {
            repo = new EventRepo(context);
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventDayDto>>> GetAllEvent(bool includeLectures = false)
        {
            var result = await repo.GetAllAsync(includeLectures);
            var dto = mapper.Map<IEnumerable<EventDayDto>>(result);
            return Ok(dto);
        }

        [HttpGet]
        [Route("{name}")]
        public async Task<ActionResult<EventDayDto>> GetEvent(string name, bool includeLectures = false)
        {
            if (string.IsNullOrEmpty(name)) return BadRequest();

            var result = await repo.GetEventAsync(name, includeLectures);

            if (result is null) return NotFound();

            var dto = mapper.Map<EventDayDto>(result);

            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult<EventDayDto>> CreateEvent(EventDayDto dto)
        {
            if(await repo.GetEventAsync(dto.Name, false) != null)
            {
                ModelState.AddModelError("Name", "Name in use");
                return BadRequest(ModelState);
            }

            var eventday = mapper.Map<EventDay>(dto);
            await repo.AddAsync(eventday);

            if (await repo.SaveAsync())
            {
                var model = mapper.Map<EventDayDto>(eventday);
                return CreatedAtAction(nameof(GetEvent), new { name = model.Name }, model);
            }
            else
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
