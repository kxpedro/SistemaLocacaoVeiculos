using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SLV.Models
{
    public class Veiculo
    {

        [Required(ErrorMessage = "Identificação do Veículo é obrigatória")]
        [DisplayName("Identificação do Veiculo")]
        public int IdVeiculo { get; set; }

        [Required(ErrorMessage = "Marca do Veiculo é obrigatório")]
        [DisplayName("Marca do Veiculo")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "IModelo do Veiculo é obrigatório")]
        [DisplayName("Modelo do Veiculo")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Placa do Veiculo é obrigatório")]
        [DisplayName("Placa do Veiculo")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Valor na Tabela Fipe do Veiculo é obrigatóriao")]
        [DisplayName("Valor na Tabela Fipe do Veiculo")]
        public double ValorFipe { get; set; }

        [Required(ErrorMessage = "Ano de Fabricacao do Veiculo é obrigatório")]
        [DisplayName("Ano de Fabricacao do Veiculo")]
        public DateTime AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Ultima Revisao do Veiculo é obrigatório")]
        [DisplayName("Ultima Revisao do Veiculo")]
        public DateTime UltimaRevisao { get; set; }
    }
}