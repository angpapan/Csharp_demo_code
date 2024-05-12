var staticVar = "compilers"; // string
//staticVar = 10; // error

dynamic dynamicVar = "compilers"; // runtime string
Console.WriteLine(dynamicVar.Length); // 9
dynamicVar = 10; // ok

object objectVar = "compilers";
// Console.WriteLine(objectVar.Length); // error
objectVar = 10; // ok
