using projeto_produtos.Classes;
using System.Collections.Generic;
namespace projeto_produtos.Interfaces
{
    public interface IMarca
    {
        string Cadastrar(Marca novaMarca);

        List<Marca> Listar();

        string Deletar(Marca marca, int index);
    }
}