using Flags;

Admin admin = new Admin("Admin");
Reader reader = new Reader("Reader");

admin.ListPermissions();
reader.ListPermissions();
Console.WriteLine();

Flags.File file = new Flags.File("test.txt");

file.Read(admin);
file.Read(reader);
file.Write(admin);
file.Write(reader);