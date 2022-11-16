using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class ClienteModel
    {
        public int idCli { get; set; }

        [Required(ErrorMessage = "Favor insira a informação")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        [EmailAddress(ErrorMessage = "Favor inserir um email valido")]

        public string pais { get; set; }
        [Required(ErrorMessage = "Favor informe o país")]

        public string estado { get; set; }
        [Required(ErrorMessage = "Favor informe o estado")]


        public string pessoa { get; set; }
        [Required(ErrorMessage = "Informe o tipo da pessoa")]

        public string idfederal { get; set; }
        [Required(ErrorMessage = "Favor informe o CPF ou CNPJ")]
        

        public string abrev { get; set; }
        [Required(ErrorMessage = "Favor informe o nome abreviado")]

        //Endereço

        public string descricao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string cep { get; set; }
        [Required(ErrorMessage = "Favor informe o CEP")]

        public string numero { get; set; }
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
        public string recebimento { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string banco { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string agencia { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string conta { get; set; }

    }
}
