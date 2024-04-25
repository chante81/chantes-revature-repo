/*
Control Flow - fundamental aspect of programming in which the developer adds in concepts 
to further gain control over what will or will not happen within the program and/or how often. Often a condition/check 
is used to assess whether or not a chunk of code will proceed.
    - Condition --> Boolean Expression -> Any statement that evaluates to true/false
    - Example: 
        - true
        - false
        - boolean variable
        - expression: numberOfBooks > 5 -> can be evaluated to true/false
*/

/*
Conditional Statement - evaluates a Condition to determine if a chunk of code is/is not executed.

    - If Statement
        - If-Else Statements
        - If-ElseIf-Else Statements
    -Ternary Operators
    Switch-Case Statements
*/

bool isRainy = true;

if (isRainy) 
{
    System.Console.WriteLine("It is rainy outside!");
}

// Quick detour - Console Input
System.Console.WriteLine("Please enter your favorite number: ");
string input = Console.ReadLine();
System.Console.WriteLine("Your favorite number is: " + input);

// Converting data types 
// int number = input; - will not work because C# is a stronly typed language (will not convert type for you) 
// Error: Cannot implicitly convert type 'string' to 'int'CS0029

// Attempt to handle exception
// try
// {
//     int number = int.Parse(input);
// }
// catch (Exception e)
// {
//     System.Console.WriteLine("Whoops! Not a number!");
// }

int number = 0; // we need to create the number variable outside of if statement, to allow for use elsewhere (use outside of curly braces)
if (input != null)
{
    number = int.Parse(input);
}
else
{
    System.Console.WriteLine("You failed to enter a number, you suck!");
    number = -1;
}
if (number > 10)
{
    System.Console.WriteLine("Your number is greater than 10!");
}
else
{
    if(number == 10) 
    {
        System.Console.WriteLine("Your number is exactly 10.");
    }
    else 
    {
        System.Console.WriteLine("Your number is less than 10.");
    }
}

// An alternative to (most) nested conditionals
//If-Elseif-Else Statements

if (number > 10) 
{
    System.Console.WriteLine("> 10 YAY!");
}
else if (number > 5)
{
    System.Console.WriteLine("5< your number <10....yay...");
}
else
{
    System.Console.WriteLine("<= ...whaever...");
}

// Ternary Operators
// It is an alternative to simple If-Else statements where the tasks/outcomes are very similar
// (condition) ? <option if true> : <option if false>

if (number > 10)
{
    System.Console.WriteLine("Your number is greater than 10.");
}
else
{
    System.Console.WriteLine("Your number is NOT greater than 10.");
}
//Ternary example of alternative to above If-Else statement:
string phrase = "Your number is " + ((number > 10) ? "greater than 10." : "not greater than 10.");
System.Console.WriteLine(phrase);

// Switch-Case Statements
// Best used when options you want to consider are particular, finite, and/or incremental.
/* switch (variable) 
{
    case(value1): 
    {
        //some code to execute if variable == value1
    }
    case(value2):
    {
        //some code to execute if variable == value2
    }
    case(value3):
    case(value4):
    {
        //some code to execute if variable == value3 OR value4
    }
    default:
    {
        //some code to execute if variable != to any other case*
    }
}
*/

System.Console.WriteLine("Enter an option 1-4: ");
input = Console.ReadLine();
int option = 0;

if (input != null) option = int.Parse(input);

switch(option)
{
    case 1:
        System.Console.WriteLine("you have chosen option 1. You win $1.");
        break;
    case 2:
        System.Console.WriteLine("you have chosen option 2. You win $20.");
        break;
    case 3: 
    case 4:
        System.Console.WriteLine("you have chosen option 3 or 4. You win $4,000.");
        break;
    default:
        System.Console.WriteLine("you did not choose an option 1 - 4. You lose $500.");
        break;

}