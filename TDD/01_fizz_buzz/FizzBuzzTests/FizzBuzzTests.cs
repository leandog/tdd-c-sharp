/*
# Three Laws of Test Driven Development
- You are not allowed to write any production code unless it is to make a failing unit test pass.
- You are not allowed to write any more of a unit test than is sufficient to fail; and compilation failures are failures.
- You are not allowed to write any more production code than is sufficient to pass the one failing unit test.
*/

/*
PROBLEM REQUIREMENTS:
- For all whole numbers from 1 to 100
- For multiples of three set “Fizz” instead of the number
- For the multiples of five set “Buzz”. 
- For numbers which are multiples of both three and five set “FizzBuzz“.
- Otherwise set the ordinal number (as a String)
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void TestFizzBuzz()
        {
            // var fizzBuzz = new FizzBuzz();
            Assert.IsTrue(false, "Turn the checked value to true to pass this test");
        }
    }
}
