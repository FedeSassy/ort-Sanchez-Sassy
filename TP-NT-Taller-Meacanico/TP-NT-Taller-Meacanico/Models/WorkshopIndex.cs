using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_NT_Taller_Meacanico.Models
{
    public class WorkshopIndex
    {
        public string name { get; set; }
        public List<Client> clients { get; set; }
    }
}