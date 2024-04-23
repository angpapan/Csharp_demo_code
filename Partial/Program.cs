using Partial;

Dog doggo = new Dog("Max");

doggo.Walk();
doggo.Bark();
doggo.Walk();

Console.WriteLine($"{doggo.Name} walked {doggo.Distance} steps!");
