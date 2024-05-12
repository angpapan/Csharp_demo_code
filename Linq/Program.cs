string[] strings = { "di", "uoa", "compilers", "linq" };

IEnumerable<string> lengthy = 
    from str in strings 
    where str.Length > 5 
    select str;

IEnumerable<string> startWithD = strings
    .Where(s => s.StartsWith("d"))
    .Select(s => s);

foreach (string l in lengthy) Console.WriteLine(l); // compilers
foreach (string l in startWithD) Console.WriteLine(l); // di


