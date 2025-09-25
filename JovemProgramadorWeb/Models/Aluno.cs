namespace JovemProgramadorWeb.Models
{
    public class Aluno
    {
        public int Codigo { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateOnly DataNascimento { get; set; }
    }
}
