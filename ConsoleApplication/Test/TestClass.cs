using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math;

namespace Test
{
    public class TestClass
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
        public class MyTestClass
        {
            int firstNumber = Int32.Parse(Resource.firstNumber);
            int secondNumber = Int32.Parse(Resource.secondNumber);

            Calculator calc = new Calculator();

            [TestMethod]
            public void TestCheckSum()
            {
                Assert.AreEqual(((long)firstNumber + (long)secondNumber), calc.Sum(firstNumber, secondNumber));
            }

            [TestMethod]
            public void TestCheckSubtraction()
            {
                Assert.AreEqual(((long)firstNumber - (long)secondNumber), calc.Subtraction(firstNumber, secondNumber));
            }

            [TestMethod]
            public void TestCheckMultiplication()
            {
                Assert.AreEqual(((long)firstNumber * (long)secondNumber), calc.Multiplication(firstNumber, secondNumber));
            }

            [TestMethod]
            public void TestCheckDivision()
            {
                Assert.AreEqual(((double)firstNumber / (double)secondNumber), calc.Division(firstNumber, secondNumber));
            }
        }
    }
}
