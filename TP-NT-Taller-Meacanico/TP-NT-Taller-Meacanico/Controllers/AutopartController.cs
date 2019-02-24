using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP_NT_Taller_Meacanico.Models;

namespace TP_NT_Taller_Meacanico.Controllers
{
    public class AutopartController : Controller
    {
        private DBWrapper dbWrapper = new DBWrapper();

        [HttpGet]
        public ActionResult AutoPartEdit(int orderID)
        {
            List<AutoPartsOrderWrapper> aoList = dbWrapper.GetAllAutopartsByOrderID(orderID);

            var model = new AutopartsOrderInfo
            {
                orderID = orderID,
                apo = aoList
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult AutopartForm(int orderID)
        {
            List<Autopart> autoparts = dbWrapper.GetAllAutoparts();

            var model = new AutopartsOrderInfo
            {
                orderID = orderID,
                autoparts = autoparts
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult AutopartAdd(int orderID, int autopartID, int hours, int quantity)
        {
            Order_Autopart oa = new Order_Autopart
            {
                order_id = orderID,
                autopart_id = autopartID,
                hours = hours,
                quantity = quantity
            };

            dbWrapper.AddAutoPartOrder(oa);

            return RedirectToAction("AutoPartEdit", new { orderID = orderID });
        }
    }
}