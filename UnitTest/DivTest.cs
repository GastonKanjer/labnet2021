using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TP2;


namespace UnitTest
{
    [TestClass]
    public class DivTest
    {
       [DataRow(10,2,5)]
        [TestMethod]
        public void DivisionEntreDosNumeros(int divid, int divis, int deseado)
        {
            //Arrange

            //Act

            double resul = OperacionesExtension.Dividir(divid, divis);

            //Assert
            Assert.AreEqual(resul, deseado);

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]

        public void DivisionPorCero()
        {
            //Arrange

            int divid = 1;
            int divis = 0;

            //Act

            double resul = OperacionesExtension.Dividir(divid, divis);

            //Assert
        }
    }
}
