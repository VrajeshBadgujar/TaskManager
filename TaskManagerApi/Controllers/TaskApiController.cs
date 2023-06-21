using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskApiController : ControllerBase
    {
        private readonly ITaskData _data;

        public TaskApiController(ITaskData data)
        {
            _data = data;
        }

        // GET: api/EmployeeApi/AllEmployee
        [HttpGet]
        public async Task<IActionResult> GetAllTask()
        {

            try
            {
                //  await Console.Out.WriteLineAsync("Upper portion hitted");
                var task = await _data.GetAllTasks();
                // await Console.Out.WriteLineAsync("lopwer portion hitted");
                return Ok(task);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // GET: api/EmployeeApi/Employee/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTask(int id)
        {
            try
            {
                var result = await _data.GetTask(id);
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
        public async Task<IActionResult> InsertTask([FromBody] TaskModel task)
        {
            try
            {
                await _data.InsertTask(task);
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // PUT: api/EmployeeApi/UpdateEmployee
        [HttpPut]
        public async Task<IActionResult> UpdateTask([FromBody] TaskModel task)
        {
            try
            {
                await _data.UpdateTask(task);
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // DELETE: api/EmployeeApi/DeleteEmployee/{id}
        [HttpDelete]
        public async Task<IActionResult> DeleteTask(int id)
        {
            try
            {
                await _data.DeleteTask(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
