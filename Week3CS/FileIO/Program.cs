using System;

class Program
{
    static void Main(string[] args)
    {

        string filepath = "example.txt";

        //StreamWriter writer = new StreamWriter(filepath, false); //true/false to append - will either allow adding/duplication,  
        //or blocks and overwrites what's already there

        //writer.WriteLine("Hello, world!");
        //writer.WriteLine("Chante was here!");


        //Console.WriteLine("Info written to file."); //Does not impact file since this is writing to the console, not the StreamWriter

        //writer.Close(); //Ensures writer completes all tasks prior to closing resource.

        WriteToFile(filepath);
        ReadFromFile(filepath);
        string desktopFile = "C:\\Users\\U88ABJ\\Desktop";
        WriteToFile(desktopFile);
        
    }

    private static void WriteToFile(string filepath)
    {
        using (StreamWriter writer = new StreamWriter(filepath, false)) //this option eliminates need to "close"
        {
            writer.WriteLine("Hello, world!");
            writer.WriteLine("Chante was here!");

            Console.WriteLine("Info written to file.");

        }
    }

     private static void ReadFromFile(string filepath)
    {
        using (StreamReader reader = new StreamReader (filepath))
        {
            string? line;
            while((line = reader.ReadLine()) != null) //assignment in loop, used when assignment can return bool expression
            System.Console.WriteLine(line);
        }

    }
}