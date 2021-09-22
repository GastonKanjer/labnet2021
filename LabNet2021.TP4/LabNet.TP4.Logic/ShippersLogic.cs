using LabNet.TP4.Data;
using LabNet.TP4.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet.TP4.Logic
{
    public class ShippersLogic: BaseLogic, IABMLogic<Shippers>
    {
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Add(Shippers newShipper)
        {
            context.Shippers.Add(newShipper);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shipperToDelete = context.Shippers.SingleOrDefault(s => s.ShipperID == id);

            context.Shippers.Remove(shipperToDelete);
            context.SaveChanges();
        }


        public void Update(Shippers shipper)
        {
            var shipperUpdate = context.Shippers.Find(shipper.ShipperID);

            shipperUpdate.CompanyName = shipper.CompanyName;
            shipperUpdate.Phone = shipper.Phone;

            context.SaveChanges();
        }

    }
}
