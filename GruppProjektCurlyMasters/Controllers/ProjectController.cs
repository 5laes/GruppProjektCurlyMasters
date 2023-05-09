using DbLibrary;
using GruppProjektCurlyMasters.Services;
using Microsoft.AspNetCore.Mvc;

namespace GruppProjektCurlyMasters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IAppRepository<Project> repository;
        public ProjectController(IAppRepository<Project> appRepository)
        {
            repository = appRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Project>> GetSingleProject(int id)
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
        public async Task<ActionResult<Project>> AddProject(Project project)
        {
            try
            {
                if (project == null)
                {
                    return BadRequest();
                }
                var CreateProject = await repository.Add(project);
                return CreatedAtAction(nameof(GetSingleProject), new { id = CreateProject.Id }, CreateProject);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "ERROR: Failed to add data to database!");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Project>> DeleteProject(int id)
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
        public async Task<ActionResult<Project>> UpdateProject(int id, Project project)
        {
            try
            {
                if (id != project.Id)
                {
                    return BadRequest("Id do not match");
                }

                var result = await repository.GetSingle(id);
                if (result == null)
                {
                    return NotFound($"Project with id {id} not found");
                }
                return await repository.Update(project);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "ERROR: Failed to update data to database!");
            }
        }
    }
}
