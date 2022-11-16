using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class LoginModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string nome { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string login { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string senha { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public string nivel { get; set; }
        
    }
}
