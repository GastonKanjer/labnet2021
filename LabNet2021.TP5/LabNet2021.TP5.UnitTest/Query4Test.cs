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
    public class Query4Test
    {
        MyQueries queries = new MyQueries();

        [TestMethod]
        public void Query_ShouldReturnNotNullList()
        {
            var c = queries.Query4();

            Assert.IsNotNull(c);

        }

        [TestMethod]

        public void Query_ReturnsListEqualsWA()
        {
            var c = queries.Query4();
            foreach (var cust in c)
            {
                Assert.IsTrue(cust.Region =="WA");
            }
        }



    }
}
