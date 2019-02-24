using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_NT_Taller_Meacanico.Models
{
    public class AutoPartsOrderWrapper
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public int hours { get; set; }
        public int quantity { get; set; }
    }
}