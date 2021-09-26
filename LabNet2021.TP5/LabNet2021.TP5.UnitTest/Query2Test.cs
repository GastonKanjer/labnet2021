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
    public class Query2Test
    {
        MyQueries queries = new MyQueries();

        [TestMethod]

        public void Query_ShouldReturnNotNullList()
        {
            var p = queries.Query2();

            Assert.IsNotNull(p);

        }

        [TestMethod]

        public void Query_ReturnsListZeroStock()
        {
            var p = queries.Query2();

            foreach (var prod in p)
            {
                Assert.AreEqual(Convert.ToInt16(0), prod.UnitsInStock);
            }

        }

    }
}
