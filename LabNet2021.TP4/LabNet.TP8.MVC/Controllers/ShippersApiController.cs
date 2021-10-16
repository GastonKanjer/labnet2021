using LabNet.TP4.Entitites;
using LabNet.TP4.Logic;
using LabNet.TP8.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace LabNet.TP8.MVC.Controllers
{
    public class ShippersApiController : ApiController
    {
        public ShippersLogic logic = new ShippersLogic();
        // GET: ShippersApi

        [HttpGet]
        public List<ShippersResponse> Get()
        {

                List<ShippersResponse> shippersRespon;
                List<ShippersDto> shippers = logic.GetAll();

                shippersRespon = shippers.Select(s => new ShippersResponse
                {
                    ShipperID = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone

                }).ToList();

                return shippersRespon;
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                List<ShippersDto> shippers = logic.GetAll();
                ShippersDto shipperToMap = shippers.Find(s => s.ShipperID == id);

                if (shipperToMap==null)
                {
                    return NotFound();
                }

                else
                {
                    ShippersResponse shippersRespon = new ShippersResponse
                    {
                        ShipperID = shipperToMap.ShipperID,
                        Phone = shipperToMap.Phone,
                        CompanyName = shipperToMap.CompanyName
                    };

                    return Ok(shippersRespon);
                }
            }
            catch (Exception e)
            {

                return InternalServerError(e);
            }
        }


        [HttpPost]
        public IHttpActionResult Add([FromBody]ShippersRequest shippersReq)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    ShippersDto shipperToIns = new ShippersDto
                    {
                        ShipperID = shippersReq.ShipperID,
                        Phone = shippersReq.Phone,
                        CompanyName = shippersReq.CompanyName
                    };

                    logic.Add(shipperToIns);

                    return Ok(shipperToIns);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {

                return InternalServerError(e);
            }
        }

        [HttpPut]
        public IHttpActionResult Update(int id, [FromBody] ShippersRequest shippersReq)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool shipperExist = logic.GetAll().Exists(s => s.ShipperID == id);

                    if (shipperExist)
                    {
                        ShippersDto updateShipper = new ShippersDto
                        {
                            ShipperID = shippersReq.ShipperID,
                            Phone = shippersReq.Phone,
                            CompanyName = shippersReq.CompanyName
                        };

                        logic.Update(updateShipper);

                        return Ok();
                    }
                    else
                    {
                        return NotFound();
                    }

                }

                else
                {
                    return BadRequest();
                }

            }

            catch (Exception e)
            {
                return InternalServerError(e);
            }

        }


        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var shipperToDelete = logic.GetAll().Find(s => s.ShipperID == id);
                if (shipperToDelete!=null)
                {
                    logic.Delete(id);

                    return Ok(shipperToDelete);
                }

                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {

                return InternalServerError(e);
            }
        }

    }
}