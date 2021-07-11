using System.Collections.Generic;
using InstaDev.Models;

namespace InstaDev.Controllers.Interfaces
{
    public interface IUsuario
    {
         void Alterar(Usuario usuario);
        // void MostrarDados(Usuario usuario);
        void ListarPosts(Usuario usuario);
        void Deletar(int Idu);

        List<Usuario> LerTodas();
    }
}