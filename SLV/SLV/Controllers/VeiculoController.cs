using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SLV.Database;
using System.Data.SqlClient;
using System.Data;
using SLV.Models;

namespace SLV.Controllers
{
    public class VeiculoController : Controller
    {
        private Repository repository;
        public VeiculoController()
        {
            repository = Repository.CreateInstance();
        }

        [HttpGet]
        public ActionResult Index()
        {
            //var veiculos = new Models.Veiculo();
            var list = repository.Select();            
            return View(list);
        }

        [HttpGet]
        public ActionResult Details(int idVeiculo)
        {
            var list = repository.SelectById(idVeiculo);
            return View(list);
        }

        [HttpGet]
        public ActionResult Get()
        {
            var list = repository.Select();
            return View(list);
        }

        [HttpGet]
        public ActionResult Post(Models.Veiculo v)
        {
            repository.Add(v);

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int idVeiculo)
        {
            repository.Delete(idVeiculo);
            return RedirectToAction("Index");
        }
    }
}