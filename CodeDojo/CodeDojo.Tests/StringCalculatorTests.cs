using System;
using System.CodeDom;
using NUnit.Core;
using NUnit.Framework;
using CodeDojo.Kata;

namespace CodeDojo.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void GivenAnEmptyStringShouldReturnZero()
        {
            var calculator = new StringCalculator();
            var expected = 0;

            Assert.AreEqual(expected, calculator.Add(string.Empty));
        }

        [Test]
        public void GivenASingleNumberShouldReturnNumber()
        {
            var calculator = new StringCalculator();
            var expected = 1;

            Assert.AreEqual(expected, calculator.Add("1"));
        }

        [Test]
        public void GivenTwoNumbersShouldReturnTheSumOfBothNumbers()
        {
            var calculator = new StringCalculator();
            var expected = 3;

            Assert.AreEqual(expected, calculator.Add("1,2"));
        }

        [Test]
        public void GivenMultipleNumbersShouldReturnSumOfAllNumbers()
        {
            var calculator = new StringCalculator();
            var expected = 6;

            Assert.AreEqual(expected, calculator.Add("1,2,3"));
        }

        [Test]
        public void GivenNewLineAsDelimeterShouldReturnSumOfAllNumbers()
        {
            var calculator = new StringCalculator();
            var expected = 6;

            Assert.AreEqual(expected, calculator.Add("1\n2\n3"));
        }

        [Test]
        public void GivenConsecutiveDelimetersShouldThrowException()
        {
            var calculator = new StringCalculator();
            var expected = -1;

            Assert.Throws(typeof(ArgumentException), () => calculator.Add(",,"));
        }

        [Test]
        public void GivenANegativeNumberShouldReturnThrowAnException()
        {
            var calculator = new StringCalculator();
            var expected = -1;

            Assert.Throws(typeof(ArgumentOutOfRangeException), () => calculator.Add("-1,2"));

        }

        [Test]
        public void NegativeNumberErrorMessageShouldContainNegativeNumber()
        {
            var calculator = new StringCalculator();

            var error = Assert.Throws(typeof(ArgumentOutOfRangeException), () => calculator.Add("-1,2"));
            Assert.True(error.Message.Contains("-1"));
        }

    }
}
