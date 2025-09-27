using AspNetCoreGeneratedDocument;
using JovemProgramadorWeb.Data.Repositorio.Interfaces;
using JovemProgramadorWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorWeb.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }        
        public IActionResult CadastrarAluno()
        {
            return View();
        }        
        public IActionResult CadastrarNovoAluno(Aluno aluno)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _alunoRepositorio.CadastrarNovoAluno(aluno);
                    TempData["MsgSucesso"] = "Usuário cadastrado com sucesso!";
                    return RedirectToAction("Index", "Aluno");
                }
                return View("CadastrarAluno", aluno);
            }
            catch (Exception)
            {
                TempData["MsgErro"] = "Ops, não conseguimos cadastrar seu usuário! Tente novamente...";
                return View("CadastrarAluno", aluno);
            }
        }        
        public IActionResult EditarAluno()
        {
            return View();
        }        
        public IActionResult ExcluirAluno()
        {
            return View();
        }        
        public IActionResult SelecionarAluno()
        {
            return View();
        }
    }
}
