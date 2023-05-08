namespace GruppProjektCurlyMasters.Services
{
    public interface IAppRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetSingle(int id);
        Task<T> Add(T newEntity);
        Task<T> Update(T newEntity);
        Task<T> Delete(int id);
    }
}
