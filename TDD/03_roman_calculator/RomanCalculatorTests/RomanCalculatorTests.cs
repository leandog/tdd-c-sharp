/*
# Three Laws of Test Driven Development
- You are not allowed to write any production code unless it is to make a failing unit test pass.
- You are not allowed to write any more of a unit test than is sufficient to fail; and compilation failures are failures.
- You are not allowed to write any more production code than is sufficient to pass the one failing unit test.
*/

/*
Fake it till you make it
*/

/*
# ZOMBIES
Z - Zero                          
O - One                           
M - Many
B - Boundary Behavior
I - Interface Definition          
E - Exercise Exception Behavior
S - Simple
*/

/*
S - Single Responsibility Principle
O - Open / Closed => Open for extension, closed for modification
L - Liskov Substitution => shape.area :: rectangle.area : square.area : circle.area
I - Interface Segregation
D - Dependency Inversion
*/

/*
D - Don't
R - Repeat
Y - Yourself
*/

/*
Y - You
A - Ain't
G - Gonna
N - Need
I - It
*/

/*
PROBLEM REQUIREMENTS:
- Numerals can be concatenated to form a larger numeral (“XX” + “II” = “XXII”)
- If a lesser numeral is put before a bigger it means subtraction of the lesser from 
    the bigger (“IV” means four, “CM” means nine hundred)
- If the numeral is I, X or C you can’t have more than three (“II” + “II” = “IV”)
- If the numeral is V, L or D you can’t have more than one (“D” + “D” = “M”)
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanCalculator;

[TestClass]
public class RomanCalculatorTests
{
    [TestMethod]
    public void TestRomanCalculator()
    {
        // var romanCalculator = new RomanCalculator();
        Assert.IsTrue(false, "Turn the checked value to true to pass this test");
    }
}