namespace Calculator.Tests;

public class CalculatorServiceTests
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, 1, 0)]
    [InlineData(10, 5, 15)]
    public void Add_ReturnsExpectedResult(int a, int b, int expected)
    {
        var calculator = new CalculatorService();

        var result = calculator.Add(a, b);

        Assert.Equal(expected, result);
    }
}
