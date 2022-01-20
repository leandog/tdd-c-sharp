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
                "Fizz", "Pop", "8", "Fizz", "Buzz",
                "11", "Fizz", "13", "Pop", "FizzBuzz"
            };

            var result = new FizzBuzz().Calculate(15);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestPoP()
        {
            var expected = new List<string> {
                "1", "2", "Fizz", "4", "Buzz",
                "Fizz", "Pop"
            };

            var result = new FizzBuzz().Calculate(7);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}