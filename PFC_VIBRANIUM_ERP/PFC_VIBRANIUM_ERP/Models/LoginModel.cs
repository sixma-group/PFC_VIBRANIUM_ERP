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

        public int nome { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int login { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int senha { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]

        public int nivel { get; set; }
        
    }
}
