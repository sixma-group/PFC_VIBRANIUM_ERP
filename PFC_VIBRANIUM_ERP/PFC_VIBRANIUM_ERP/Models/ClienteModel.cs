using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Models
{
    public class ClienteModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Favor insira a informação")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        [EmailAddress(ErrorMessage = "Favor inserir um email valido")]
        public string email { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        [Phone(ErrorMessage = "Favor inserir um telefone valido")]
        public string telefone { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string veiculo { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string placa { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string modelo { get; set; }
        [Required(ErrorMessage = "Favor insira a informação")]
        public string cor { get; set; }
    }
}
