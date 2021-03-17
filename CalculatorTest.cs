using System;
using NUnit.Framework;
namespace Nunit.Demo.Test
{
    
        [TestFixture]
        public class CalculatorTest
        {
        Calculator calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            calc.Dispose();
        }


        [Test, Order(2)]
        public void Test_Addition_With_Valid_Integers()
        {
            //var calc = new Calculator();
            var result = calc.Addition(3, 5);
            //Verify the result by using the assert class and changing the expected result
            Assert.AreEqual(8, result);//success
                                       // Assert.AreEqual(9, result);//failure
        }
        [Test, Order(1)]
        public void Test_Subtraction_Argument_Exception()
        {
            //var calc = new Calculator();
            Assert.Catch<ArgumentException>(() => calc.Subtraction(4, 5));//success
                                                                          // Assert.Catch<ArgumentException>(() => calc.Subtraction(4, 3));//failure

        }
        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 4, 7)]
        public void Test_Addition_Multiple(int first, int second, int expectedresult)
        {
            var calc = new Calculator();
            var calculated = calc.Addition(first, second);
            Assert.AreEqual(expectedresult, calculated);

        }





        [Ignore("Ignore test")]
            public void Test_To_Ignore()
            {

            }

        }
    }

