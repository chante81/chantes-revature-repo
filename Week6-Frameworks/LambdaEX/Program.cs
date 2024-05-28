using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        /*
        Lambda Expression
        for some input, do the following
        -num => num * 7 ---> given an input 'num' perform (num * 7)

        -num is a placeholder name for "whatever input is received"

        - When are lambda expressions going to be used?
        - Often times methods are already built to take in Lambdas as an easier way to pass in functionality into another method
        - This will happen often when working with sets/collections of data. There are often several methods that will perform an
            operation over every value (like a loop).
        -LINQ -> Language Integrated Query -> Used for simplifying querying or manipulating collections.
            It offers some methods for performing operations on our collections that feel more like SQL querying.

            SELECT * FROM User WHERE Price < 5;
            - LINQ: filteredMovies = allMovies.Where(x => x.Price < 5);

        */

        // Test our LINQ and Lambda Expressions
        LambdaTest();


    }

    public static void LambdaTest()
    {
        List<int> numbers = [2,3,8,6,7,4,1,5];
        List<string> words = ["Hello", "Hey", "Hi", "Goodbye"];

        // var evenNumbers = numbers.Where(num => num % 2 == 0); - commented out to allow list evenNumbers
        // Func<int, bool> -> indicates a Lambda expression will be accepted here
        var hWords = words.Where(word => word.Substring(0, 1) == "H");

        // Below can be simplified and used in a function
        // foreach (int num in evenNumbers)
        // {
        //     System.Console.WriteLine(num);
        // }

        // foreach (string word in hWords)
        // {
        //     System.Console.WriteLine(word);
        // }
        //Instead of using foreach loops above, can use the following:
        //Ned to change statment for even numbers to this one:
        List<int> evenNumbers = numbers.Where(num => num % 2 == 0).ToList();
        evenNumbers.ForEach(num => System.Console.WriteLine(num));

        //ForEach can also be used for list w/o LINQ like this:
        // numbers.ForEach(System.Console.WriteLine);
        System.Console.WriteLine("****************************************");

        evenNumbers = evenNumbers.OrderBy(x => x).ToList();
        evenNumbers.ForEach(System.Console.WriteLine);
    }
}
