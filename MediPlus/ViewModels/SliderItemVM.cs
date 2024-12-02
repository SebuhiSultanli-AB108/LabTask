using System.ComponentModel.DataAnnotations;

namespace MediPlus.ViewModels
{
    public class SliderItemVM
    {
        [MaxLength(64, ErrorMessage = "Max length must be 64")]
        public string Title { get; set; }
        [MaxLength(128, ErrorMessage = "Max length must be 64")]
        public string SubTitle { get; set; }
        public IFormFile File { get; set; }
    }
}
