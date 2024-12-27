using E_commerce.Core.Entities;

namespace E_commerce.Core.IRepositories;

public interface IRepository<T> where T : BaseEntity, new()
{
    public IQueryable<T> GetAll(bool isTracking, params string[] includes);
    public Task Create(T entity);
    public void Delete(T entity);
    public Task<T> GetById(int id, string include);
}
