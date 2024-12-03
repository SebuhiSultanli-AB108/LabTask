using System.ComponentModel.DataAnnotations;

namespace MediPlus.ViewModels;

public class ServiceItemVM
{
    [MaxLength(64, ErrorMessage = "Max length must be 64"), Required]
    public string Title { get; set; }
    [MaxLength(256, ErrorMessage = "Max length must be 256"), Required]
    public string Description { get; set; }
    public string Icon { get; set; }
}
