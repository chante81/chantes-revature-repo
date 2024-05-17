/*

Variables - are designed to hold data/information
within our application for additional later use.

Variable Declaration - We are telling our application to create this variable in memory.

Syntax: DataType nameOfVariable;

Data Types - indicate what kind of information is allowed to be stored within that particular variable
"Primitive" Data Types - C# refers to Primitives as "Structs"
    - Serve ONE purpose. Holding a single value.
    - In C# we call these value-types (vs reference types)
    - Numberical value-types: (sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal)
    - Non-numerical: (char, bool, enum, struct)

- Name of variable should not be the name of any keyword (ex: decimal, if, etc.), should not start with a number,
  and should be in camelCasing

this line is just a declaration (creating the variable)
int numberOfBooks;

this line is to assign the variable
Syntax: variableName = some-value;
numberOfBooks = 10; 

Console.WriteLine(numberOfBooks); 

// Variable Declarataion and Assignment
double money = 2.50;
System.Console.WriteLine(money); // CW shortcut - hit ENTER // - c/o line

// = -> Assignment Operator

// Basic Operations:
int num = 1 + 2;
num = 1 - 2; // cannot declare as integer more than once, also cannot change to another type in CS - CS is static language
System.Console.WriteLine(num);
num = 1 * 3;
System.Console.WriteLine(num);
num = 1 / 3; // Integer Division - no decimal places 
System.Console.WriteLine(num);
num = 1 % 3; // Modulus
System.Console.WriteLine(num);

double num2 = 1 / 3;
double num3 = 1 / 3.0;
float num4 = 1 / 3;

System.Console.WriteLine("double num2 not dividing by decimal: " + num2);
System.Console.WriteLine("double num3 dividing by decimal: " + num3);
System.Console.WriteLine("float num4 not dividing by decimal: " + num4);

System.Console.WriteLine(1 / 3.0);
System.Console.WriteLine(0.1 + 0.2);

// Augmented (Compound) Assignment Operators

// What if I want to perform a calculation on a variable AND store that result back into the variable?

int num5 = 10;
int result = num5 * 3;

System.Console.WriteLine(result);

// Augmented Assignment Operator
num5 += 5; // exactly the same as num5 = num5 + 5;
num5 -= 5; // exactly the same as num5 = num5 - 5;
num5 *= 2; // exactly the same as num5 = num5 * 5;
num5 /= 2; // exactly the same as num5 = num5 / 5;
num5 %= 2; // exactly the same as num5 = num5 % 5;

// Increment/Decrement Operators

System.Console.WriteLine(num5);
System.Console.WriteLine(num5 ++); // Post-Increment - increments after it is prints (prints num5 then adds one)
System.Console.WriteLine(num5);
System.Console.WriteLine(++ num5); // Pre-Increment - increments before it is printed

// Boolean - value-type that stores either 'true' OR 'false'

bool isSunny = true;
bool isRainy = false;
System.Console.WriteLine(isSunny);
System.Console.WriteLine(isRainy);

// ! --> Negation Operator - change the boolean into it's opposite value

System.Console.WriteLine(!isSunny);

isSunny = !isSunny; // A toggle --> switch isSunny's value to the other boolean value
System.Console.WriteLine(isSunny);
isSunny = !isSunny;

// Relational Operators - compare one value to another value. Binary Operator (vs Unary)
// ==, !=, <, >, <=, >=

System.Console.WriteLine(5 == 5); // Boolean expression --> evaluates to True or False

// Get Ahead - study tip: Logical Operators, Conditional Statements, loops

// Other Topics - Strings, Concatenation, Maybe Lists...

bool SecondOperand()
{
    Console.WriteLine("Second operand is evaluated.");
    return true;
}

bool a = false & SecondOperand();
System.Console.WriteLine(a);
// Output:
// Second operand is evaluated
// False

bool b = true & SecondOperand();
System.Console.WriteLine(b);
// Output:
// Second operand is evaluated
// True

bool c = true; 
bool d = false;
bool e = c & d;
System.Console.WriteLine(e);

System.Console.WriteLine(c & isSunny);
*/
// decimal x = 42.1M;
// decimal y = 53.5M;
// decimal z = x + y;
// System.Console.WriteLine($"The answer is {z}");

    {
        int busTotal = 1;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int getIn = int.Parse(inputs[0]);
            int getOff = int.Parse(inputs[1]);
            busTotal += getIn;
            busTotal -= getOff;
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(busTotal);
    }
