using DbLibrary;
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
    }
}
