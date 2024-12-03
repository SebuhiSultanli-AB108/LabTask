using Microsoft.AspNetCore.Mvc;

namespace MediPlus.Areas.Admin.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
