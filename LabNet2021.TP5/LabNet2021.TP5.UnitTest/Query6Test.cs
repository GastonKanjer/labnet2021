using LabNet.TP5.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP5.UnitTest
{
    class Query6Test
    {
        MyQueries queries = new MyQueries();
        
        [TestMethod]

        public void Query_ShouldReturnNotNull()
        {
            var p = queries.Query6();

            Assert.IsNotNull(p);

        }
    }


}
