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

        public JsonResult Get(int idVeiculo)
        {
            try
            {
                var tabela = typeof(Models.Veiculo).Name;

                

                return Json(new { result = "Comando executado com êxito." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { result = "Erro ao executar comando.", e }, JsonRequestBehavior.AllowGet);
                throw;
            }            
        }


        /// <summary>
        /// Página para adicionar novo item
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Post(Models.Veiculo v)
        {       
            try
            {
                var parameters = new List<Models.Veiculo>();

                //Tabela tem de ter o mesmo nome da classe
                var tabela = typeof(Models.Veiculo).Name;

                Commands.Insert("'" + v.Marca + "', '" + v.Modelo + "', '" + v.Placa + "', " + v.ValorFipe + ", '" + v.AnoFabricacao.ToString("yyyy/MM/dd") + "', '" + v.UltimaRevisao.ToString("yyyy/MM/dd") + "'", tabela);

                return Json(new { result = "Comando executado com êxito." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { result = "Erro ao executar comando.", e }, JsonRequestBehavior.AllowGet);
                throw;
            }
        }

        //[HttpGet]
        //public ActionResult Put()
        //{
        //    return View();
        //}

        //[HttpPut]
        //public JsonResult Put(int idVeiculo)
        //{
        //    try
        //    {
        //        var parameters = new List<Models.Veiculo>();

        //        //Tabela tem de ter o mesmo nome da classe
        //        var tabela = typeof(Models.Veiculo).Name;

        //        Commands.Insert("'" + v.Marca + "', '" + v.Modelo + "', '" + v.Placa + "', " + v.ValorFipe + ", '" + v.AnoFabricacao.ToString("yyyy/MM/dd") + "', '" + v.UltimaRevisao.ToString("yyyy/MM/dd") + "'", tabela);

        //        return Json(new { result = "Comando executado com êxito." }, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception e)
        //    {
        //        return Json(new { result = "Erro ao executar comando.", e }, JsonRequestBehavior.AllowGet);
        //        throw;
        //    }
        //}

        [HttpDelete]
        public ActionResult Delete(int idVeiculo)
        {
            return View();
        }
    }
}