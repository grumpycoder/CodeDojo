using System;
using CodeDojo.Kata;
using NUnit.Framework;

namespace CodeDojo.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void ThreeIsDivisibleByThree()
        {
            var fb = new FizzBuzz();
            bool divisible = FizzBuzz.IsDivisibleByThree(3);
            Assert.That(divisible, Is.True);

        }

        [Test]
        public void FiveIsDivisibleByFive()
        {
            var fb = new FizzBuzz();
            bool divisible = FizzBuzz.IsDivisibleByFive(5);
            Assert.That(divisible, Is.True);

        }

        [Test]
        public void TextForDivisibleByThreeIsFizz()
        {
            var fb = new FizzBuzz();
            var text = fb.GetTextForNumber(3);
            Assert.That(text, Is.EqualTo("Fizz"));

        }

        [Test]
        public void TextForDivisibleByFiveIsBuzz()
        {
            var fb = new FizzBuzz();
            var text = fb.GetTextForNumber(5);
            Assert.That(text, Is.EqualTo("Buzz"));

        }

        [Test]
        public void TextForDivisibleByThreeAndFiveIsFizzBuzz()
        {
            var fb = new FizzBuzz();
            var text = fb.GetTextForNumber(15);
            Assert.That(text, Is.EqualTo("FizzBuzz"));

        }

        [Test]
        public void TextForNotDivisibleByThreeOrFiveIsItselfText()
        {
            var fb = new FizzBuzz();
            var text = fb.GetTextForNumber(1);

            Assert.That(text, Is.EqualTo("1"));
        }

        [Test]
        public void PrintTextForOneToFifteen()
        {
            var fb = new FizzBuzz();

            var text = fb.Print(15);

            Assert.That(text, Is.EqualTo("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz "));
        }

        [Test]
        public void ShouldPrintNumbersOneToTwo()
        {
            var fb = new FizzBuzz();
            var text = fb.Print(2);
            Assert.That(text, Is.EqualTo("1 2 "));
        }

        
    }
}
