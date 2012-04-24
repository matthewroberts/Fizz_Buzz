using Interview.Core.Common.Helpers;
using Interview.Core.Domain.Services;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Interview.Test
{
    [TestFixture]
    public class FizzBuzzTests
    {

        [Test]
        public void TestRangePrinted()
        {
            var printerTest = new PrinterServiceTest();
            var fizzBuzz = new FizzBuzzService(printerTest);
            fizzBuzz.InputRange(1, 100);

            Assert.That(printerTest.Lines.Count, Is.EqualTo(100));
        }

        [Test]
        public void TestMultiplesOfThreePrintsFizz()
        {
            var printerTest = new PrinterServiceTest();
            var fizzBuzz = new FizzBuzzService(printerTest);

            Assert.That(fizzBuzz.Output(3), Is.StringMatching("Fizz"));
            Assert.That(fizzBuzz.Output(96), Is.StringMatching("Fizz"));
        }

        [Test]
        public void TestMultilesOfFivePrintsBuzz()
        {
            var printerTest = new PrinterServiceTest();
            var fizzBuzz = new FizzBuzzService(printerTest);

            Assert.That(fizzBuzz.Output(5), Is.StringMatching("Buzz"));
            Assert.That(fizzBuzz.Output(65), Is.StringMatching("Buzz"));
        }

        [Test]
        public void TestMultiplesOfThreeAndFiveBuzz()
        {
            var printerTest = new PrinterServiceTest();
            var fizzBuzz = new FizzBuzzService(printerTest);

            Assert.That(fizzBuzz.Output(15), Is.StringMatching("FizzBuzz"));
            Assert.That(fizzBuzz.Output(60), Is.StringMatching("FizzBuzz"));
        }

        [Test]
        public void TestIsNotMultipleOfThreeOrFive()
        {
            var printerTest = new PrinterServiceTest();
            var fizzBuzz = new FizzBuzzService(printerTest);

            Assert.That(fizzBuzz.Output(7), Is.StringMatching("7"));
            Assert.That(fizzBuzz.Output(19), Is.StringMatching("19"));
        }

        [Test]
        public void TestIsDivisibleBy()
        {
            Assert.That(33.IsDivisibleBy(3), Is.True);
            Assert.That(55.IsDivisibleBy(5), Is.True);

        }

        [Test]
        public void TestIsNotDivisibleBy()
        {
            Assert.That(32.IsDivisibleBy(3), Is.False);
            Assert.That(52.IsDivisibleBy(5), Is.False);
        }
    }
}
