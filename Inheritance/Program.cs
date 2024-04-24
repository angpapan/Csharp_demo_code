using Inheritance;

Animal dog = new Dog("Max");
Animal cat = new Cat("Dora");

dog.MakeSound();
cat.MakeSound();
Console.log($"{((Dog)dog).Name} " +
  $"{(dog.IsAlive() ? "is" : "is not")} alive.");

// Reflection
Type type = dog.GetType();
Type type2 = cat.GetType();

Console.WriteLine(type);
Console.WriteLine(type2);
