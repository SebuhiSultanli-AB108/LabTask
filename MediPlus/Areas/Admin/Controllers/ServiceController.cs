using MediPlus.DataAccess;
using MediPlus.Models;
using MediPlus.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediPlus.Areas.Admin.Controllers;
[Area("Admin")]
public class ServiceController(MediPlusDbContext _context) : Controller
{
    public async Task<IActionResult> Index()
    {
        return View(await _context.serviceItems.ToListAsync());
    }
    public IActionResult Create() { return View(); }
    public async Task<IActionResult> Update(int? id)
    {
        ServiceItemVM vm = new();
        var data = _context.serviceItems.Find(id.Value);
        vm.Title = data.Title;
        vm.Description = data.Description;
        vm.Icon = data.Icon;
        return View(vm);
    }
    [HttpPost]
    public async Task<IActionResult> Create(ServiceItemVM vm)
    {
        if (!ModelState.IsValid) return View(vm);
        ServiceItem serviceItem = new ServiceItem
        {
            Title = vm.Title,
            Description = vm.Description,
            Icon = vm.Icon,
        };
        await _context.serviceItems.AddAsync(serviceItem);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return BadRequest();
        var deletable = await _context.serviceItems.Where(x => x.Id == id).FirstOrDefaultAsync();
        if (deletable == null) return NotFound();
        _context.serviceItems.Remove(deletable);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    [HttpPost]
    public async Task<IActionResult> Update(ServiceItemVM vm, int? id)
    {
        if (id == null) return BadRequest();
        var updateable = await _context.serviceItems.Where(x => x.Id == id).FirstOrDefaultAsync();
        if (updateable == null) return NotFound();
        updateable.Title = vm.Title;
        updateable.Description = vm.Description;
        updateable.Icon = vm.Icon;
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}
