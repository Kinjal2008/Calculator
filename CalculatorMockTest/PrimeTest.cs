using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMockTest
{
    [TestClass]
    public class PrimeTest
    {
        [TestMethod]
        public void Test_PrimeNumber()
        {
            //Arrange
            PrimeNumber pn = new PrimeNumber();

            //Act
            var result = pn.findPrimeNumber(4);

            //Assert
            Assert.AreEqual(7, result);
        }
    }
}
