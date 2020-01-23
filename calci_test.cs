using Microsoft.VisualStudio.TestTools.UnitTesting;

using Calculatorprogram;
namespace Calculatortestprogram
{
    [TestClass]
    public class Calculatortestclass
    {
      
        [TestMethod]
        public void Addmethodcheck()
        {
            Calculatorclass calculator = new Calculatorclass();
            int res;
            res = calculator.Add(5, 2);
            Assert.AreEqual(7, res);
        }

        [TestMethod]
        public void Submethodcheck()
        {
            Calculatorclass calculator = new Calculatorclass();
            int res;
            res = calculator.Subtract(7, 2);
            Assert.AreEqual(5, res);
        }
       [TestMethod]
        public void Multiplymethodcheck()
        {
            Calculatorclass calculator = new Calculatorclass();
            int res;
            res = calculator.Multiply(16, 2);
            Assert.AreEqual(32, res);
        }
        [TestMethod]
        public void Divisonmethodcheck()
        {
            Calculatorclass calculator = new Calculatorclass();
            //int res;
            Assert.ThrowsException<System.ArithmeticException>(() => calculator.Divide(5,0));         
        }
    }
}
