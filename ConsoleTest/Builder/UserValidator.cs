namespace ConsoleTest.Builder;

public class UserValidator
{
    public bool IsAdult(Person user)
    {
        return user.Age > 18;
    }

    public bool HasValidName(Person user)
    {
        return !user.Name.Equals("");
    }
}