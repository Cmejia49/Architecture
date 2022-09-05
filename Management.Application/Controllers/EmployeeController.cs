using Management.Application.Dtos.EmployeeDtos;
using Management.Application.Services.Employees;
using Microsoft.AspNetCore.Mvc;

namespace Management.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _service;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger
            , EmployeeService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetEmployeeRequest request)
        {
            var users = await _service.SearchAsync(request);
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddEmployeeRequest request)
        {
            var users = await _service.AddNewAsync(request);
            return Ok(users);
        }

    }
}
