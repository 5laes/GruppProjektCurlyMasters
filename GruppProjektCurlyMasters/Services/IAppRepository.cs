namespace GruppProjektCurlyMasters.Services
{
    public interface IAppRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAllFromSingle(int id);
        Task<int> GetHoursWorkFromWeek(DateTime start, DateTime end, int id);
        Task<T> GetSingle(int id);
        Task<T> Add(T newEntity);
        Task<T> Update(T newEntity);
        Task<T> Delete(int id);
    }
}
