using System;
using System.IO;
using System.Text.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class JsonSerializationExample
{
    static void Main()
    {
        Person person = new Person { Name = "John Doe", Age = 30 };

        // Serialize to JSON
        string jsonString = JsonSerializer.Serialize(person);
        File.WriteAllText("person.json", jsonString);
        Console.WriteLine("Object serialized to JSON.");

        // Deserialize from JSON
        jsonString = File.ReadAllText("person.json");
        Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonString);
        Console.WriteLine("Object deserialized from JSON:");
        Console.WriteLine($"Name: {deserializedPerson.Name}");
        Console.WriteLine($"Age: {deserializedPerson.Age}");
    }
}