using System.ComponentModel.DataAnnotations;

namespace Pronia.DAL.Models;

public class SliderItem : BaseEntity
{
    [Range(0, int.MaxValue)]
    public int Price { get; set; }
    [MaxLength(32)]
    public string Title { get; set; }
    [MaxLength(64)]
    public string ShortDescription { get; set; }
    [MaxLength(512)]
    public string Description { get; set; }
    public string ImgPath { get; set; }
}
