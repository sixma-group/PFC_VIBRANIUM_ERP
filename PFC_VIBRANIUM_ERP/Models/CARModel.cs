using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class CARModel
    {
        public int idCli { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public DateTime dtTransacao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string especie { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string serie { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string titulo { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string valorTitulo { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public DateTime dtVencimento { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public DateTime dtEmissao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string moeda { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public int parcela { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string status { get; set; }

    }
}

