using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        //OverloadEx();
        OverrideEx();


    }

    private static void OverloadEx()
    {
        System.Console.WriteLine(Calculator.Add(4, 5));
        System.Console.WriteLine(Calculator.Add(4, 5, 6));
        System.Console.WriteLine(Calculator.Add(4.2, "5"));
        System.Console.WriteLine(Calculator.Add("56", 5.5));
        int[] numbers = [1, 2, 3];
        System.Console.WriteLine(Calculator.Add(numbers));
        //System.Console.WriteLine(Calculator.Add([1, 2, 3, 4, 5]);
        System.Console.WriteLine(Calculator.Add(2.5));
        System.Console.WriteLine(Calculator.Add(2.3, 5.6));
        System.Console.WriteLine(Calculator.Add(2.6, 4.2, 8.2, 9.4, 12.7, 16.3, 18.9));
    }

public static void OverrideEx()
{
    Parent p = new();
    p.JobTitle = "Trainer";
    p.Work();
    System.Console.WriteLine("----------------------------");
    Child c = new();
    c.JobTitle = "Student";
    c.FavoriteGame = "Minecraft";
    c.Play();
    c.Work();

    //Back to Parent
    System.Console.WriteLine(p.ToString());
    System.Console.WriteLine(c);

    // (Somewhat) Bonus Knowledge --- turn back now! -- Save Yourself! 
    Parent p2 = new();
    Parent p3 = p2;
    Parent pc = new Child(); 
    //ok syntactically bc Child class has all aspects of Parent class. Still recognizes as Parent object.
    //only has access to Parent items (methods, properties, etc.), but uses child behaviors - ex. pc.Work();
    pc.JobTitle = "";
    pc.Work();


    //Child c2 = new Parent();
    //slicght detour - Casting
    int num1 = (int)2.5;
    System.Console.WriteLine(num1);

    string num2 = (string)"2.5";
    System.Console.WriteLine(num2);

    //Child c2 = (Child) p; //"Unhandled exception. System.InvalidCastException: Unable to cast object of type 'Parent' to type 'Child'."
    //p can only work and have jobtitle

    Child c2 = (Child)pc;
    c2.Work();

}




}