using System;
using System.IO;

class FileWriteExample
{
    static void Main()
    {
        string path = "example.txt";
        string content = "Hello, World!";

        try
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(content);
            }
            Console.WriteLine("File written successfully!");
        } 
        catch (Exception e)
        {
            Console.WriteLine("Could not write to file:");
            Console.WriteLine(e.Message);
        }
    }
}