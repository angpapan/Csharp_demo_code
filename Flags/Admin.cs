namespace Flags;

internal class Admin : Account
{
    public Admin(string username) : base(Permission.Read | Permission.Write | Permission.Execute, username) { }
}
