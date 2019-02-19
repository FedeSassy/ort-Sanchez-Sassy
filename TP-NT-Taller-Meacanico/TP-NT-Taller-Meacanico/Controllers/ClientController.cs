using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP_NT_Taller_Meacanico.Controllers
{
    public class ClientController : Controller
    {
        private Models.ProyectoORTEntities3 db = new Models.ProyectoORTEntities3();

        public ActionResult ClientMenu()
        {
            ViewBag.Message = "This is the client menu";
            var db = new Models.ProyectoORTEntities3();

            var clients = db.Clients.ToList();
            // esto es para guardar cualquier cambio realizado 
            //db.SaveChanges();

            var model = new Models.WorkshopIndex
            {
                clients = clients
            };

            return View(model);
        }

        public ActionResult AddClient()
        {
            ViewBag.Message = "This is the form to add a new client";

            return View();
        }

        [HttpPost]
        public void AddClientForm(Models.Client client)
        {
            client.workshop_id = 1;
            client.address_id = 4;

            db.Clients.Add(client);
            db.SaveChanges();
        }
    }
}