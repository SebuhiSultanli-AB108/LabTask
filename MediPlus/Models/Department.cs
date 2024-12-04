namespace MediPlus.Models;

public class Department : BaseEntity
{
    public string Name { get; set; }
    public ICollection<ServiceItem> ServiceItems { get; set; }
}
