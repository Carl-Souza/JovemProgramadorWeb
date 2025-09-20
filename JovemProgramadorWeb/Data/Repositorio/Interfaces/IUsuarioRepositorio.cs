using JovemProgramadorWeb.Models;

namespace JovemProgramadorWeb.Data.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio
    {
        public void CadastrarUsuario(Usuario usuario);

        public Usuario ValidaUsuario(Usuario usuario);
    }
}
