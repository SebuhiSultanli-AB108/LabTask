using MediPlus.DataAccess;
using MediPlus.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediPlus.Controllers;

public class HomeController(MediPlusDbContext _context) : Controller
{
    public async Task<IActionResult> Index()
    {
        HomeItemVM vm = new();
        vm.sliderItems = await _context.sliderItems.ToListAsync();
        vm.serviceItems = await _context.serviceItems.ToListAsync();
        return View(vm);
    }
}