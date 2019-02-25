using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP_NT_Taller_Meacanico.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult OrderForm()
        { 

            return View();
        }
    }
}