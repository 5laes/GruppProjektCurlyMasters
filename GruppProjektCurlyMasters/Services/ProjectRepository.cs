using DbLibrary;
using GruppProjektCurlyMasters.Models;
using Microsoft.EntityFrameworkCore;

namespace GruppProjektCurlyMasters.Services
{
    public class ProjectRepository : IAppRepository<Project>
    {
        private Context context;
        public ProjectRepository(Context Dbcontext)
        {
            context = Dbcontext;
        }
        public async Task<Project> Add(Project newEntity)
        {
            var result = await context.Projects.AddAsync(newEntity);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Project> Delete(int id)
        {
            var result = await context.Projects.FirstOrDefaultAsync(x => x.Id == id);
            if (result != null)
            {
                context.Projects.Remove(result);
                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public Task<IEnumerable<Project>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetAllFromSingle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetHoursWorkFromWeek(DateTime start, DateTime end, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Project> GetSingle(int id)
        {
            return await context.Projects.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Project> Update(Project newEntity)
        {
            var result = await context.Projects.FirstOrDefaultAsync(x => x.Id == newEntity.Id);
            if (result != null)
            {
                result.Name = newEntity.Name;

                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
