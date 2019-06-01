using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SLV.Database;
using System.Data.SqlClient;
using System.Data;

namespace SLV.Controllers
{
    public class VeiculoController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var veiculos = new Models.Veiculo();

            return View(veiculos);
        }

        [HttpGet]
        public ActionResult Details(int idVeiculo)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Get()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddNew(Models.Veiculo v)
        {       
            try
            {                
                Commands.Insert("'"+ v.Marca + "', '" + v.Modelo + "', '" + v.Placa + "', " + v.ValorFipe + ", '" + v.AnoFabricacao.ToString("yyyy/MM/dd") + "', '" + v.UltimaRevisao.ToString("yyyy/MM/dd") + "'", typeof(Models.Veiculo).Name);
                return Json(new { result = "Comando executado com êxito." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { result = "Erro ao executar comando.", content = e.ToString() }, JsonRequestBehavior.AllowGet);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put(int idVeiculo)
        {
            return View();
        }

        [HttpDelete]
        public ActionResult Delete(int idVeiculo)
        {
            return View();
        }
    }
}