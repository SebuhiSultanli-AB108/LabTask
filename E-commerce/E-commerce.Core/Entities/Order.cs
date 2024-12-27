namespace E_commerce.Core.Entities;

public class Order : AuditableEntity
{
    public DateTime OrderDate { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
    public decimal TotalPrice { get; set; }
}
