using InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers.Interfaces
{

    public class PostController : Controller
    {
        Post PostModel = new Post();

        [Route("Listar")]
        public IActionResult Index(){
            ViewBag.Post = PostModel.LerTodas();
            return View();
        }

        [Route("Cadastrar")]

        public IActionResult Cadastrar(IFormCollection form){
            Post NovoPost = new Post();
            NovoPost.IdPost = int.Parse(form["IdPost"]);
            NovoPost.IdUsuario = int.Parse(form["IdUsuario"]); 
            NovoPost.Imagem = form["Imagem"]; 
            NovoPost.Legenda = form["Legenda"]; 

            PostModel.Criar(NovoPost);

            ViewBag.Post = PostModel.LerTodas();
            return LocalRedirect("~/Post/Listar");
        }
    }
}