using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class OPModel
    {
        [Key()]
        public int idOp { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int quantidade { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string status { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string descricao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string roteiro { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public DateTime dtEmissao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public DateTime dtTermino { get; set; }


        //Produto Vinculo FK
        [ForeignKey("ProdutoModel")]
        public int idProd { get; set; }
        public virtual ProdutoModel produto { get; set; }


    }
}
