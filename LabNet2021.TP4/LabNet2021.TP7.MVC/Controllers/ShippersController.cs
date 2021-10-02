using LabNet.TP4.Entitites;
using LabNet.TP4.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabNet.TP7.MVC.Controllers
{
    public class ShippersController : Controller
    {
        // GET: Shippers
        public ActionResult Index()
        {
            var logic = new ShippersLogic();
            List<ShippersDto> shippers = logic.GetAll();
            return View(shippers);
        }
    }
}