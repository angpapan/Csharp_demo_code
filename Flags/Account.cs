namespace Flags;

internal abstract class Account
{
    public Permission Permissions { get; }
    public string UserName { get; }

    protected Account(Permission permissions, string userName)
    {
        Permissions = permissions;
        UserName = userName;
    }

    public void ListPermissions()
    {
        Console.WriteLine($"{UserName} has permission to: {Permissions}");
    }
}
