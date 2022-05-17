using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CalculatorMockTest
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void Test_Add()
        {
            //Arrange
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Add(2, 2)).Returns(4);

            //Act
            var result = calculator.Object.Add(2, 2);

            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Test_Sub()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Subtract(2, 2)).Returns(0);
            Assert.AreEqual(0, calculator.Object.Subtract(2, 2));
        }

        [TestMethod]
        public void Test_Multiply()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Multiply(2, 3)).Returns(6);
            Assert.AreEqual(6, calculator.Object.Multiply(2, 3));
        }

        [TestMethod]
        public void Test_Division()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Divide(2, 2)).Returns(1);
            Assert.AreEqual(1, calculator.Object.Divide(2, 2));
        }

        [TestMethod]
        public void Test_DivisionByZero()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Divide(2, 0)).Returns(0);
            Assert.AreEqual(0, calculator.Object.Divide(2, 0));
        }
    }
}
