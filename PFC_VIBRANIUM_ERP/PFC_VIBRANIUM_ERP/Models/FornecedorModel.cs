using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class FornecedorModel
    {

        public int idForn { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string nomefornecedor { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string pais { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string estado { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string pessoa { get; set; }
        [Required(ErrorMessage = "Favor informe o tipo da pessoa (Jurídica ou Física)")]

        public string idfederal { get; set; }
        [Required(ErrorMessage = "Favor informe o CPF ou CNPJ")]

        public string abrev { get; set; }
        [Required(ErrorMessage = "Favor informe o nome abreviado")]


        //ENDEREÇO
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
