namespace E_commerce.BL.DTOs.OrderItem;

public class OrderItemGetDTO
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
