namespace MediPlus.Models;

public class ServiceItem : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
    public int? DepartmentId { get; set; }
    public Department? Department { get; set; }
}
