﻿using DbLibrary;
using GruppProjektCurlyMasters.Services;
using Microsoft.AspNetCore.Mvc;

namespace GruppProjektCurlyMasters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IAppRepository<Employee> repository;
        public EmployeeController(IAppRepository<Employee> appRepository)
        {
            repository = appRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                return Ok(await repository.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "ERROR: Failed to retrieve data from database!");
            }
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetAllFromProject(int id)
        //{
        //    try
        //    {
        //        return Ok(await repository.GetAllFromSingle(id));
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, "ERROR: Failed to retrieve data from database!");
        //    }
        //}

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetSingleProject(int id)
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

        [HttpPost]
        public async Task<ActionResult<Employee>> AddProject(Employee employee)
        {
            try
            {
                if (employee == null)
                {
                    return BadRequest();
                }
                var CreateEmployee = await repository.Add(employee);
                return CreatedAtAction(nameof(GetSingleProject), new { id = CreateEmployee.Id }, CreateEmployee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "ERROR: Failed to add data to database!");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> DeleteProject(int id)
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

        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> UpdateProject(int id, Employee employee)
        {
            try
            {
                if (id != employee.Id)
                {
                    return BadRequest("Id do not match");
                }

                var result = await repository.GetSingle(id);
                if (result == null)
                {
                    return NotFound($"Project with id {id} not found");
                }
                return await repository.Update(employee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "ERROR: Failed to update data to database!");
            }
        }
    }
}
