using E_commerce.Core.Entities;

namespace E_commerce.BL.Service.OrderItemItem;

public interface IOrderItemService
{
    public Task Create(OrderItem entity);
    public void Delete(OrderItem target);
    public Task<OrderItem> GetById(int id);
    public IEnumerable<OrderItem> GetAll();
}
