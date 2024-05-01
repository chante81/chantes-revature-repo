/*
Control Flow  (controls the flow of the application) - Loops --> Allows us to execute a chunk of code for as long as the 
condition continues to be true.
    - the condition is reassessed after each "iteration" of the loop, before executing the loop again.

    - While Loop
        - Do-While Loop
        - Best used when the number of iterations needed by the loop is not known/non-deterministic.

    - For Loop
        - Foreach Loop
        - Best used when the number of iterations needed by the loop is known/calculable. Finite.
*/

// Print the numbers 1 - 100.
/*
while (condition)
*/
int counter = 1;
while(counter <= 100)
{
    System.Console.Write(counter + ", ");
    counter++;
}

// Print the sum of the numbers 1 - 1000000:
counter = 1;
long end = 1000000;
long sum = 0;
while(counter <= end)
{
    sum += counter;
    counter++;
}
System.Console.WriteLine("\nThe sum of the numbers 1 - " + end + " is " + sum);

/*
Guessing Game - Make new project
    - Start with assumed range of numbers 1-100
    - Prompt user to enter number within range
    - Tell the user if the number is higher, lower, or equal to <some number of your choice>
        - If equal, they win the guessing game! 
        - If higher or lower, let them guess again! 
        - The while loop essentially needs to contain
            - prompting the user
            - retreiving their guess
            - telling them higher, lower, or correct
            - while (guess != correct choice) -> run the loop again

    Bonuses:
        -Introduce yourself to the Random Class, to help you randomize the correct answer
        -The user is prompted to play again without having to restart the application
            - Hint: Involved (likely) another (outer) while loop

*/

// Input Validation

// Tell the user to print out the number: 5

int num = 0;
while(num != 5)
{
System.Console.WriteLine("Please input the number: 5");
string input = System.Console.ReadLine();

if (input != null) num = int.Parse(input);

if (num != 5)
{
    System.Console.WriteLine("Please try again!");
}
}

// Down here is for when the loop is done
System.Console.WriteLine($"You finally got it correct! You Entered: {num}");

// Do-While Loop
// Do-While Loops, as opposed to just while loops, will always execute at least once before catching the condition.
/*
do
{
    //whatever we want the loop to do 
}
while (condition);
*/

// Rebranding the last example into a do-while loop
do
{
    System.Console.WriteLine("Do: Please input the number: 5");
    string input = System.Console.ReadLine();

    if (input != null) num = int.Parse(input);

    if (num != 5)
    {
        System.Console.WriteLine("Do: Please try again!");        
    }
}
while(num != 5);
System.Console.WriteLine($"Do: You finally got it correct! You Entered: {num}");

// For Loops
/* Best used when number of iterations is known or calculable. Update occurs at end of iteration before starting initialization again.
for (initialization; condition; update)
{
    // some line of code 
}
*/

// Print the numbers 1 - 100
for(int count = 1; count <= 100; count++)
{
    System.Console.Write($"{count}, ");
}
System.Console.WriteLine(" ");
// Print the Sum of the numbers 1 - 10000
int sum2 = 0;
for(int count = 1; count <= 10000; count++) //count used before, but no error this time. 
//this is because it only belongs to this for loop. count is declared in loop, not used globally
{
    sum2 += count;
}
System.Console.WriteLine(sum2);

// ----------------------------------------ASSIGNMENT----------------------------------------------

// Print only even numbers 2 - 200

for(int count = 2; count <= 200; count += 2)
{
    System.Console.Write($"{count}, ");
    System.Console.Write(count + ", ");
}

System.Console.WriteLine("\n");

// Print all numbers starting with 50 going to 25
for(int count = 50; count >= 25; count--)
{
    System.Console.Write($"{count}, ");
}
System.Console.WriteLine("\n");

//Nesting Loops
/*
    - Any control flow statement can be coded/nested into any other control flow.
        - Therefore loops can be built inside other looops
        -However, we should exercise caution, we could potentially develop scenarios that will drastically increase
        processing time.
    -Problem:
        - Single Loop -> 100 iterations -> 100 Processes
        - Nested Loop -> 100 iterations inside 100 iterations -> 10,000 Processes
        - Quadratic Growth of Time
*/

// Build a Square out of '*' of whatever size we want.
System.Console.WriteLine("-------------------------------------");
int size = 4;

for(int i = 1; i <= size; i++)
{
    for(int j = 1; j <= size; j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("-------------------------------------");
// Staircase Challenge
// Print 1 '*' for the 1st row. Then 2 '*'s for the 2nd row, etc...
size = 4;
// The outer loop deals with printing additional rows/"steps"
for(int i = 1; i <= size; i++)
{
    // The inner loop deals with managing the contents of each row/"step". Take square code and change size to i, to print
    // amount per iteration (i) -> increments per round of loop
    for(int j = 1; j <= i; j++)
    {
        System.Console.Write("*  ");
    }
    System.Console.WriteLine();
}

// Staircase Challenge (cont.)
// There are 3 other directions that the staircase can "face"
// Build them all. 
/*
1. 
     *
    **
   ***
  ****
2. 
  ****
  ***
  **
  *
3. 
  ****
   ***
    **
     *
*/
// Afterwards - try to solve any of them with a single loop

/* Bonus Bonuses to Guessing Game: 
    - Adjust the range in which you tell the user to guess based on their previous wrong answers
    - Allow the user to pick the numbers that they will guess between when the game starts: (1 - 1000 or 25 - 432)
    - Keep track of the number of guesses, tell them how many guesses they took at the end of the game.
*/
// Foreach Loop
// Best used when iterating (once) over each item of a collection of values.

// Before foreach
string word = "Hello";
for (int i = 0; i < word.Length; i++)
{
    System.Console.WriteLine(word[i]);
}
System.Console.WriteLine();
// Foreach Loop
foreach (char c in word)
{
    System.Console.WriteLine(c);
}

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

int max = 0;

foreach (int number in numberArray)
{
    if (number > max)
    {
        max = number;
    }
}
System.Console.WriteLine(max);