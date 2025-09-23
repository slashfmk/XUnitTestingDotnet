using src;

namespace tests.MixedTests;

public class ValidatorTests
{

    private readonly Validator _validator = new();


    [Theory]
    [InlineData("slashcs7@gmail.com", true)]
    [InlineData("info@oxygenik.com", true)]
    [InlineData("@234x@a.commuc", false)]
    public void Valid_EmailAddress_ReturnsTrue(string email, bool expectedResult)
    {
        //Arrange
        
        //Act
        var result = _validator.IsValidEmail(email);
        //Assert
        Assert.Equal(expectedResult, result);
    }
    
    
    [Theory]
    [InlineData("718-290-4589", true)]
    [InlineData("7082904589", true)]
    [InlineData("89574", false)]
    public void Valid_PhoneNumber_ReturnsTrue(string phoneNumber, bool expectedResult)
    {
        //Arrange
        
        //Act
        var result = _validator.IsValidNumber(phoneNumber);
        //Assert
        Assert.Equal(expectedResult, result);
    }
}