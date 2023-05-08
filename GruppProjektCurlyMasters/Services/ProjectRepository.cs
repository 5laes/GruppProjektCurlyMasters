using DbLibrary;
using GruppProjektCurlyMasters.Models;

namespace GruppProjektCurlyMasters.Services
{
    public class ProjectRepository : IAppRepository<Project>
    {
        private Context context;
        public ProjectRepository(Context Dbcontext)
        {
            context = Dbcontext;
        }
        public Task<Project> Add(Project newEntity)
        {
            throw new NotImplementedException();
        }

        public Task<Project> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Project> Update(Project newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
