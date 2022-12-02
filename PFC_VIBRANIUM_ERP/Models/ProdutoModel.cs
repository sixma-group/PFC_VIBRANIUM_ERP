using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class ProdutoModel
    {
        [Key()]
        public int idProd { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string nome { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public double valor_aquisicao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public double preco_saida { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string itens { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string descricao { get; set; }

        //Item Vinculo FK
        [ForeignKey("EstoqueModel")]
        public int idItem { get; set; }
        public virtual EstoqueModel item { get; set; }

    }
}
