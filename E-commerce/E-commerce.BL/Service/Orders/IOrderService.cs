using E_commerce.Core.Entities;

namespace E_commerce.BL.Service.Orders;

public interface IOrderService
{
    public Task Create(Order entity);
    public void Delete(Order target);
    public Task<Order> GetById(int id);
    public IEnumerable<Order> GetAll();
}
