using System;
using System.Diagnostics.Contracts;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        //PreventativeApproach();

        //HandlingExceptions();

        //System.Console.WriteLine(WhyFinally());

        ThrowingExceptions();



    }

    public static void ThrowingExceptions()
    {
        // You can introduce your own Exceptions into the code at will: throw keyword

        System.Console.WriteLine("Enter a number between 1-100: ");
        int guess = int.Parse(Console.ReadLine() ?? "0");

        int correct = 30;

        if(guess == correct)
        {
            System.Console.WriteLine("You got it correct!");
        }
        else if (guess > correct && guess <= 100)
        {
            System.Console.WriteLine("Your guess is too high!");
        }
        else if (guess < correct && guess > 0)
        {
            System.Console.WriteLine("Your guess is too low!");
        }
        else{
            throw new NoFunException("I guess you aren't having fun anymore! Goodbye!");
        }



    }

    public static int WhyFinally()
    {
        int x = 10;
        int y = 0;

        try
        {
            int result = x / y;
            return result;
        }
        catch (DivideByZeroException ex)
        {
            System.Console.WriteLine(ex.Message);
            return 0;
        }
        finally
        {
            System.Console.WriteLine("Printing from the Finally Block!");
        }

        System.Console.WriteLine("Printing from the End of the Program.");

    }
    public static void HandlingExceptions()
    {
        int[] numbers = [1, 2, 3];

        System.Console.WriteLine("Enter and index: ");
        string input = Console.ReadLine() ?? "0";


        // Handling Exceptions: try-catch block
        try
        {
            int index = int.Parse(input);
            System.Console.WriteLine(numbers[index]);
        }
        // catch (System.IndexOutOfRangeException e)
        // {
        //     System.Console.WriteLine(e.Message);
        //     System.Console.WriteLine(e.StackTrace);
        // }
        // catch (System.FormatException e)
        // {
        //     System.Console.WriteLine(e.Message);
        //     System.Console.WriteLine(e.StackTrace);
        // }
        catch (SystemException e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
        }
        System.Console.WriteLine("Program End");
    }

    private static void PreventativeApproach()
    {
        int[] numbers = [1, 2, 3];

        System.Console.WriteLine("Enter an index: ");
        int index = int.Parse(Console.ReadLine() ?? "0"); //Null Coalescing

        if (index >= numbers.Length || index < 0)
        {
            System.Console.WriteLine("You failed to enter a valid index!");
            System.Console.WriteLine("Enter an index: ");
            index = int.Parse(Console.ReadLine() ?? "0"); //Null Coalescing
        }
        else
        {
            System.Console.WriteLine(numbers[index]); //Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
        }
    }
}
