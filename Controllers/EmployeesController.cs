using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi1.Data;
using webapi1.Models.Entities;

namespace webapi1.Controllers
{
    //localhost:xxx/api/employees
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(dbContext.Employees.ToList());
        }
    }
}
