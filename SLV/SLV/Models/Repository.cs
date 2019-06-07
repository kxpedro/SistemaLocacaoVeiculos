using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SLV.Models
{
    public class Repository
    {
        private List<Veiculo> veiculos;
        public Repository()
        {
            veiculos = new List<Veiculo>();
        }

        private static Repository instance;

        public static Repository CreateInstance()
        {
            return instance ?? (new Repository());
        }

        public List<Veiculo> Select()
        {
            veiculos.ToList();
            return veiculos;
        }

        public List<Veiculo> SelectById(int idVeiculo)
        {
            veiculos.Where(x => x.IdVeiculo == idVeiculo).ToList();
            return veiculos;
        }

        public void Add(Veiculo v)
        {
            veiculos.Add(v);           
        }

        public void Delete(int idVeiculo)
        {                        
            veiculos.RemoveAt(idVeiculo);
        }

    }
}