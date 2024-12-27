namespace E_commerce.BL.DTOs.Order;

public class OrderCreateDTO
{
    public DateTime OrderDate { get; set; }
    public ICollection<int> OrderItemIds { get; set; }
    public decimal TotalPrice { get; set; }
}
