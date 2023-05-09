using DbLibrary;
using GruppProjektCurlyMasters.Models;
using Microsoft.EntityFrameworkCore;

namespace GruppProjektCurlyMasters.Services
{
    public class EmployeeRepository : IAppRepository<Employee>
    {
        private Context context;
        public EmployeeRepository(Context Dbcontext)
        {
            context = Dbcontext;
        }
        public async Task<Employee> Add(Employee newEntity)
        {
            var result = await context.Employees.AddAsync(newEntity);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> Delete(int id)
        {
            var result = await context.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if (result != null)
            {
                context.Employees.Remove(result);
                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await context.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllFromSingle(int id)
        {
            return await context.Employees.Where(e => e.ProjectId == id).ToListAsync();
        }

        public Task<int> GetHoursWorkFromWeek(DateTime start, DateTime end, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> GetSingle(int id)
        {
            return await context.Employees.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Employee> Update(Employee newEntity)
        {
            var result = await context.Employees.FirstOrDefaultAsync(x => x.Id == newEntity.Id);
            if (result != null)
            {
                result.Name = newEntity.Name;
                result.Age = newEntity.Age;
                result.ProjectId = newEntity.ProjectId;

                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
