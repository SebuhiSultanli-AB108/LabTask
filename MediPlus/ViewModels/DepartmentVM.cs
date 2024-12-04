using System.ComponentModel.DataAnnotations;

namespace MediPlus.ViewModels
{
    public class DepartmentVM
    {
        [MaxLength(64, ErrorMessage = "Max length must be 64")]
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
