using System;
using System.IO;
using System.Xml.Serialization;

public class Person
on
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class XmlSerializationExample
{
    static void Main()
    {
        Person p = new Person { Name = "John Doe", Age = 30};
        XmlSerializer serializer = new SmlSerializer(typeof(Person));

        // Serialize object to XML
        using (FileStream fs = new FileStream("person.xml", FileMode.Create))
        {
            serializer.Serialize(fs, p);
            Console.WriteLine("Object serialized to XML!");
        }

        // Deserialize object from XML
        using (FileStream fs = new FileStream("person.xml", FileMode.Open))
        {
            Person p2 = (Person)serializer.Deserialize(fs);
            Console.WriteLine("Object deserialized from XML:");
            Console.WriteLine("Name: " + p2.Name);
            Console.WriteLine("Age: " + p2.Age);
        }
    }
}