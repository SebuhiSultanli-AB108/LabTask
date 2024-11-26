using Microsoft.EntityFrameworkCore;
using Pronia.BL.Services.Abstraction;
using Pronia.DAL.Contexts;
using Pronia.DAL.Models;

namespace Pronia.BL.Services.Concretes;

public class SliderItemService : ISliderItemService
{
    private readonly ProniaDbContext _context;

    public SliderItemService(ProniaDbContext context)
    {
        _context = context;
    }

    public async Task CreateSliderItemAsync(SliderItem sliderItem)
    {
        await _context.SliderItems.AddAsync(sliderItem);
        await _context.SaveChangesAsync();
    }

    public async Task<List<SliderItem>> GetAllSliderItemsAsync()
    {
        List<SliderItem> sliderItems = await _context.SliderItems.ToListAsync();
        return sliderItems;
    }

    public Task<SliderItem> GetSliderByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task HardDeleteSliderItemAsync(int id)
    {
        SliderItem? baseSliderItem = await _context.SliderItems.FindAsync(id);

        if (baseSliderItem is null)
            throw new Exception("Slider item not found!");
        if (!baseSliderItem.IsDeleted)
            throw new Exception("Slider item has not soft deleted before!");

        _context.SliderItems.Remove(baseSliderItem);
        await _context.SaveChangesAsync();
    }

    public async Task SoftDeleteSliderItemAsync(int id)
    {
        SliderItem? baseSliderItem = await _context.SliderItems.SingleOrDefaultAsync(s => s.Id == id && !s.IsDeleted);

        if (baseSliderItem is null)
            throw new Exception("Slider item not found!");

        baseSliderItem.IsDeleted = true;
        await _context.SaveChangesAsync();
    }

    public Task UpdateSliderItemAsync(int id, SliderItem sliderItem)
    {
        throw new NotImplementedException();
    }
}
