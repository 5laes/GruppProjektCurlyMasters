using DbLibrary;
using GruppProjektCurlyMasters.Services;
using Microsoft.AspNetCore.Mvc;

namespace GruppProjektCurlyMasters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeReportController : ControllerBase
    {
        private IAppRepository<TimeReport> repository;
        public TimeReportController(IAppRepository<TimeReport> appRepository)
        {
            repository = appRepository;
        }

        [HttpGet("GetTimeReportFromEmployee")]
        public async Task<IActionResult> GetTimeReportFromEmployee(int id)
        {
            try
            {
                return Ok(await repository.GetAllFromSingle(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "ERROR: Failed to retrieve data from database!");
            }
        }


        [HttpGet("GetSingleTimeReport")]
        public async Task<ActionResult<TimeReport>> GetSingleTimeReport(int id)
        {
            try
            {
                var result = await repository.GetSingle(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "ERROR: Failed to retrieve data from database!");
            }
        }

        [HttpGet("GetHoursWorkedFromWeek")]
        public async Task<ActionResult<TimeReport>> GetHoursWorkedFromWeek(DateTime start, DateTime end, int id)
        {
            try
            {
                return Ok(await repository.GetHoursWorkFromWeek(start, end, id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "ERROR: Failed to retrieve data from database!");
            }
        }

        [HttpPost("AddTimeReport")]
        public async Task<ActionResult<TimeReport>> AddTimeReport(TimeReport timeReport)
        {
            try
            {
                if (timeReport == null)
                {
                    return BadRequest();
                }
                var CreateEmployee = await repository.Add(timeReport);
                return CreatedAtAction(nameof(GetSingleTimeReport), new { id = CreateEmployee.Id }, CreateEmployee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "ERROR: Failed to add data to database!");
            }
        }

        [HttpDelete("DeleteTimeReport")]
        public async Task<ActionResult<TimeReport>> DeleteTimeReport(int id)
        {
            try
            {
                var result = await repository.GetSingle(id);
                if (result == null)
                {
                    return NotFound($"Project with id {id} not found");
                }
                return await repository.Delete(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "ERROR: Failed to delete data from database!");
            }
        }

        [HttpPut("UpdateTimeReport")]
        public async Task<ActionResult<TimeReport>> UpdateTimeReport(int id, TimeReport timeReport)
        {
            try
            {
                if (id != timeReport.Id)
                {
                    return BadRequest("Id do not match");
                }

                var result = await repository.GetSingle(id);
                if (result == null)
                {
                    return NotFound($"Project with id {id} not found");
                }
                return await repository.Update(timeReport);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "ERROR: Failed to update data to database!");
            }
        }
    }
}
