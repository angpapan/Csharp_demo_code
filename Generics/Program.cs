using Generics;

Person<int> galdalf = new Person<int>(1, "Gandalf", "The White");
Person<string> thranduil = new Person<string>("THRNDL", "Thranduil", "King of the Elves");
Person<double> aragorn = new Person<double>(100.12);
aragorn.Name = "Aragorn";
aragorn.Title = "King of Gondor";

Console.WriteLine(galdalf);
Console.WriteLine(thranduil);
Console.WriteLine(aragorn);


