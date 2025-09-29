// See https://aka.ms/new-console-template for more information


using ConsoleTest.Builder;

var builder = new PersonBuilder();

var x = builder
    .GiveAName("Yannick Fumukani")
    .SetTitle("Software Engineer")
    .ProvideAge(12)
    .Build();

x.Title = "Great Master";

var y = builder.Build();

Console.WriteLine($"Welcome {x.Name} as a {x.Title}!");
Console.WriteLine($"Welcome {y.Name} as a {y.Title}!");