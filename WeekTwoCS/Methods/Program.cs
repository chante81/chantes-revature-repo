using System;
using System.Xml.XPath;
// import statements - pulls from C# libraries
/*
Problem: Often we have chunks of code that perform some operation that we'd like to potentially 
use again later in our program. Right now, our only means to do so is to simply copy/paste that 
chunk of code to repeat its intended functionality.

Methods - Allow us to recall a chunk of code all consolidated to one place as often as we'd like, 
while simultaneously abstracting away the implementations behind achieving such functionality, 
allowing us to focus solely on the intention of said chunk of code.

Defines a set of statements/series/lines of code doing something cohesive - allows us to reuse when 
we want. Will also allow us to stop focusing on how they achieved what they achieved and focus on new 
intention. 
*/
class Program
{
    static void Main(string[] args)
    {
        // AddNumbers(1, 2);
        // AddNumbers(6, 10);

        // int square = SquareNumber(5);
        // System.Console.WriteLine(square);

        // // Pring out this welcome message
        // System.Console.WriteLine("Please enter your name: ");
        // string input = Console.ReadLine();
        // System.Console.WriteLine("======================");
        // System.Console.WriteLine($"= Hello, {input}! =");
        // System.Console.WriteLine("======================");

        // SayHello();

        // PrintMenu();

        // int cmd = GetCmd();

        // ProcessCmd(cmd);

        // // Takes in two strings and prints both of them twice.

        // DoubleString();

        // DoubleTwoString("happy", "joy");

        // //Find the largest number between 3 ints.

        FindLargest(10,10,10);

    }

    public static void FindLargest(int number1, int number2, int number3)
    {
        if (number1 >= number2 && number1 >= number3)
        {
            System.Console.WriteLine($"{number1} is the greatest of all the numbers.");
        }
        else if (number2 >= number1 && number2 >= number3)
        {
            System.Console.WriteLine($"{number2} is the greatest of all the numbers.");
        }
        else if (number3 >= number1 && number3 >= number2)
        {
            System.Console.WriteLine($"{number3} is the greatest of all the numbers.");
        }
    }

    public static void DoubleTwoString(string string1, string string2)
    {
            System.Console.WriteLine($"{string1} {string1} {string2} {string2}");
    }
    
    private static void DoubleString()
    {
        System.Console.WriteLine("Please enter your string:");
        string input1 = Console.ReadLine();
        System.Console.WriteLine("Please enter your second string:");
        string input2 = Console.ReadLine();

        System.Console.WriteLine($"{input1} {input1} {input2} {input2}");
    }

    private static void ProcessCmd(int cmd)
    {
        switch (cmd)
        {
            case 1:
                {
                    SayHello(); break;
                }
            case 2:
                {
                    ProcessAddNumbers();
                    break;
                }
            case 3:
                {
                    ProcessSquareNumber();
                    break;
                }
        }
    }

    public static void ProcessSquareNumber()
    {
        System.Console.WriteLine("Enter a Number:");
        string? value1 = Console.ReadLine();
        int num1 = 0;
        if (value1 != null) num1 = int.Parse(value1);

        int result = SquareNumber(num1);
        System.Console.WriteLine(result);
    }

    public static void ProcessAddNumbers()
    {
        System.Console.WriteLine("Enter 1st Number:");
        string? value1 = Console.ReadLine();
        System.Console.WriteLine("Enter 2nd Number:");
        string? value2 = Console.ReadLine();

        int num1 = 0;
        int num2 = 0;
        if (value1 != null) num1 = int.Parse(value1);
        if (value2 != null) num2 = int.Parse(value2);

        AddNumbers(num1, num2);
    }

    public static int GetCmd()
    {
        string? input = Console.ReadLine();
        int cmd = 0;
        if (input != null) cmd = int.Parse(input);
        return cmd;
    }

    public static void PrintMenu()
    {
        System.Console.WriteLine("Welcome to our App");
        System.Console.WriteLine("=======================");
        System.Console.WriteLine("Please Enter a Command:");
        System.Console.WriteLine("[1] Say Hello!");
        System.Console.WriteLine("[2] Add two numbers");
        System.Console.WriteLine("[3] Square a number");
        System.Console.WriteLine("=======================");
    }

    // Let's make a method that adds two numbers together and prints the result
    // must be done outside of main method
    // Method Signature Syntax: access_modifier return_type MethodName(paramType paramName1, paramType paramName2) {}

    public static void AddNumbers(int num1, int num2)
    {
        System.Console.WriteLine(num1 + num2);
    }

    // Lets make a method that RETURNS the squared value of a number.
    public static int SquareNumber(int num1)
    {
        int square = num1 * num1;
        return square;
    }

    public static void SayHello()
    {
        System.Console.WriteLine("Please enter your name: ");
        string input = Console.ReadLine();
        System.Console.WriteLine("======================");
        System.Console.WriteLine($"= Hello, {input}! =");
        System.Console.WriteLine("======================");
    }

    // Takes in two strings and prints both of them twice.


    //Find the largest number between 3 ints.

}



