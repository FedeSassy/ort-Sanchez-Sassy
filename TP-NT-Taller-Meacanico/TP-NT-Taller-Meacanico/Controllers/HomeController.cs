using System.Web.Mvc;
using TP_NT_Taller_Meacanico.Models;
using System.Collections.Generic;
using System.Linq;

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

        [HttpGet]
        public ActionResult OrderClose(int orderID)
        {
            List<AutoPartsOrderWrapper> oa = dbObject.GetAllAutopartsByOrderID(orderID);
            decimal totalPrice = 0;

            if (oa != null && oa.Count() > 0)
            {
                foreach (AutoPartsOrderWrapper apow in oa)
                {
                    totalPrice += CalculatePricePerAutopart(apow.hours, apow.price, apow.quantity);
                }

                int statusResponse = dbObject.CloseOrderByID(orderID, totalPrice);
                string dateEnded = Models.Utils.Util.GetSimpleDate(Models.Utils.Util.GetCurrentTime());

                if (statusResponse != 0)
                {
                    var response = new
                    {
                        order_id = orderID,
                        total_price = totalPrice,
                        date_ended = dateEnded
                    };

                    return Json(response, JsonRequestBehavior.AllowGet);
                }
            }

            var errorResponse = new
            {
                message = "An error ocurred while trying to close the order from the database, please try again later"
            };

            return Json(errorResponse, JsonRequestBehavior.DenyGet);
        }

        private decimal CalculatePricePerAutopart(int hours, decimal price, int quantity)
        {
            return ((hours * price) + (price * quantity));
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