using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class ProdutoModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string nome { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public double preco { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string item { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string estoque { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string descricao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public double precoEstoque { get; set; }
        
    }
}
