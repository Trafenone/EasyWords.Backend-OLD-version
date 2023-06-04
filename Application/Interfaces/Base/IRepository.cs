namespace Application.Interfaces.Base
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T item);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
