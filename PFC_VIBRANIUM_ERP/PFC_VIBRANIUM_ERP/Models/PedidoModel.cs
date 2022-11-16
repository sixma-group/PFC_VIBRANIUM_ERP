using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class PedidoModel
    {
        public int idPed { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string tipo { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string produtos { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public DateTime dtPedido { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int quantidade { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public double valor { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string status { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int idCli { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int idForn { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        //Endereço
        public string descricao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string cep { get; set; }
        [Required(ErrorMessage = "Favor informe o CEP")]

        public int numero { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string bairro { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string cidade { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string contato { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string telefone { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string email { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
    }
}
