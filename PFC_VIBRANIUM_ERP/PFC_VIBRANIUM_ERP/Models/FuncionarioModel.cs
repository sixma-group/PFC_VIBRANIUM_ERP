using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class FuncionarioModel
    {
        public int id{ get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int nomeFuncionario { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int dtAdmissao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int dtTermino { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int dtDesligamento { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int cargo { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public double salario { get; set; }
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


        //Financeiro
        public string pagamento { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string banco { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string agencia { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string conta { get; set; }
    }
}
