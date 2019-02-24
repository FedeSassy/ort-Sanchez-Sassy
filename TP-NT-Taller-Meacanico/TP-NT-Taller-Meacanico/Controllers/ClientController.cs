using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TP_NT_Taller_Meacanico.Models;

namespace TP_NT_Taller_Meacanico.Controllers
{
    public class ClientController : Controller
    {
        private DBWrapper dbWrapper = new DBWrapper();

        public ActionResult ClientMenu()
        {
            ViewBag.Message = "This is the client menu";

            //List<Client> clients = dbWrapper.GetAllClients();
            // esto es para guardar cualquier cambio realizado 
            //db.SaveChanges();

            var model = new WorkshopIndex
            {
                clients = dbWrapper.GetAllClients()
            };

            return View(model);
        }

        public ActionResult AddClient()
        {
            ViewBag.Message = "This is the form to add a new client";

            return View();
        }

        [HttpPost]
        public void AddClientForm(Client client)
        {
            dbWrapper.AddClient(client);
        }

        [HttpGet]
        public ActionResult ClientRemove(int clientPersonalID)
        {
            int statusResponse = dbWrapper.RemoveClientByPersonalID(clientPersonalID);

            if (statusResponse == 1)
            {
                var response = new
                {
                    p_id = clientPersonalID
                };

                return Json(response, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var response = new
                {
                    message = "An error ocurred while trying to delete the client from the database, please try again later"
                };

                return Json(response, JsonRequestBehavior.DenyGet);
            }
        }
    }
}