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
    public class Pacotes : Controller
    {
        public IActionResult Cadastro()
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            if(HttpContext.Session.GetInt32("tipoUsuario") != 1)
                return RedirectToAction("AcessoNegado", "Home");
            return View();
        }



        [HttpPost]
        public IActionResult Cadastro(PacoteM novoPacote)
        {
            PacoteMDB.Inserir(novoPacote);
            ViewBag.Mensagem = "Novo pacote adicionado com sucesso!";
            return View();
        }
        
        public IActionResult PacotesL()
        {
            List<PacoteM> listaCompleta = PacoteMDB.Listar();
            return View (listaCompleta);
        }
        public IActionResult Editar(int id)
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            PacoteM pacote = PacoteMDB.BuscarPorId(id);
            return View(pacote);
        }
        [HttpPost]
        public IActionResult Editar(PacoteM pacote){
            PacoteMDB.Atualizar(pacote);
            ViewBag.Mensagem = "Pacote editado com sucesso!";
            return RedirectToAction("PacotesL");
        }
        public IActionResult Remover(int id)
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
            return RedirectToAction("Login", "Usuario");
            }

            PacoteMDB.Remover(id);
            return RedirectToAction("PacotesL");
        }
    }
}