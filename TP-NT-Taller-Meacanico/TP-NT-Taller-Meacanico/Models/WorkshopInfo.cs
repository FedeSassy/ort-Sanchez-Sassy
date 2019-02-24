using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_NT_Taller_Meacanico.Models
{
    public class WorkshopInfo
    {
        public string name { get; set; }
        public List<Order> orders { get; set; }
        public List<Client> clients { get; set; }
    }
}