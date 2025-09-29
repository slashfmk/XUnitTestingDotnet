
namespace ConsoleTest.Builder;

public class PersonBuilder
{

    private readonly Person _person = new();

    public PersonBuilder GiveAName(string name)
    {
        _person.Name = name;
        return this;
    }

    public PersonBuilder ProvideAge(int age)
    {
        _person.Age = age;
        return this;
    }
    
    public PersonBuilder SetTitle(string title)
    {
        _person.Title = title;
        return this;
    }

    public Person Build()
    {
        return _person;
    }
    
}