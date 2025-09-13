using JovemProgramadorWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ValidaUsuario(Usuario usuario)
        {
            try
            {
                if (usuario.Email == "carlsagan77@gmail.com" && usuario.Senha == "1234")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["MsgErro"] = "Usuário ou senha incorretos! Tente novamente...";
                }
            }
            catch (Exception)
            {
                TempData["MsgErro"] = "Usuário ou senha incorretos! Tente novamente...";
            }
            return View("Index");
        }
    }
}
