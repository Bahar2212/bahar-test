using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathApp;

namespace MathApp.Tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Test_AddMethod_ShouldReturnCorrectSum()
    {
        // Arrange: Setup the initial state and variables
        var calc = new Calculator();
        int firstValue = 10;
        int secondValue = 20;

        // Act: Execute the method being tested
        var result = calc.Add(firstValue, secondValue);

        // Assert: Verify that the result is what we expected
        Assert.AreEqual(30, result);
    }
}