using DbLibrary;
using GruppProjektCurlyMasters.Models;
using Microsoft.EntityFrameworkCore;

namespace GruppProjektCurlyMasters.Services
{
    public class TimeReportRepository : IAppRepository<TimeReport>
    {
        private Context context;
        public TimeReportRepository(Context Dbcontext)
        {
            context = Dbcontext;
        }
        public async Task<TimeReport> Add(TimeReport newEntity)
        {
            var result = await context.timeReports.AddAsync(newEntity);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<TimeReport> Delete(int id)
        {
            var result = await context.timeReports.FirstOrDefaultAsync(x => x.Id == id);
            if (result != null)
            {
                context.timeReports.Remove(result);
                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public Task<IEnumerable<TimeReport>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TimeReport>> GetAllFromSingle(int id)
        {
            return await context.timeReports.Where(t => t.EmployeeId == id).ToListAsync();
        }

        public async Task<TimeReport> GetSingle(int id)
        {
            return await context.timeReports.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TimeReport> Update(TimeReport newEntity)
        {
            var result = await context.timeReports.FirstOrDefaultAsync(x => x.Id == newEntity.Id);
            if (result != null)
            {
                result.TimeCheckIn = newEntity.TimeCheckIn;
                result.TimeCheckOut = newEntity.TimeCheckOut;

                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<int> GetHoursWorkFromWeek(DateTime start, DateTime end, int id)
        {
            var result = await context.timeReports.Where(x => x.TimeCheckIn > start && x.TimeCheckOut < end && x.EmployeeId == id).ToListAsync();
            int hours = 0;
            foreach (var item in result)
            {
                DateTime morning = item.TimeCheckIn;
                DateTime afternoon = item.TimeCheckOut;
                TimeSpan ts = afternoon - morning;
                hours += (int)ts.TotalHours; 
            }
            return hours;
        }
    }
}
