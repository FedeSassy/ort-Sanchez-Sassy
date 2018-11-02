using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
//using TP_NT_Taller_Meacanico.Models.Entities;

namespace TP_NT_Taller_Meacanico.Models.Entities
{
    public class TallerMecanico
    {
        private static TallerMecanico instance;
        private string nombre { get; set; }
        private ArrayList empleados { get; }
        private ArrayList clientes { get; }
        private ArrayList ordenes { get; }

        private TallerMecanico()
        {
            empleados = new ArrayList();
            clientes = new ArrayList();
            ordenes = new ArrayList();
            // generar/obtener instancia de conexion a base de datos
        }
     
        public TallerMecanico GetInstance()
        {
            if (instance == null)
            {
                instance = new TallerMecanico();
            }

            return instance;
        }

        //TODO esta clase hace un millon de cosas, tambien habia prints de tablas
    }
}