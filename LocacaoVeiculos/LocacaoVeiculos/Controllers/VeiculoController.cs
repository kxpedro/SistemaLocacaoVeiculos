using LocacaoVeiculos.Models;
using Newtonsoft.Json;
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

        public ActionResult Locar(int id)
        {
            var json = Api.DadosRequisicao();
            //var json = "[{\"Id\":\"1\",\"Marca\":\"Fiat\",\"Modelo\":\"Palio\",\"Placa\":\"AAD44333\",\"ValorFipe\":10500,\"ValorLocacao\":900,\"AnoFabricacao\":\"01/01/2005 00:00:00\",\"UltimaRevisao\":\"01/01/2019 00:00:00\"},{ \"Id\":\"2\",\"Marca\":\"Renault\",\"Modelo\":\"Clio\",\"Placa\":\"SSE1122\",\"ValorFipe\":11500,\"ValorLocacao\":800,\"AnoFabricacao\":\"01/01/2008 00:00:00\",\"UltimaRevisao\":\"01/10/2018 00:00:00\"}]";
            var dJson = JsonConvert.DeserializeObject<List<Veiculo>>(json);
            var locacao = new List<Locacao>();
            var veiculo = Database.Details(id);
            int i = 0;

            foreach (var item in dJson)
            {
                i++;
                if (item.Marca == veiculo.Marca)
                {
                    var desconto = (double)veiculo.ValorLocacao - ((double)veiculo.ValorLocacao * 0.20);

                    ViewBag.Desconto = (double)veiculo.ValorLocacao - desconto;

                    locacao.Add(new Locacao { Id = i, IdVeiculo = veiculo.Id, ValorLocado = desconto });
                }
            }           

            ViewBag.Locacao = locacao;

            return View(veiculo);
        }

    }
}
