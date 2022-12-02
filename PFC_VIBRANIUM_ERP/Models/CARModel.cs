﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class CARModel
    {

        [Key()]
        public int idRefCAR { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public DateTime dtTransacao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string especie { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string serie { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string titulo { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public double valor { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public DateTime dtVencimento { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public DateTime dtEmissao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string moeda { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public int? parcela { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string status { get; set; }

        //Fornecedor Vinculo FK
        [ForeignKey("ClienteModel")]
        public int idCli { get; set; }
        public virtual ClienteModel cliente { get; set; }

    }
}

