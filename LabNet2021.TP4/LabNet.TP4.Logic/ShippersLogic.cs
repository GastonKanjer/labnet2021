using LabNet.TP4.Data;
using LabNet.TP4.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet.TP4.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<ShippersDto, int>
    {
        public List<ShippersDto> GetAll()
        {
            try
            {
                var shippers = (from s in context.Shippers
                                select new ShippersDto
                                {
                                    ShipperID = s.ShipperID,
                                    CompanyName = s.CompanyName,
                                    Phone = s.Phone
                                }).ToList();
                return shippers;
            }

            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ShippersDto GetOne(int id)
        {
            try
            {
                Shippers shipper = context.Shippers.Find(id);
                ShippersDto ship = new ShippersDto
                {
                    ShipperID = shipper.ShipperID,
                    CompanyName = shipper.CompanyName,
                    Phone = shipper.Phone
                };

                return ship;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void Add(ShippersDto newShipper)
        {
            try
            {
                Shippers shipper = new Shippers
                {
                    ShipperID = newShipper.ShipperID,
                    CompanyName = newShipper.CompanyName,
                    Phone = newShipper.Phone
                };

                context.Shippers.Add(shipper);
                context.SaveChanges();
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var shipperToDelete = context.Shippers.Single(s => s.ShipperID == id);

                context.Shippers.Remove(shipperToDelete);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Update(ShippersDto shipper)
        {
            try
            {
                var shipperUpdate = context.Shippers.Find(shipper.ShipperID);

                shipperUpdate.CompanyName = shipper.CompanyName;
                shipperUpdate.Phone = shipper.Phone;

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
