using PFC_VIBRANIUM_ERP.Models;
using System.Collections.Generic;

namespace PFC_VIBRANIUM_ERP.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteModel clienteModel { get; set; }
        public List<ClienteModel> listaClientes { get; set; }
    }
}
