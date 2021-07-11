
using InstaDev.Models;

namespace InstaDev.Controllers.Interfaces
{
    public interface IPost
    {
         void ListarTodosOsPosts(Usuario usuario);
        void LerTodos();
    }
}