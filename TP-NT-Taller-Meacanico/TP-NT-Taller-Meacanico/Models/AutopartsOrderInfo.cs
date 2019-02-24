using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_NT_Taller_Meacanico.Models
{
    public class AutopartsOrderInfo
    {
        public int orderID { get; set; }
        public List<AutoPartsOrderWrapper> apo { get; set; }
        public List<Autopart> autoparts { get; set; }
    }
}