using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocacaoVeiculos.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public int IdVeiculo { get; set; }
        public int IdUsuario { get; set; }
    }
}