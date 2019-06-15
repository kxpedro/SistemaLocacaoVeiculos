using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocacaoVeiculos.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public double ValorLocado { get; set; }
        public int IdVeiculo { get; set; }        
    }
}