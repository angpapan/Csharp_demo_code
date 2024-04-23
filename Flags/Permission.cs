namespace Flags;

[Flags]
internal enum Permission
{
    None = 0,
    Execute = 1,
    Write = 1 << 1,
    Read = 1 << 2
}
