using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_NT_Taller_Meacanico.Models.CustomExceptionClasses
{
    public class OrdenTrabajoNotFoundException : Exception
    {
        public OrdenTrabajoNotFoundException() { }

        public OrdenTrabajoNotFoundException(string message) : base(message) { }

        public OrdenTrabajoNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}