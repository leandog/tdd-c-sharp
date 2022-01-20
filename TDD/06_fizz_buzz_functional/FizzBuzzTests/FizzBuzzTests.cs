using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void TestZero()
        {
            var expected = new List<string>();

            var result = new FizzBuzz().Calculate(0);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFizzBuzz()
        {
            var expected = new List<string> {
                "1", "2", "Fizz", "4", "Buzz",
                "Fizz", "7", "8", "Fizz", "Buzz",
                "11", "Fizz", "13", "14", "FizzBuzz"
            };

            var result = new FizzBuzz().Calculate(15);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}