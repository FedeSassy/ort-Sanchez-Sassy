using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_NT_Taller_Meacanico.Models.Utils
{
    public static class Util
    {
        public static string GetCurrentTime()
        {
            DateTime dt = DateTime.Now;
            DateTime today = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, 0);
            return today.ToString();
        }
    }
}