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
        private readonly LectureRepo repo;

        public LecturesController(EventsApiContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
            repo = new LectureRepo(db);
        }

        //[HttpGet]
        //public async Task<ActionResult<LectureDto>> GetAll(string name, bool includeSpeakers = false)
        //{
        //    var lectures = await repo.GetAllLecturesAsync(name, includeSpeakers);
        //    var model = mapper.Map<LectureDto[]>(lectures);
        //    return Ok(model);
        //}

        [HttpGet]
        public async Task<ActionResult<LectureDto>> GetAllLecturesForEvent(string name, bool includeSpeakers = false)
        {
            if (!repo.EventExists(name))
            {
                return StatusCode(404);
            }
            var lectures = await repo.GetAllLecturesAsync(name, includeSpeakers);
            return Ok(mapper.Map<IEnumerable<LectureDto>>(lectures));
        }

        [HttpGet("{id:int}")]
        public ActionResult<LectureDto> GetLectureForEvent(string name, int id)
        {
            if (!repo.EventExists(name))
            {
                return StatusCode(404);
            }
            var lectureForEventFromRepo = repo.GetLecture(name,id);
            if (lectureForEventFromRepo is null)
            {

                return StatusCode(404);
            }
            return Ok(mapper.Map<LectureDto>(lectureForEventFromRepo));
        }


    }
}
