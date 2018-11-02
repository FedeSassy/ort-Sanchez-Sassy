using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_NT_Taller_Meacanico.Models.Entities
{
    public class Repuesto
    {
        private int id { get; }
        private string nombre;
        private decimal precio;

        public Repuesto(string nombre, decimal precio)
        {
            //generar id
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}