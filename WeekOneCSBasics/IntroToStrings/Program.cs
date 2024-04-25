// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

/*
Strings - a sequence of characters (letters, numbers, symbols, and whitespace) all put together.
 - represented with "double quotes" in C# for String Literals 
 - "Hello, World!" is a String Literal
 - The type here is a String
 - String is a reference-type (aka an Object data type)
     - Objects have more capabilities than just storing a value
     - They can also have methods to perform various functionality (potentially upon some stored value or values)
     - Example: Car Object - 
        - States - Fields - properties (variables - pieces of data about said object)
            - Color
            - Make
            - Model
            - Year
            - VIN
            - numberOfTires
            - Horsepower
            - Mileage
        - Behaviors - Methods (functionality we wish to perform with our Object)
            - Drive
            - Park
            - TurnOnRadio
            - RollDownWindows
            - Reverse
            - TurnOnWipers
            - TurnOnHeadlights
*/        

// Create a String variable
string word = "Hello";
System.Console.WriteLine(word);

// To access fields and methods from objects we create, we use the "." (member access) operator

System.Console.WriteLine(word.Length);

word = "Hello, World!";
System.Console.WriteLine(word.Length);

System.Console.WriteLine(word.ToUpper()); // ToUpper is a method - must add set of parenthesis afterwards

// (), [], {}

System.Console.WriteLine(word.ToLower());
System.Console.WriteLine(word.Substring(3));
System.Console.WriteLine(word.Substring(3,8));
//System.Console.WriteLine(word.Substring(3,15)); // Will return error since length used is out of range (longer than the string)
//Unhandled exception. System.ArgumentOutOfRangeException: Index and length must refer to a location within the string. (Parameter 'length')
//   at System.String.ThrowSubstringArgumentOutOfRange(Int32 startIndex, Int32 length)
//   at System.String.Substring(Int32 startIndex, Int32 length)
//   at Program.<Main>$(String[] args) in C:\Users\U88ABJ\Revature\chantes-revature-repo\WeekOneCSBasics\IntroToStrings\Program.cs:line 52

// ToUpper();
// WriteLine(word); // Argument (word)
// When defining a method; referred to as the method's Parameters

/*
    Indexes - Strings and other various collection-based devices use Indexes/Indexing

    Indexes describe the postion of that element with the entire set of data.
    Strings -> the position of that Character within the entire String.

    Indexes (in MOST Programming languages) are 0-indexed.
    The 1st character in the String starts at the index 0.
        The 2nd character is at index 1... etc.
        The last index of any String is: Length(-1)
*/

// String Concatenation
// When using the '+' sign with Strings the behavior changes away from (mathematical)
// Concatenation - the combining of two or more strings in which we conjoin all the characters into one new string.

string phrase = "Hello " + "World!";

System.Console.WriteLine(phrase);

string fname = "Chante";
string lname = "Osborne";
System.Console.WriteLine("Hello, my name is " + fname + lname); // need to add a space between names
System.Console.WriteLine("Hello, my name is " + fname + " " + lname);

// Review with integers

int num1 = 1;
int num2 = 2;
System.Console.WriteLine("num1 = " + num1);
System.Console.WriteLine("num2 = " + num2);
System.Console.WriteLine(num1 + num2); // not concatenation, because no strings
System.Console.WriteLine("1" + 1); //performs concatentaion, not addition!

// value-types -> == measures if they have the same value.
System.Console.WriteLine(num1 == 1);
int num3 = 1;
System.Console.WriteLine(num1 == num3);


// reference-types -> Objects -> == this will check if they are the same object in memory. (by location, not value)
Object obj1 = new ();
Object obj2 = new ();

System.Console.WriteLine(obj1 == obj2);

// Strings utilize what is called the String Pool
// Strings that are assinged the same value will point to the same location in memory
// This is to conserve on memory for strings.
string word1 = "Hello";
string word2 = "Hello";
System.Console.WriteLine(word1 == word2);

