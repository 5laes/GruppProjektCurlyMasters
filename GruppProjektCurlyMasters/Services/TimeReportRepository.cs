using DbLibrary;
using GruppProjektCurlyMasters.Models;

namespace GruppProjektCurlyMasters.Services
{
    public class TimeReportRepository : IAppRepository<TimeReport>
    {
        private Context context;
        public TimeReportRepository(Context Dbcontext)
        {
            context = Dbcontext;
        }
        public Task<TimeReport> Add(TimeReport newEntity)
        {
            throw new NotImplementedException();
        }

        public Task<TimeReport> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TimeReport>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TimeReport> GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TimeReport> Update(TimeReport newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
