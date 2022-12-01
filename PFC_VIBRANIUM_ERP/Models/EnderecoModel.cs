using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class EnderecoModel
    {
        public string tipo { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public int id { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public int descricao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string cep { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string endereco { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public int numero { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string bairro { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string cidade { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string contato { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string telefone { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string email { get; set; }
        
    }
}
