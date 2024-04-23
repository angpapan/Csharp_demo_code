using System.Reflection;
using Reflection;

NoChanging a = new NoChanging("First!");

var properties = a.GetType().GetProperties();

Console.WriteLine("Listing class properties...");
foreach (var property in properties)
{
    Console.WriteLine(property.Name, property.PropertyType);
}
Console.WriteLine();


Console.WriteLine($"Initial value of private field: {a.ShouldNotChange}");
Console.WriteLine($"Trying to change it...");

var str = a
    .GetType()
    .GetField("_shouldNotChange", BindingFlags.NonPublic | BindingFlags.Instance);

str.SetValue(a, "Second!");

Console.WriteLine($"It changed(!!): {a.ShouldNotChange}");

