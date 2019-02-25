using System;

namespace TP_NT_Taller_Meacanico.Models.Utils
{
    public static class Util
    {
        public static DateTime GetCurrentTime()
        {
            DateTime dt = DateTime.Now;
            DateTime today = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, 0);
            return today;
        }

        public static string GetSimpleDate(DateTime? date)
        {
            if (date == null)
            {
                return "Not finished";
            }

            return String.Format("{0}/{1}/{2}", date?.Month, date?.Day, date?.Year);
        }
    }
}