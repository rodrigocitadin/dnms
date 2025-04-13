namespace Dnms.Core.Interfaces;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync();
    Task AddAsync(T entity);
    Task DeleteAsync(T entity);
}
