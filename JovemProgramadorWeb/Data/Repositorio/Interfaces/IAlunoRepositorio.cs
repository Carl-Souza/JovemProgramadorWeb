using JovemProgramadorWeb.Models;

namespace JovemProgramadorWeb.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        public void CadastrarAluno(Aluno aluno);
        public void SelecionarAluno(Aluno aluno);
        public void EditarAluno(Aluno aluno);
        public void ExcluirAluno(Aluno aluno);
    }
}
