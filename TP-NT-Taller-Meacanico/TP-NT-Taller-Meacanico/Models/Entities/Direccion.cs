using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_NT_Taller_Meacanico.Models.Entities
{
    public class Direccion
    {
        private string provincia { get; set; }
        private string direccion { get; set; }

        public Direccion(string direccion, string provincia)
        {
            this.direccion = direccion;
            this.provincia = provincia;
        }

        // aca la misma validacion que en Cliente
    }
}