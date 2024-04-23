using Inheritance;

Animal dog = new Dog("Max");
Animal cat = new Cat("Dora");

dog.MakeSound();
cat.MakeSound();

// Reflection
Type type = dog.GetType();
Type type2 = cat.GetType();

Console.WriteLine(type);
Console.WriteLine(type2);
