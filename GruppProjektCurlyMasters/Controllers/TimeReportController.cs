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
    }
}
