using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class PedidoModel
    {
        [Key()]
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

        //Cliente Vinculo FK
        [ForeignKey("ClienteModel")]
        public int? idCli { get; set; }
        public virtual ClienteModel cliente { get; set; }

        //Fornecedor Vinculo FK
        [ForeignKey("FornecedorModel")]
        public int? idForn { get; set; }
        public virtual FornecedorModel fornecedor { get; set; }


    }
}
