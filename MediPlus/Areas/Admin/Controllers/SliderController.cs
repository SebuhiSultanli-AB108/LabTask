using MediPlus.DataAccess;
using MediPlus.Models;
using MediPlus.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediPlus.Areas.Admin.Controllers;
[Area("Admin")]
public class SliderController(MediPlusDbContext _context, IWebHostEnvironment _env) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await _context.sliderItems.ToListAsync());
    }
    public IActionResult Create()
    {
        return View();
    }

    public async Task<IActionResult> Update(SliderCreateVM vm, int? id)
    {
        if (id == null) return BadRequest();
        if (!vm.File.ContentType.StartsWith("image"))
        {
            ModelState.AddModelError("File", "Format type must be an image.");
            return View(vm);
        }
        if (vm.File.Length > 2 * 1024 * 1024)
        {
            ModelState.AddModelError("File", "File size must be less than 2 MB.");
            return View(vm);
        }
        var updateiItem = await _context.sliderItems.Where(x => x.Id == id).FirstOrDefaultAsync();
        updateiItem.Title = vm.Title;
        updateiItem.SubTitle = vm.Title;
        updateiItem.CreatedDate = DateTime.Now;
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return BadRequest();
        var deletable = await _context.sliderItems.Where(x => x.Id == id).FirstOrDefaultAsync();
        if (deletable == null) return NotFound();
        _context.sliderItems.Remove(deletable);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Create(SliderCreateVM vm)
    {
        if (!ModelState.IsValid) return View(vm);
        if (!vm.File.ContentType.StartsWith("image"))
        {
            ModelState.AddModelError("File", "Format type must be an image.");
            return View(vm);
        }
        if (vm.File.Length > 2 * 1024 * 1024)
        {
            ModelState.AddModelError("File", "File size must be less than 2 MB.");
            return View(vm);
        }
        string newName = Path.GetRandomFileName() + Path.GetExtension(vm.File.FileName);
        using (Stream stream = System.IO.File.Create(Path.Combine(_env.WebRootPath, "home", "sliderimgs", newName)))
        {
            await vm.File.CopyToAsync(stream);
        }
        SliderItem slider = new SliderItem
        {
            ImgUrl = newName,
            Title = vm.Title,
            SubTitle = vm.Subtitle!,
        };
        await _context.sliderItems.AddAsync(slider);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}
