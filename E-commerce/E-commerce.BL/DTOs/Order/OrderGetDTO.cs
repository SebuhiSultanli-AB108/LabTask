namespace E_commerce.BL.DTOs.Order;

public class OrderGetDTO
{
    public DateTime OrderDate { get; set; }
    public ICollection<int> OrderItemIds { get; set; }
    public decimal TotalPrice { get; set; }
}
