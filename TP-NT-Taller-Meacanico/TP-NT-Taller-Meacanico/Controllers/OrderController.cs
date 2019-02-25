using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP_NT_Taller_Meacanico.Models;

namespace TP_NT_Taller_Meacanico.Controllers
{
    public class OrderController : Controller
    {
        private DBWrapper dbWrapper = new DBWrapper();

        public ActionResult OrderForm()
        { 

            return View();
        }

        [HttpPost]
        public ActionResult OrderAdd(int clientPersonalID, string brand, string model, string plateNumber, string description)
        {
            Client client = dbWrapper.GetClientByPersonalID(clientPersonalID);
            if (client != null)
            {
                Order newOrder = new Order();
                newOrder.date_created = Models.Utils.Util.GetCurrentTime();
                newOrder.state = "PEND";
                newOrder.client_id = client.id;
                newOrder.employee_id = 2; //hacer un getRandomEmployee()
                newOrder.brand = brand;
                newOrder.model = model;
                newOrder.plate_number = plateNumber;
                newOrder.description = description;
                newOrder.workshop_id = 1;

                dbWrapper.AddOrder(newOrder);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}