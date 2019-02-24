using System.Web.Mvc;
using TP_NT_Taller_Meacanico.Models;

namespace TP_NT_Taller_Meacanico.Controllers
{
    public class HomeController : Controller
    {
        private DBWrapper dbObject = new DBWrapper();

        public ActionResult Index()
        {
            /**
             * El precio por hora invertida es de $300 para cualquier repuesto
             * El calculo final es [(cantidadHoras * precio) + (precioRep * cantRep)]
             */
            // esto obtiene el objetito de conexion a la db, se abre una nueva conexion por request
            //var db = new Models.ProyectoORTEntities3();

            var model = new WorkshopInfo
            {
                name = dbObject.GetWorkShopName(),
                orders = dbObject.GetAllOrders()
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}