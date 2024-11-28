using Microsoft.AspNetCore.Mvc;
using Pronia.BL.Services.Abstraction;
using Pronia.DAL.Models;
using Pronia.DAL.ViewModels;

namespace Pronia.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TableController : Controller
    {
        private readonly ISliderItemService _sliderItemService;

        public TableController(ISliderItemService sliderItemService)
        {
            _sliderItemService = sliderItemService;
        }

        public async Task<IActionResult> Index()
        {
            List<SliderItem> sliderItems = await _sliderItemService.GetAllSliderItemsAsync();
            return View(sliderItems);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(SliderItemVM vm, int id)
        {
            if (!ModelState.IsValid)
                return View(vm);
            await _sliderItemService.CreateSliderItemAsync(new SliderItem
            {
                Title = vm.Title,
                ShortDescription = vm.ShortDescription,
                Description = vm.Description,
                Price = vm.Price,
                ImgPath = vm.ImgPath,
                CreatedDate = DateTime.Now,
            });
            return RedirectToAction(nameof(Index));
        }
        //public async Task<IActionResult> Update(int id, SliderItem sliderItem)
        //{
        //    await _sliderItemService.UpdateSliderItemAsync(id, sliderItem);
        //    return View();
        //}
        public async Task<IActionResult> Delete(int id)
        {
            SliderItem sliderItem = await _sliderItemService.GetSliderByIdAsync(id);
            if (!sliderItem.IsDeleted)
                await _sliderItemService.SoftDeleteSliderItemAsync(id);
            else
                await _sliderItemService.HardDeleteSliderItemAsync(id);
            return View(sliderItem);
        }
    }
}
