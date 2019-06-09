using LocacaoVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocacaoVeiculos.Controllers
{
    public class VeiculoController : Controller
    {
        /// <summary>
        /// Página principal com a lista de todos os veiculos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {                   
            return View(Database.Select());
        }

        /// <summary>
        /// Página de um veiculo selecionado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(Database.Details(id));
        }

        /// <summary>
        /// Página da criação de um veiculo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Criação de um veiculo
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(Veiculo v)
        {
            try
            {
                Database.Insert(v);
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View();
            }
        }

        /// <summary>
        /// Página da Edição de um veiculo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        /// <summary>
        /// Edição de Veiculo selecionado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult Edit(int id, Veiculo v)
        {
            try
            {
                //Database.Update(id, v);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(Database.Details(id));
        }

        /// <summary>
        /// Deleção do veiculo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(int id, Veiculo v)
        {
            try
            {              
                Database.Delete(id, v);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}
