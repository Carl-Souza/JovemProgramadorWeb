using AspNetCoreGeneratedDocument;
using JovemProgramadorWeb.Data.Repositorio.Interfaces;
using JovemProgramadorWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ValidaUsuario(Usuario usuario)
        {
            try
            {
                var usuarioRetornado = _usuarioRepositorio.ValidaUsuario(usuario);

                if (usuarioRetornado != null)
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
        public IActionResult Cadastro (Usuario usuario)
        {
            return View();
        }

        public IActionResult CadastrarUsuario (Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuarioRepositorio.CadastrarUsuario(usuario);
                    TempData["MsgSucesso"] = "Usuário cadastrado com sucesso!";
                    return RedirectToAction("Index", "Login");
                }
                return View("Cadastro", usuario);
            }
            catch (Exception)
            {
                TempData["MsgErro"] = "Ops, não conseguimos cadastrar seu usuário! Tente novamente...";
                return View("Cadastro", usuario);
            }
        }
    }

}
