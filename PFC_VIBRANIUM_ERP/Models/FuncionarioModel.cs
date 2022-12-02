using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class FuncionarioModel
    {
        [Key()]
        public int idFunc { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string nomeFuncionario { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public DateTime dtAdmissao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public DateTime dtTermino_contrato { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public DateTime? dtDesligamento { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string cargo { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public double salario { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]


        //Financeiro
        public string forma_pagamento { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string banco { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string agencia { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string conta { get; set; }


        //Endereço Vinculo FK
        [ForeignKey("EnderecoModel")]
        public int idEnd { get; set; }
        public virtual EnderecoModel endereco { get; set; }
    }
}
