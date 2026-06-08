namespace Calculator.Tests;

using NUnit.Framework;

public class CalculatorServiceTests
{
    [TestCase(1, 2, 3)]
    [TestCase(-1, 1, 0)]
    [TestCase(10, 5, 15)]
    public void Add_ReturnsExpectedResult(int a, int b, int expected)
    {
        var calculator = new CalculatorService();

        var result = calculator.Add(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }
}
