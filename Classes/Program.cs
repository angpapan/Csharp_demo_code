class Program
{
    internal class Animal
    {
        public int legsNum;
    }

    static void Main(string[] args)
    {
        // Creating a new instance of the Animal class
        Animal dog = new Animal();
        dog.legsNum = 4;
        // Another instance of the Animal class
        Animal snake = new Animal();
        snake.legsNum = 0;
        Console.WriteLine("Dog has {0} legs", dog.legsNum);
        Console.WriteLine("Snake has {0} legs" ,snake.legsNum);
    }
}

 