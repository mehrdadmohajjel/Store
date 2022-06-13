using Microsoft.AspNetCore.Mvc;

namespace Store.Clinets.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
