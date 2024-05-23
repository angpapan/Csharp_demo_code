using System;
using System.IO;

class FileReadExample
{
    static void Main()
    {
        string path = "example.txt";

        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine("File Contnent: " + content);
            }
        } 
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}