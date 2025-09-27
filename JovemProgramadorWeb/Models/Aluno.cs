namespace JovemProgramadorWeb.Models
{
    public class Aluno
    {
        public int Codigo { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateOnly DataNascimento { get; set; }

        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
    }
}
