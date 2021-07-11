using System.Collections.Generic;
using System.IO;
using InstaDev.Controllers.Interfaces;

namespace InstaDev.Models
{
    public class Post : InstadevBase, IPost
    {
        public int IdPost { get; set; }
        public int IdUsuario { get; set; }
        public string Imagem { get; set; }
        public string Legenda { get; set; }
        Usuario usuario = new Usuario();
        // public string NomeUsuarioPost = usuario.NomeDeUsuario;

        private const string CAMINHO = "Database/Post.csv";

        public Post(){
            CriarPastaEArquivo(CAMINHO);
        }

        public string PrepararLinha(Post p){
            return $"{p.IdPost};{usuario.NomeDeUsuario};{p.IdUsuario};{p.Imagem};{p.Legenda}";
        }
        public void Criar(Post p)
        {
            string[] Linha = {PrepararLinha(p)};
            File.AppendAllLines(CAMINHO, Linha);
        }

        public List<Post> LerTodas(){
            List<Post> Posta = new List<Post>();
            string[] Linhas = File.ReadAllLines(CAMINHO);

            foreach (var item in Linhas)
            {
                string[] Linha = item.Split(";");
                Post NovoPost = new Post();
                NovoPost.IdPost = int.Parse(Linha[0]);
                NovoPost.IdUsuario = int.Parse(Linha[1]);
                NovoPost.Imagem = Linha[2];
                NovoPost.Legenda = Linha[3];
                // NovoPost. = Linha[4];
                Posta.Add(NovoPost);
            }
            return Posta;
        }

        public void ListarTodosOsPosts(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public void LerTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}