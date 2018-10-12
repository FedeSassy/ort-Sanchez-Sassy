using System.Web;
using System.Web.Mvc;

namespace TP_NT_Taller_Meacanico
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
