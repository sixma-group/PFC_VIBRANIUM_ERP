using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class EnderecoModel
    {
        [Key()]
        public int idEnd { get; set; }

        [Required(ErrorMessage = "Favor insira a informação")]
        public string tipo { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string? descricao { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string cep { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string endereco { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string numero { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string bairro { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string cidade { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string? contato { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string telefone { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string email { get; set; }
    }
}
