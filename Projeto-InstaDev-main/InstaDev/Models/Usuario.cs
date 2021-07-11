using System.Collections.Generic;
using System.IO;
using InstaDev.Controllers.Interfaces;

namespace InstaDev.Models
{
    public class Usuario : InstadevBase, IUsuario
    {
        public string Nome { get; set; }
        
        public string NomeDeUsuario { get; set; }
        
        public string Email { get; set; }
        
        public string Senha { get; set; }
        
        public int IDusuario { get; set; }

        public string Imagem { get; set; }

        public bool Logado { get; set; }


        private const string CAMINHO = "Database/Usuario.csv";

        public Usuario(){
            CriarPastaEArquivo(CAMINHO);
        }

        public string PrepararLinha(Usuario u){

            return $"{u.IDusuario++};{u.Email};{u.Nome};{u.NomeDeUsuario};{u.Senha};";
        }

        public void Criar(Usuario u){
            string[] linha = {PrepararLinha(u)};
            File.AppendAllLines(CAMINHO,linha);
        }

        public List<Usuario> LerTodas(){
            List<Usuario> usuarios = new List<Usuario>();

            string[] linhas = File.ReadAllLines(CAMINHO);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Usuario usu = new Usuario();
                usu.IDusuario = int.Parse(linha[0]);
                usu.Email = linha[1];
                usu.Nome = linha[2];
                usu.NomeDeUsuario = linha[3];
                usu.Senha = linha[4];

                usuarios.Add(usu);
            }
            
            return usuarios;
        }

        public void Alterar(Usuario usuario)
        {
            List<string> linhas = LerTodasLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == usuario.IDusuario.ToString());
            linhas.Add(PrepararLinha(usuario));
            ResscreverCSV(CAMINHO,linhas);
        }

        // public void MostrarDados(Usuario usuario)
        // {
        //     throw new System.NotImplementedException();
        // }

        public void ListarPosts(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }
        public void Deletar(int IdU)
        {
            List<string> linhas = LerTodasLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == IdU.ToString());
            ResscreverCSV(CAMINHO,linhas);
        }
    }
}