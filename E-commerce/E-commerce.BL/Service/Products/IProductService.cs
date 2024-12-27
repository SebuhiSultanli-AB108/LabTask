using E_commerce.Core.Entities;

namespace E_commerce.BL.Service.Products;

public interface IProductService
{
    public Task Create(Product entity);
    public void Delete(Product target);
    public Task<Product> GetById(int id);
    public IEnumerable<Product> GetAll();
}
