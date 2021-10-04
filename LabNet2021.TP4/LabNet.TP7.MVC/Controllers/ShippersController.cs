using LabNet.TP4.Entitites;
using LabNet.TP4.Logic;
using LabNet.TP7.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabNet.TP7.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic logic = new ShippersLogic();

        // GET: Shippers
        public ActionResult Index()
        {
            List<ShippersDto> shippers = logic.GetAll();

            List<ShippersView> shippersViews = shippers.Select(s => new ShippersView
            {
                Id = s.ShipperID,
                Name = s.CompanyName,
                Phone = s.Phone

                }).ToList();

            return View(shippersViews);
        }

        public ActionResult Insert()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Insert(ShippersView shippersView)
        {
            try
            {
                ShippersDto shipperEntity = new ShippersDto { CompanyName = shippersView.Name, Phone = shippersView.Phone };

                logic.Add(shipperEntity);
    
            return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index","Error");
            }
        }
        public ActionResult Delete(int id)
        {
            logic.Delete(id);

            return RedirectToAction("Index");
        }


        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(ShippersView shippersView)
        {
            try
            {

                ShippersDto updatedShipper = new ShippersDto
                {
                    ShipperID = shippersView.Id,
                    CompanyName = shippersView.Name,
                    Phone = shippersView.Phone
                };

                logic.Update(updatedShipper);
                
                
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index", "Error");
            }
        }
    }

}