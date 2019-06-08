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
        [DisplayName("Veiculo")]
        public int IdVeiculo { get; set; }

        [Required(ErrorMessage = "Marca do Veiculo é obrigatório")]
        [DisplayName("Marca")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Modelo do Veiculo é obrigatório")]
        [DisplayName("Modelo")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Placa do Veiculo é obrigatório")]
        [DisplayName("Placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Valor na Tabela Fipe do Veiculo é obrigatóriao")]
        [DisplayName("Valor na Tabela Fipe")]
        public double ValorFipe { get; set; }

        [Required(ErrorMessage = "Valor na Tabela Locacao do Veiculo é obrigatóriao")]
        [DisplayName("Valor na Locacao Fipe")]
        public double ValorLocacao { get; set; }

        [Required(ErrorMessage = "Ano de Fabricacao do Veiculo é obrigatório")]
        [DisplayName("Ano de Fabricação")]
        public DateTime AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Ultima Revisao do Veiculo é obrigatório")]
        [DisplayName("Ultima Revisão")]
        public DateTime UltimaRevisao { get; set; }
    }
}