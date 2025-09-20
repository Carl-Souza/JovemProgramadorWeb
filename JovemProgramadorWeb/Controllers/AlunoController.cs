using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorWeb.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
