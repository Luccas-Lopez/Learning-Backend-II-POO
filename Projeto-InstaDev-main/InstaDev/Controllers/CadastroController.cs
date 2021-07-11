using InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Controllers
{
    [Route("Usuario")]
    public class CadastroController : Controller
    {
        Usuario UsuarioModel = new Usuario();

        [Route("Listar")]
        public IActionResult Index(){
            ViewBag.usuario = UsuarioModel.LerTodas();
            return View();
        }

        [Route("Cadastrar")]

        public IActionResult Cadastrar(IFormCollection form){
            
            Usuario novoUsuario = new Usuario();
            novoUsuario.IDusuario = UsuarioModel.GerarId();
            novoUsuario.Email = form["Email"]; 
            novoUsuario.Nome = form["Nome"]; 
            novoUsuario.NomeDeUsuario = form["NomeDeUsuario"]; 
            novoUsuario.Senha = form["Senha"];

            UsuarioModel.Criar(novoUsuario);

            ViewBag.usuario = UsuarioModel.LerTodas();
            return LocalRedirect("~/Usuario/Listar");
        }

    }
}