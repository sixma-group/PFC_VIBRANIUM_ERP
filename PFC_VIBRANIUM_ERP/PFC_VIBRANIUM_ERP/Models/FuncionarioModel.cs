using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class FuncionarioModel
    {
        public int id{ get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int nomeFuncionario { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int dtAdmissao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int dtTermino { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int dtDesligamento { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int cargo { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public double salario { get; set; }
        
    }
}
