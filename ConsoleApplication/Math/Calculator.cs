using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using OpenQA.Selenium;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;
using System.Configuration;

namespace Math
{
    public class Calculator 
    {
      public  long Sum(long firstNumber,long secondNumber)
        { 
            return (firstNumber + secondNumber);
        }

        public long Subtraction(long firstNumber, long secondNumber)
        {
            return (firstNumber - secondNumber);
        }

        public long Multiplication(long firstNumber, long secondNumber)
        {
            return (firstNumber * secondNumber);
        }

        public double Division(double firstNumber, double secondNumber)
        {
            try
            {
                return (firstNumber / secondNumber);
            }
            catch (ArithmeticException)
            {
                return  double.PositiveInfinity;
            }

        }

    }
}
