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
            /**
             * El precio por hora invertida es de $300 para cualquier repuesto
             * El calculo final es [(cantidadHoras * precio) + (precioRep * cantRep)]
             */
            // esto obtiene el objetito de conexion a la db, se abre una nueva conexion por request
            var db = new Models.ProyectoORTEntities3();

            var dbName = db.Mechanical_Workshop.First().name;
            var clients = db.Clients.ToList();
            // esto es para guardar cualquier cambio realizado 
            //db.SaveChanges();

            var model = new Models.WorkshopIndex
            {
                name = dbName,
                clients = clients
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