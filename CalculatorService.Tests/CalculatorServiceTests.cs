using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests_HW;
using NUnit;
using NUnit.Framework;

namespace CalculatorService.Tests
{
    [TestFixture]
    public class CalculatorServiceTests
    {
        [Test]
       public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(5,5) == 10);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue() 
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(10, 5) == 5);
        }
        [Test]

        public void MultiplicationMustReturnCorrectValue() 
        {  
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(10, 3) == 30);
        }
        [Test]

        public void DivisionMustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(12, 3) == 4);
        }

    }
}
