using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LocacaoVeiculos.Models;


namespace LocacaoVeiculos.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            var usuarios = new List<Usuario>
            {
                new Usuario { Id=1, Nome="Rua a", CPF="001"},
                new Usuario { Id=2, Nome="Rua b", CPF="002"},
                new Usuario { Id=3, Nome="Rua c", CPF="003"},
                new Usuario { Id=4, Nome="Rua d", CPF="004"},
                new Usuario { Id=5, Nome="Rua e", CPF="005"}
            };
            
            return View(usuarios);
        }
    }
}