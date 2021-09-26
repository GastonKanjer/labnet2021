using LabNet.TP5.Entities;
using LabNet.TP5.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP5.UnitTest
{
    [TestClass]
    public class Query1Test
    {
        MyQueries queries = new MyQueries();
        
        [DataRow("ALFKI")]
        [DataRow("ANATR")]
        [TestMethod]

        public void Query_ShouldReturnAnElement(string id)
        {
            //Arrange
            Customers c = queries.Query1(id);
            //Act

            //Assert
            Assert.IsNotNull(c);

        }
       
        [DataRow("HOLA")]
        [TestMethod]
        
        [ExpectedException(typeof(InvalidOperationException))]
        public void Query_ShouldNotFindAnElement(string id)
        {
            //Arrange
            Customers c = queries.Query1(id);
            //Act

            //Assert
            Assert.IsNotNull(c);

        }
    }
}
