using Flexischools.Data.Models.Request;
using Flexischools.Services.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace Flexischools.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _service;

        public SubjectController(ISubjectService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _service.GetAllSubjects();
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddSubjectRequest request)
        {
            var response = await _service.AddSubject(request.SubjectName);
            return Ok(response);
        }
    }
}
