namespace Flags;

internal class Reader : Account
{
    public Reader(string username) : base(Permission.Read, username) { }
}
