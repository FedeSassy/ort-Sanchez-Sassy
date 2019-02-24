//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TP_NT_Taller_Meacanico.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.Order_Autopart = new HashSet<Order_Autopart>();
        }
    
        public int id { get; set; }
        public System.DateTime date_created { get; set; }
        public Nullable<System.DateTime> date_ended { get; set; }
        public string state { get; set; }
        public int client_id { get; set; }
        public int employee_id { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string plate_number { get; set; }
        public string description { get; set; }
        public Nullable<decimal> total { get; set; }
        public int workshop_id { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Mechanical_Workshop Mechanical_Workshop { get; set; }
        public virtual ICollection<Order_Autopart> Order_Autopart { get; set; }
    }
}
