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
    public class Query3Test
    {
        MyQueries queries = new MyQueries();

        [TestMethod]
        public void Query_ShouldReturnNotNullList()
        {
            var p = queries.Query3();

            Assert.IsNotNull(p);

        }
        
        [TestMethod]

        public void Query_ReturnsListDistincFromZero()
        {
            var p = queries.Query3();
            foreach (var prod in p)
            {
                Assert.IsTrue(0 != prod.UnitsInStock);
            }
        }

        public void Query_ReturnsListUnitPriceBiggerThan3()
        {
            var p = queries.Query3();
            foreach (var prod in p)
            {
                Assert.IsTrue(3 < prod.UnitsInStock);
            }
        }


    }
}
