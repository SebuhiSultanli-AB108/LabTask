using E_commerce.Core.Entities;
using E_commerce.Core.IRepositories;

namespace E_commerce.BL.Service.Products;

public class ProductService(IRepository<Product> _repository) : IProductService
{
    public async Task Create(Product entity)
    {
        await _repository.Create(entity);
    }

    public void Delete(Product target)
    {
        _repository.Delete(target);
    }

    public IEnumerable<Product> GetAll()
    {
        return _repository.GetAll(false, nameof(OrderItem));
    }

    public async Task<Product> GetById(int id)
    {
        return await _repository.GetById(id, nameof(OrderItem));
    }
}
