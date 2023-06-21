using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeApiController : ControllerBase
    {
        private readonly IEmployeeData _data;

        public EmployeeApiController(IEmployeeData data)
        {
            _data = data;
        }

        // GET: api/EmployeeApi/AllEmployee
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
           
            try
            {
              //  await Console.Out.WriteLineAsync("Upper portion hitted");
                var employee = await _data.GetAllEmployee();
               // await Console.Out.WriteLineAsync("lopwer portion hitted");
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // GET: api/EmployeeApi/Employee/{id}
        [HttpGet("{id}")]
        public async Task <IActionResult> GetEmployee(int id)
        {
            try
            {
                var result = await _data.GetEmployee(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // POST: api/EmployeeApi/StoreEmployee
        [HttpPost]
        public async Task <IActionResult> InsertEmployee([FromBody] EmployeeModel task)
        {
            try
            {
                await _data.InsertEmployee(task);
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // PUT: api/EmployeeApi/UpdateEmployee
        [HttpPut]
        public async Task <IActionResult> UpdateEmployee([FromBody] EmployeeModel task)
        {
            try
            {
               await _data.UpdateEmployee(task);
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // DELETE: api/EmployeeApi/DeleteEmployee/{id}
        [HttpDelete]
        public async Task <IActionResult> DeleteEmployee(int id)
        {
            try
            {
                await _data.DeleteEmployee(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
