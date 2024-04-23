namespace Flags;

internal class File
{
    public string Name { get; }

    public File(string name)
    {
        Name = name;
    }

    public void Read(Account acc)
    {
        if (acc.Permissions.HasFlag(Permission.Read))
            Console.WriteLine($"{acc.UserName} reads {Name}");
        else
            Console.WriteLine($"{acc.UserName} does not have permission to read {Name}");
    }

    public void Write(Account acc)
    {
        if ((acc.Permissions & Permission.Write) != 0)
            Console.WriteLine($"{acc.UserName} writes to {Name}");
        else
            Console.WriteLine($"{acc.UserName} does not have permission to write to {Name}");
    }
}
