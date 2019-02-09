using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP_NT_Taller_Meacanico;

namespace TP_NT_Taller_Meacanico.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            /**
             * El precio por hora invertida es de $300 para cualquier repuesto
             * El calculo final es [(cantidadHoras * precio) + (precioRep * cantRep)]
             */
            ViewBag.Message = "Your application description page.";

            // esto obtiene el objetito de conexion a la db, se abre una nueva conexion por request
            var db = new Models

            // esto es para guardar cualquier cambio realizado 
            //db.SaveChanges();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}