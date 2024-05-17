class Calculator
{
    
/*
Polymorphism -> Many Forms -> an entity can exist with multiple labels attached to it all at the same time.

Static Polymorphism - Overloading 
    - Can have multiple methods with the same name, the only requirement is that they each have a unique set of parameters
    (based strictly off of Data Types).
        - change the quantity
        - change the type
        - change the permutation (order)

Dynamic Polymorphism - Overriding
    - Can change the implementation of methods that we inherit into a new Child Class to fit the narrative of our new Class.
        - C# does require for you to specify that a method can be overridden                       - virtual
        - and by extension, you must explicitly declare that you are overriding an implementation  - override

    
*/

public static int Add(int num1, int num2)
{
    return num1 + num2;
}

// Both versions of this method can exist at the same time.
//Because C# can always identify which version of the Add() we'd want to use at any given moment in time.
public static int Add(int num1, int num2, int num3)
{
    return num1 + num2 + num3;
}

// public static int Add(int value1, int value4) //problemnatic because it's taking 2 ints like the first one - exact same params.
// {
//     return value1 + value4;
// }

public static double Add(string num1, double num2)
{
    return double.Parse(num1) + num2;
}
//Difference between the above and below is the order
public static double Add(double num1, string num2)
{
    return num1 + double.Parse(num2);
}

public static int Add()
{
    return 0;
}

//what if we wanted to add 5 numbers, or 10, or 17? Do we need a new method for each combo?
// No!

public static int Add(int[] array)
{
    int sum = 0;
    foreach(int num in array)
    {
        sum += num;
    }
    return sum;
}

// params -> parameter array argument. Essentiall lets you provide a variable number of arguments to satisfy this one parameter,
//in which it will 'collect' them into one array for us. You can only have 1 parameter array per method
//it must be the last parameter in the method.

public static double Add(params double[] array)
{
    double sum = 0;
    foreach (double num in array)
    {
        sum += num;
    }
    return sum;
}

}