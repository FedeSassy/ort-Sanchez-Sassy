using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_NT_Taller_Meacanico.Models.CustomExceptionClasses
{
    public class ClientNotFoundException : Exception
    {
        public ClientNotFoundException() { }

        public ClientNotFoundException(string message) : base(message) { }

        public ClientNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}