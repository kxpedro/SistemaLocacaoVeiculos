using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocacaoVeiculos.Controllers
{
    public class LocacaoController : Controller
    {
        // GET: Locacao
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Locar()
        {
            return View();
        }
    }
}