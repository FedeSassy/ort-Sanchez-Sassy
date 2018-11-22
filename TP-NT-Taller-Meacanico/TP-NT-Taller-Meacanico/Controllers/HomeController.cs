using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
             * TODO el precio por hora invertida es de $300 para cualquier repuesto
             * El calculo final es [(cantidadHoras * precio) + (precioRep * cantRep)]
             */
            ViewBag.Message = "Your application description page.";

            var db = new Models.ProyectoORTEntities1();
            db.SaveChanges();
           
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}