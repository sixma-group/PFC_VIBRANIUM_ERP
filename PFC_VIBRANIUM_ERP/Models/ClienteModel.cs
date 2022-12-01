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


        //Financeiro
        public string recebimento { get; set; }
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
