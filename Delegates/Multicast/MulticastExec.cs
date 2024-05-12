namespace Delegates.Multicast;

internal static class MulticastExec
{
    public static void Execute()
    {
        Multicast num = new(5);
        Calculation c1 = new Calculation(num.Add);
        Calculation c2 = new Calculation(num.Multiply);
        num.Calc = c1;
        num.Calc += c2;
        num.Calc(10); // (5 + 10) * 10

        Console.WriteLine(num.Num); // 150
    }
}
