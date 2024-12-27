namespace E_commerce.BL.DTOs.Products;

public class ProductGetDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public ICollection<int> OrderItemIds { get; set; }
}
