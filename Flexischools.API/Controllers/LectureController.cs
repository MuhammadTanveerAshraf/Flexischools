using Flexischools.Data.Models.Request;
using Flexischools.Services.Services.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flexischools.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectureController : ControllerBase
    {
        private readonly ILectureService _service;

        public LectureController(ILectureService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _service.GetAllLectures();
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddLectureRequest request)
        {
            var response = await _service.AddLecture(request);
            return Ok(response);
        }
    }
}
