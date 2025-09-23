using src;

namespace tests.MixedTests;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsSum()
    {
        // Arrange
        var firstNumber = 1;
        var secondNumber = 2;

        // Act
        var result = _calculator.Add(firstNumber, secondNumber);

        // Assert
        Assert.Equal(3, result);
    }
}