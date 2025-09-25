using JovemProgramadorWeb.Data.Repositorio.Interfaces;
using JovemProgramadorWeb.Models;

namespace JovemProgramadorWeb.Data.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContexto _bancoContexto;
        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }
        public void CadastrarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Add(aluno);
            _bancoContexto.SaveChanges();
        }
        public void EditarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Update(aluno);
            _bancoContexto.SaveChanges();
        }
        public void ExcluirAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Remove(aluno);
            _bancoContexto.SaveChanges();
        }
        public void SelecionarAluno(Aluno aluno)
        {
            var alunoSelecionado = _bancoContexto.Aluno.FirstOrDefault(a => a.Codigo == aluno.Codigo);
            if (alunoSelecionado != null)
            {
                aluno.Email = alunoSelecionado.Email;
                aluno.Nome = alunoSelecionado.Nome;
                aluno.DataNascimento = alunoSelecionado.DataNascimento;
            }
        }
    }
}
