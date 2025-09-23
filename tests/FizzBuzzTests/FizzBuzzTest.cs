using src;

namespace tests;

public class FizzBuzzTest
{

    private readonly FizzBuzz _fizzBuzz;

    public FizzBuzzTest()
    {
        _fizzBuzz = new FizzBuzz();
    }

    [Fact]
    public void Divide_ANumberThatIsDivisibleByThree_ReturnsFizz()
    {
        //Arrange
        var n = 9;
        //Act
        var result = _fizzBuzz.DivisibleBy(n);
        //Assert
        Assert.Equal("Fizz", result);
    }
    
    [Fact]
    public void Divide_ANumberThatIsDivisibleByFive_ReturnsBuzz()
    {
        //Arrange
        var n = 25;
        //Act
        var result = _fizzBuzz.DivisibleBy(n);
        //Assert
        Assert.Equal("Buzz", result);
    }
    
    [Fact]
    public void Divide_ANumberThatIsDivisibleByThreeAndFive_ReturnsFizzBuzz()
    {
        //Arrange
        var n = 15;
        //Act
        var result = _fizzBuzz.DivisibleBy(n);
        //Assert
        Assert.Equal("FizzBuzz", result);
    }
    
    [Fact]
    public void Divide_ANumberThatIsNotDivisibleByThreeAndFive_ReturnsFizzBuzz()
    {
        //Arrange
        var n = 7;
        //Act
        var result = _fizzBuzz.DivisibleBy(n);
        //Assert
        Assert.Equal(n.ToString(), result);
    }
    
}