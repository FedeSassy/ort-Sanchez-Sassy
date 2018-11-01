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
        private int id;
        private int dni;
        private string nombre;
        private Direccion direccion;

        public Cliente(int id, string nombre, Direccion dir)
        {
        	
        }
    }
}