using AutoMapper;
using EventsApi.Data;
using EventsApi.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApi.Controllers
{
    [ApiController]
    [Route("api/events/{name}/lectures")]
    public class LecturesController : ControllerBase
    {
        private readonly EventsApiContext db;
        private readonly IMapper mapper;
        private readonly EventRepo repo;

        public LecturesController(EventsApiContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
            repo = new EventRepo(db);
        }

        [HttpGet]
        public async Task<ActionResult<LectureDto>> GetAll(string name, bool includeSpeakers = false)
        {
            var lectures = await repo.GetAllLecturesAsync(name, includeSpeakers);
            var model = mapper.Map<LectureDto[]>(lectures);
            return Ok(model);
        }

       // [HttpGet("{id:int}")]

        public async Task<ActionResult<LectureDto>> AddLecture(string name, LectureDto dto)
        {
            return Ok();
        }


    }
}
