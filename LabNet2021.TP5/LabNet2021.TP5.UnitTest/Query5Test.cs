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
    public class Query5Test
    {
        MyQueries queries = new MyQueries();
        [TestMethod]

        public void Query_ShouldReturnNotNull()
        {
            var p = queries.Query5();

            Assert.IsNotNull(p);

        }
        [TestMethod]

        public void Query_IdEquals789()
        {
            var p = queries.Query5();
            Assert.IsTrue(p.ProductID == 789);
        }
    }
}
