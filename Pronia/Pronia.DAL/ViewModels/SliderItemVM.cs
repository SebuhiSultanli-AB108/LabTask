using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Pronia.DAL.ViewModels;

public class SliderItemVM
{
    [Range(0, int.MaxValue)]
    public int Price { get; set; }
    [MaxLength(32)]
    public string Title { get; set; }
    [MaxLength(64)]
    public string ShortDescription { get; set; }
    [MaxLength(512)]
    public string Description { get; set; }
    public string ImgPath;
    public IFormFile s;
    //public static implicit operator SliderItem(SliderItemVM vm)
    //{
    //    return new SliderItem
    //    {
    //        Title = vm.Title,
    //        ShortDescription = vm.ShortDescription,
    //        Description = vm.Description,
    //        Price = vm.Price,
    //        ImgPath = vm.,
    //        CreatedDate = DateTime.Now,
    //    };
    //}
}
