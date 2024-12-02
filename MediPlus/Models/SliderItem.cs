using System.ComponentModel.DataAnnotations;

namespace MediPlus.Models
{
    public class SliderItem : BaseEntity
    {
        [MaxLength(64)]
        public string Title { get; set; }
        [MaxLength(128)]
        public string SubTitle { get; set; }
        public string ImgUrl { get; set; }
    }
}
