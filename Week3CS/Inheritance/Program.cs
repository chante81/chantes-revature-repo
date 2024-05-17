using System;

class Program
{
    static void Main(string[] args)
    {
        Buildings b1 = new();
        Buildings b2 = new(4,1100);

        System.Console.WriteLine(b1);
        System.Console.WriteLine(b2);       

        System.Console.WriteLine("----------------House---------------------");
        House h1 = new();

        System.Console.WriteLine(h1);
    
        //What if I wanted to provide a number of walls to my house?
        House h2 = new(6, 500);
        System.Console.WriteLine(h2);

        House h3 = new(8,700,2,"Chante Osborne");   
        System.Console.WriteLine(h3);
    }
}