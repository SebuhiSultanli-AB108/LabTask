using Pronia.DAL.Models;

namespace Pronia.BL.Services.Abstraction;

public interface ISliderItemService
{
    Task<SliderItem> GetSliderByIdAsync(int id);
    Task<List<SliderItem>> GetAllSliderItemsAsync();
    Task CreateSliderItemAsync(SliderItem sliderItem);
    Task UpdateSliderItemAsync(int id, SliderItem sliderItem);
    Task SoftDeleteSliderItemAsync(int id);
    Task HardDeleteSliderItemAsync(int id);
}
