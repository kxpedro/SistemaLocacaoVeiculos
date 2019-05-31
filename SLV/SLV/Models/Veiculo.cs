using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SLV.Models
{
    public class Veiculo
    {
        public int IdVeiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public double ValorFipe { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public DateTime UltimaRevisao { get; set; }
    }
}