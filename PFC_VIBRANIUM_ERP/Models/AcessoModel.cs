using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class AcessoModel
    {
        [Key()]
        public int idUsr { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string nome_user { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string login { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string senha { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string nivel { get; set; }

        //Endereço Vinculo FK
        [ForeignKey("FuncionarioModel")]
        public int idFunc { get; set; }
        public virtual FuncionarioModel funcionario { get; set; }

    }
}
