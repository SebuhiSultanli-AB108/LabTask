using E_commerce.Core.Entities;
using E_commerce.Core.IRepositories;
using E_commerce.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.DAL.Repositories;

public class Repository<T>(E_comDbContext _context) : IRepository<T> where T : BaseEntity, new()
{
    public async Task Create(T entity)
    {
        await _context.AddAsync<T>(entity);
        await _context.SaveChangesAsync();
    }

    public void Delete(T entity)
    {
        _context.Remove<T>(entity);
    }

    public async Task<T> GetById(int id, string include)
    {
        var data = await _context.FindAsync<T>(id);
        return data;
    }

    public IQueryable<T> GetAll(bool isTracking, params string[] includes)
    {
        var query = _context.Set<T>().AsQueryable();
        if (!isTracking)
            query = query.AsNoTracking();

        if (includes.Length > 0)
            foreach (string include in includes)
                query = query.Include(include);

        return query;
    }
}
