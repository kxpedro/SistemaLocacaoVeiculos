using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SLV.Models
{
    public class Veiculo
    {
        [DisplayName("Identificação do Veiculo")]
        public int IdVeiculo { get; set; }
        [DisplayName("Marca do Veiculo")]
        public string Marca { get; set; }
        [DisplayName("Modelo do Veiculo")]
        public string Modelo { get; set; }
        [DisplayName("Placa do Veiculo")]
        public string Placa { get; set; }
        [DisplayName("Valor na Tabela Fipe do Veiculo")]
        public double ValorFipe { get; set; }
        [DisplayName("Ano de Fabricacao do Veiculo")]
        public DateTime AnoFabricacao { get; set; }
        [DisplayName("Ultima Revisao do Veiculo")]
        public DateTime UltimaRevisao { get; set; }
    }
}