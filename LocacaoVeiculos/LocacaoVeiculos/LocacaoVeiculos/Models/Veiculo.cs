using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocacaoVeiculos.Models
{
    public class Veiculo
    {
        [Key]
        [Required(ErrorMessage = "Identificação é obrigatória")]
        [DisplayName("Veiculo")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Marca é obrigatório")]
        [DisplayName("Marca")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Modelo é obrigatório")]
        [DisplayName("Modelo")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Placa é obrigatório")]
        [StringLength(7, ErrorMessage = "Maximo de 7 caraceteres")]
        [DisplayName("Placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Valor na Tabela Fipe é obrigatóriao")]
        [Range(10, int.MaxValue, ErrorMessage = "Valor inválido")]
        [DisplayName("Valor na Tabela Fipe")]
        public decimal ValorFipe { get; set; }

        [Required(ErrorMessage = "Valor de Locação é obrigatóriao")]        
        [DisplayName("Valor da Locacao")]
        public decimal ValorLocacao { get; set; }

        [Required(ErrorMessage = "Ano de Fabricacao é obrigatório")]      
        [DisplayName("Ano de Fabricação")]        
        public DateTime AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Ultima Revisao é obrigatório")]        
        [DisplayName("Ultima Revisão")]
        public DateTime UltimaRevisao { get; set; }
    }
}