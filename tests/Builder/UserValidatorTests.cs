using ConsoleTest.Builder;
using tests.TestData;

namespace tests.Builder;

public class UserValidatorTests
{
    
    [Theory]
    [ClassData(typeof(UserData))]
    public void Check_UserValidation_returnsBooleanTrueState(Person person, bool expectedResult)
    {
        // Arrange
        var userValidator = new UserValidator();
        // Act
        var resultIsAdult = userValidator.IsAdult(person);
        var resultHasName = userValidator.HasValidName(person);
        // Assert
        Assert.True(resultIsAdult, $"This user is not an adult");
        Assert.True(resultHasName, $"No name provided!");
    }
    
    
    /**
     * Using the static method
     */
    public static IEnumerable<object[]> GetValidationScenarios()
    {
        yield return new object[] { new Person { Age = 25, Name = "Vicky", Title = "Scientist" }, true };
        yield return new object[] { new Person { Age = 17, Name = "Jessica", Title = "Stylist" }, false };
        yield return new object[] { new Person { Name = "Yannick", Age = 38, Title = "Computer scientist" }, true };
    }
    
    
    /**
     * The code below
     * Version 2 with xUnit 3 only
     * Safer way to Test
     */
    [Theory]
    [MemberData(nameof(GetValidationScenariosV2))]
    public void Check_UserValidation_returnsBooleanTrueStateV2(Person person, bool expectedResult)
    {
        // Arrange
        var userValidator = new UserValidator();
        // Act
        var resultIsAdult = userValidator.IsAdult(person);
        var resultHasName = userValidator.HasValidName(person);
        // Assert
        Assert.True(resultIsAdult, $"This user is not an adult");
        Assert.True(resultHasName, $"No name provided!");
    }

    
    // Safe theoryDataRow with multiple generic parameters (MetaData)
    public static IEnumerable<TheoryDataRow<Person, bool>> GetValidationScenariosV2()
    {
        yield return new TheoryDataRow<Person, bool>(
        new Person { Age = 25, Name = "Vicky", Title = "Scientist" }, true
        ).WithTestDisplayName("My test");
        
        yield return new TheoryDataRow<Person, bool>(
            new Person { Age = 12, Name = "Vicky", Title = "Scientist" }, false
        ).WithTestDisplayName("My testAgain");
    }

    // Safe theoryData with multiple generic parameters (No MetaData)
    public static TheoryData<Person, bool> GetValidationScenariosV3() => new()
            {
                {
                    new Person { Age = 25, Name = "Vicky", Title = "Scientist" }, true
                },
                {
                    new Person { Age = 12, Name = "Vicky", Title = "Scientist" }, false
                }
            };
    
}