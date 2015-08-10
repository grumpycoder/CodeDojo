using System.Security.Permissions;
using CodeDojo.Kata;
using NUnit.Framework;

namespace CodeDojo.Tests
{
    [TestFixture]
    public class OddEvenTests
    {
        [Test]
        public void ShouldPrintString1To10WithEvenAndOddAndNumberWhenPrime()
        {
            var oe = new OddEvener();

            var text = oe.Print(10); 

            Assert.That(text, Is.EqualTo("1 2 3 Even 5 Even 7 Even Odd Even "));

        }

        [Test]
        public void OneIsOddNumber()
        {
            var oe = new OddEvener();
            bool expected = oe.IsDivisibleByTwo(1);
            Assert.That(expected, Is.False);
        }

        [Test]
        public void TwoIsEvenNumber()
        {
            var oe = new OddEvener();
            bool expected = oe.IsDivisibleByTwo(2);
            Assert.That(expected, Is.True);
        }

        [Test]
        public void ThreeIsPrimeNumber()
        {
            var oe = new OddEvener();
            bool expected = oe.IsPrimeNumber(3);
            Assert.That(expected, Is.True);
        }

        [Test]
        public void TwoIsPrimeNumber()
        {
            var oe = new OddEvener();
            bool expected = oe.IsPrimeNumber(2);
            Assert.That(expected, Is.True);
        }

        [Test]
        public void TextForNumberEvenNumber()
        {
            var oe = new OddEvener();
            var text = oe.GetTextForNumber(6);
            Assert.That(text, Is.EqualTo("Even"));
        }

        [Test]
        public void TextForNumberOddButNotPrimeNumber()
        {
            var oe = new OddEvener();
            var text = oe.GetTextForNumber(9);
            Assert.That(text, Is.EqualTo("Odd"));
        }

        [Test]
        public void TextForNumberPrimeNumber()
        {
            var oe = new OddEvener();
            var text = oe.GetTextForNumber(5);
            Assert.That(text, Is.EqualTo("5"));
        }
    }
}
