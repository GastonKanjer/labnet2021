using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabNet.TP4.Data;
using LabNet.TP4.Logic;
using LabNet.TP4.Entitites;


namespace LabNet.TP4.UnitTest
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]

        public void GetAll_Test()
        {
            //Arrange

            List<string> primero = new List<string>();
            List<string> segundo = new List<string>();


            //Act

            
            primero.Add("a");
            segundo.Add("b");


            //Assert

            CollectionAssert.AreEqual(primero, segundo);

        }

        public class FakeShippersRepository : IABMLogic<Shippers>
        {
            public void Add(Shippers obj)
            {
                throw new NotImplementedException();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public List<Shippers> GetAll()
            {
                return new List<Shippers>
           {
              new Shippers { CompanyName = "Mercado Libre" },
              new Shippers { CompanyName = "Amazon" }
           };
     }

            public void Update(Shippers obj)
            {
                throw new NotImplementedException();
            }
        }

/*
        [TestMethod]
       public void IndexGetsAllShippers()
        {
            //Arrange 
            var fakeShipperRepo = new FakeShippersRepository();
            var shippersController = new ShippersController(fakeProductRepo);

            //Act
            var result = productsController.Index(1) as ViewResult;

            //Assert
            var model = result.Model as List<Shippers>;
            Assert.AreEqual(2, model.Count);
        }
*/

    }
}
