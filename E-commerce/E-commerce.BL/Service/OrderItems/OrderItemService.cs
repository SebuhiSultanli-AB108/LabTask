using E_commerce.BL.Service.OrderItemItem;
using E_commerce.Core.Entities;
using E_commerce.Core.IRepositories;

namespace E_commerce.BL.Service.OrderItems;

public class OrderItemService(IRepository<OrderItem> _repository) : IOrderItemService
{
    public async Task Create(OrderItem entity)
    {
        await _repository.Create(entity);
    }

    public void Delete(OrderItem target)
    {
        _repository.Delete(target);
    }

    public IEnumerable<OrderItem> GetAll()
    {
        return _repository.GetAll(false, nameof(OrderItem));
    }

    public async Task<OrderItem> GetById(int id)
    {
        return await _repository.GetById(id, nameof(OrderItem));
    }
}
