using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathApp; 

namespace MathApp.Tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Test_AddMethod_ShouldReturnTen()
    {
        // 1. Arrange 
        var calc = new Calculator();
        
        // 2. Act 
        var result = calc.Add(4, 6);
        
        // 3. Assert 
        Assert.AreEqual(10, result);
    }
}