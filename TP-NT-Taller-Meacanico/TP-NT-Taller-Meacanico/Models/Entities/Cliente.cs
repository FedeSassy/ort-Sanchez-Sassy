using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_NT_Taller_Meacanico.Models.Entities
{
    public class Cliente
    {
        // esto va a estar comentado hasta que decida si lo genero yo el ID o desde el server
        //private static int genericId = 0;
        // esto ID probablemente no tenga que estar
        private int id { get; }
        private int dni { get; set; }
        private string nombre { get; }
        private Direccion direccion { get; set; }

        public Cliente(int id, string nombre, Direccion dir)
        {
            this.id = id;
            this.nombre = nombre;
            direccion = dir;
        }

        // en java tengo una validacion al setear nombre y dni que era para cuando querias modificar
        // el campo, si era -1 entonces no se modificaba
    }
}