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

        [HttpPost]
        public ActionResult Post(Models.Veiculo v)
        {
            var sql = Connection.Conectar();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TableFuncionarios", sql);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();


            return View();
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