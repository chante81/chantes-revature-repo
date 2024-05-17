/*
Problem:  There is a lot of DATA that exists!!!
Managing each piece in its own variable is going to become impractical
A lot is quite similar or related whether it's by purpose or even Data Type.

We need to introduce means to store multiple pieces of data within one device/variable

Arrays -> Offers a way for us to simply store multiple values of the same Data Type

DataType[] variableName = new DataType[size];

Arrays - in C# - have a fixed size upon instantiation (initialization).

Arrays use indexes (just like strings) -> An Array of size 5 - Indexes: 0-4
*/
// Basic Example:  
// Brackets indicate we are creating an array, not an int. It's an array storing ints.
// new - allocating new memory for said object
// name of data type [] indicates array

using System.ComponentModel.DataAnnotations;

int[] numbers = new int[5]; // Create an Array that can hold 5 ints.
System.Console.WriteLine(numbers.Length);

// Assign a value to any *element* of this array - value must match data type determined at creation of Array 
// (int for this example)  numbers[0] is an element of this array, value in below fist example is 10 
numbers[0] = 10;
numbers[1] = 11;
numbers[2] = 12;

// Recall/Use said value stored inside any *element* of this array.
System.Console.WriteLine(numbers[0]);
System.Console.WriteLine(numbers[1]);
System.Console.WriteLine(numbers[4]);
// System.Console.WriteLine(numbers[10]); // Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
// System.Console.WriteLine(numbers[-1]); // warning CS0251: Indexing an array with a negative index (array 
// indices always start at zero)

System.Console.WriteLine(numbers); // returns: System.Int32[]

// Foreach Loop could be used 

foreach(int num in numbers)
{
    System.Console.WriteLine(num);
}

string arrString ="[";
foreach (int num in numbers)
{
    arrString += num + ",";
}
arrString = arrString.Remove(arrString.Length-1);
arrString += "]";
System.Console.WriteLine(arrString);


// Even less Important
// Multi-dimensional Arrays
int[,] twoDimArray = new int[3, 3];
twoDimArray[0, 0] = 1;
twoDimArray[0, 1] = 2;

// back to reality

//Alternative syntax for instantiating Arrays

string[] words = ["Hello", "Hi", "Hey"];
System.Console.WriteLine(words[0]);
System.Console.WriteLine(words[1]);
// can still reassign
words[1] = "Bye";
System.Console.WriteLine(words[1]); 
//Cannot add to arrays - fixed based on what was provided at time of instantiating Array
// words[4] = "Goodbye"; // Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

int[] numberArray = new int[10];
numberArray[0]=58;
numberArray[1]=25;
numberArray[2]=9;
numberArray[3]=13;
numberArray[4]=27;
numberArray[5]=102;
numberArray[6]=59;
numberArray[7]=73;
numberArray[8]=67;
numberArray[9]=39;




