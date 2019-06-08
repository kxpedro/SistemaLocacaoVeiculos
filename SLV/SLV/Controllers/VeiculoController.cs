using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SLV.Database;
using System.Data.SqlClient;
using System.Data;
using SLV.Models;
using Newtonsoft.Json;

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
            //var list = Commands.SelectAll(typeof(Models.Veiculo).Name);
            //var list = repository.Select();   
            var sqlCon = Commands.Conectar();

            SqlCommand cmd = new SqlCommand("INSERT INTO " + tabela + " VALUES (" + values + ")", sqlCon);

            sqlCon.Open();
            cmd.ExecuteNonQuery();
            sqlCon.Close();


            return View();
        }

        [HttpGet]
        public ActionResult Details(int idVeiculo)
        {
            //var list = repository.SelectById(idVeiculo);
            return View();
        }

        [HttpGet]
        public ActionResult Get()
        {
            //var select = Commands.SelectAll(typeof(Veiculo).Name);
            //var json = JsonConvert.DeserializeObject<Veiculo>(select);

            //var list = repository.Select();
            return View();
        }        

        [HttpGet]        
        public ActionResult Post(Models.Veiculo v)
        {         
            //repository.Add(v);

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