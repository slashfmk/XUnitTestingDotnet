using System.Collections;
using ConsoleTest.Builder;

namespace tests.TestData;

public class UserData: IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { new Person { Age = 25, Name = "Vicky", Title = "Scientist" }, true };
        yield return new object[] { new Person { Age = 17, Name = "", Title = "Stylist" }, false };
        yield return new object[] { new Person { Name = "Yannick", Age = 38, Title = "Computer scientist" }, true };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}