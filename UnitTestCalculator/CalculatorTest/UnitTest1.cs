using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class calcTest
    {
        [TestMethod]
        public void Test_Add()
        {
            //Arrange
            double first = 50;
            double second = 10;
            double expected = 60;

            //Act
           double actual = calc.Calculator.Add(first, second);

            //Assert
            Assert.AreEqual(expected, actual);
           
        }

        [TestMethod]
        public void Test_Subtract()
        {
            //Arrange
            double first = 50;
            double second = 10;
            double expected = 40;

            //Act
            double actual = calc.Calculator.Subtract(first, second);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_Multiply()
        {
            //Arrange
            double first = 50;
            double second = 10;
            double expected = 500;

            //Act
            double actual = calc.Calculator.Multiply(first, second);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_Divide()
        {
            //Arrange
            double first = 50;
            double second = 10;
            double expected = 5;

            //Act
            double actual = calc.Calculator.Divide(first, second);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_Square()
        {
            //Arrange
            double first = 5;
            double expected = 25;

            //Act
            double actual = calc.Calculator.Square(first);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_Root()
        {
            //Arrange
            double first = 100;
            double expected = 10;

            //Act
            double actual = calc.Calculator.Root(first);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
