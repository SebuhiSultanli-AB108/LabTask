using MediPlus.DataAccess;
using MediPlus.Models;
using MediPlus.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediPlus.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DepartmentController(MediPlusDbContext _context) : Controller
    {
        public async Task<IActionResult> Index() { return View(await _context.departments.ToListAsync()); }
        public async Task<IActionResult> Update(int? id)
        {
            DepartmentVM vm = new();
            var data = _context.departments.Find(id.Value);
            vm.Name = data.Name;
            return View(vm);
        }
        public async Task<IActionResult> Create() { return View(); }
        [HttpPost]
        public async Task<IActionResult> Create(DepartmentVM vm)
        {
            if (!ModelState.IsValid) return View(vm);
            Department department = new Department
            {
                Name = vm.Name,
            };
            await _context.departments.AddAsync(department);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();
            var deletable = await _context.departments.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (deletable == null) return NotFound();
            _context.departments.Remove(deletable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> Update(DepartmentVM vm, int? id)
        {
            if (id == null) return BadRequest();
            var updateable = await _context.departments.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (updateable == null) return NotFound();
            updateable.Name = vm.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
