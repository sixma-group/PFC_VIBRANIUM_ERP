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

        public int idfederal { get; set; }
        [Required(ErrorMessage = "Favor informe o CPF ou CNPJ")]

        public string abrev { get; set; }
        [Required(ErrorMessage = "Favor informe o nome abreviado")]


        //Financeiro
        public string pagamento { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string banco { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string agencia { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string conta { get; set; }

        //Endereço Vinculo FK
        public int idEnd { get; set; }

    }
}
