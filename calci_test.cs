using Microsoft.VisualStudio.TestTools.UnitTesting;

using Calculator_d;
namespace Calci_test
{
    [TestClass]
    public class calci_test
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void add_check()
        {
            calcu_d obj = new calcu_d();
            int res;
            res = obj.add(5, 2);
            Assert.AreEqual(7, res);
        }

        [TestMethod]
        public void sub_check()
        {
            calcu_d obj = new calcu_d();
            int res;
            res = obj.subtract(7, 2);
            Assert.AreEqual(5, res);
        }
        public void mul_check()
        {
            calcu_d obj = new calcu_d();
            int res;
            res = obj.multiply(16, 2);
            Assert.AreEqual(32, res);
        }
        [TestMethod]
        public void div_check()
        {
            calcu_d obj = new calcu_d();
            //int res;
            Assert.ThrowsException<System.ArithmeticException>(() => obj.divide(5,0));         
        }
    }
}
