using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using CalculatorProgram;

namespace PracticeNUnitProject
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        [TestCase(12, 12, 24)]
        [TestCase(24, 24, 48)]
        [TestCase(12, 10, 22)]
        public void AddMethodTestCase(double firstnumber, double secondnumber, double expectedresult)
        {
            Calc calculator = new Calc();
            calculator.SetFirstNumber(firstnumber);
            calculator.SetSecondNumber(secondnumber);
            double ResultOfTwo = calculator.GetAddition();         
            NUnit.Framework.Assert.AreEqual(ResultOfTwo, expectedresult);

        }
        [Test]
        [TestCase(21, 10, 11)]
        [TestCase(20, 19, 1)]
        [TestCase(12, 12, 0)]

        public void SubtractMethodTestCase(double firstnumber, double secondnumber, double expectedresult)
        {
            Calc calculator = new Calc();
            calculator.SetFirstNumber(firstnumber);
            calculator.SetSecondNumber(secondnumber);
            double ResultOfTwo = calculator.GetSubtraction();
            NUnit.Framework.Assert.AreEqual(ResultOfTwo, expectedresult);

        }

        [Test]
        [TestCase(21, 10, 210)]
        [TestCase(20, 19, 380)]
        [TestCase(12, 12, 144)]

        public void MultiplicationMethodTestCase(double firstnumber, double secondnumber, double expectedresult)
        {
            Calc calculator = new Calc();
            calculator.SetFirstNumber(firstnumber);
            calculator.SetSecondNumber(secondnumber);
            double ResultOfTwo = calculator.GetMultiplication();
            NUnit.Framework.Assert.AreEqual(ResultOfTwo, expectedresult);

        }

        [Test]
        [TestCase(20, 10, 2)]
        [TestCase(20, 2, 10)]
        [TestCase(12, 12, 1)]
        [TestCase(1, 3, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(9, 3, 3)]

        public void DivisionMethodTestCase(double firstnumber, double secondnumber, double expectedresult)
        {
            Calc calculator = new Calc();
            calculator.SetFirstNumber(firstnumber);
            calculator.SetSecondNumber(secondnumber);
            double ResultOfTwo = calculator.GetDivision();
            NUnit.Framework.Assert.AreEqual(ResultOfTwo, expectedresult);

        }

    }
}
