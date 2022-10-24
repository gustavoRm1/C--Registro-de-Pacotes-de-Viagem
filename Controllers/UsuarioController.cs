using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sistema_de_login.Models;
using Microsoft.AspNetCore.Http;


namespace sistema_de_login.Controllers 
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
            [HttpPost] 
            public IActionResult Login(Usuario u){
                Usuario usuarioEncontrado = UsuarioBD.ValidarLogin(u);

                if (usuarioEncontrado != null)
                {
                    HttpContext.Session.SetInt32("idUsuario",usuarioEncontrado.id);
                    HttpContext.Session.SetString("nomeUsuario",usuarioEncontrado.nome);
                    HttpContext.Session.SetInt32("tipoUsuario",usuarioEncontrado.tipo);
                    return RedirectToAction("Cadastro", "Pacotes");
                } else
                {
                    ViewBag.Mensagem = "Falha ao fazer o login!";
                    return View();
                }
        }
        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Usuario");
        }
    }
}
