using Indexers;

Classes classes = new Classes(10);
classes[0] = "Compilers";
classes[1] = "Data Structures";
classes[3] = "AI";

Console.WriteLine($"Class 0: {classes[0]}");
Console.WriteLine($"Class 1: {classes[1]}");
Console.WriteLine($"Class 2: {classes[2]}");
Console.WriteLine($"All class spots: {classes.NumberOfPossibleClasses}");
Console.WriteLine($"Used classes: {classes.NumberOfActiveClasses}");
Console.WriteLine($"Available spots: {classes.NumberOfAvailableClasses}");
Console.WriteLine($"First available class index: {classes.FirstAvailableClass}");
