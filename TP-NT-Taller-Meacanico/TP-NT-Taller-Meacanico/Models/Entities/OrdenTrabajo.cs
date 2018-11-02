using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP_NT_Taller_Meacanico.Models.Utils;

namespace TP_NT_Taller_Meacanico.Models.Entities
{
    public class OrdenTrabajo
    {
        //private static int genericId = 0;
        private int id { get; }
        private string fechaInicio { get; }
        private string fechaFin { get; set; }
        private Estado estado { get; set; }
        private int dniCliente { get; }
        private int dniEmpleado { get; }
        private string patente { get; }
        private string marca { get; }
        private string modelo { get; }
        private string descripcion { get; }
        private decimal total { get; set; }

        public OrdenTrabajo(int dniCliente, int dniEmpleado, string marca, string modelo, string patente, string description)
        {
            fechaInicio = Util.GetCurrentTime();
            estado = Estado.PEND;
            this.dniCliente = dniCliente;
            this.dniEmpleado = dniEmpleado;
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            descripcion = description;
        }
    }
}