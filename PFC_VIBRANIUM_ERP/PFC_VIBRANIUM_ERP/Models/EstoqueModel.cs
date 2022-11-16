using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class EstoqueModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string nome { get; set; }
        [Required(ErrorMessage = "Favor informe o nome")]

        public string preco { get; set; }
        [Required(ErrorMessage = "Favor informe o preço")]

        public string marca { get; set; }
        [Required(ErrorMessage = "Favor informe a marca")]

        public string descricao { get; set; }
        [Required(ErrorMessage = "Favor informe a descrição")]

        public string quantidade { get; set; }
        
    }
}
