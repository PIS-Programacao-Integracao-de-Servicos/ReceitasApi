using Microsoft.AspNetCore.Mvc;

namespace GestaoReceitasApi.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
