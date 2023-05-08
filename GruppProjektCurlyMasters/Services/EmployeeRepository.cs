using DbLibrary;
using GruppProjektCurlyMasters.Models;

namespace GruppProjektCurlyMasters.Services
{
    public class EmployeeRepository : IAppRepository<Employee>
    {
        private Context context;
        public EmployeeRepository(Context Dbcontext)
        {
            context = Dbcontext;
        }
        public Task<Employee> Add(Employee newEntity)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Update(Employee newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
