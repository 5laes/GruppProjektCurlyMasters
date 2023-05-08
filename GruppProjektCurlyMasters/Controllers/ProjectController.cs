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
    }
}
