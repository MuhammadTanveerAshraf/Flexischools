using Flexischools.Data.Models.Request;
using Flexischools.Services.Services.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flexischools.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _service.GetAllStudents();
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddStudentRequest request)
        {
            var response = await _service.AddStudent();
            return Ok(response);
        }
    }
}
