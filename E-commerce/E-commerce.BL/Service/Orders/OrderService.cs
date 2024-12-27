using E_commerce.Core.Entities;
using E_commerce.Core.IRepositories;

namespace E_commerce.BL.Service.Orders;

public class OrderService(IRepository<Order> _repository) : IOrderService
{
    public async Task Create(Order entity)
    {
        await _repository.Create(entity);
    }

    public void Delete(Order target)
    {
        _repository.Delete(target);
    }

    public IEnumerable<Order> GetAll()
    {
        return _repository.GetAll(false, nameof(OrderItem));
    }

    public async Task<Order> GetById(int id)
    {
        return await _repository.GetById(id, nameof(OrderItem));
    }
}
