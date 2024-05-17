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
    
    Bonus Bonuses to Guessing Game: 
    - Adjust the range in which you tell the user to guess based on their previous wrong answers
    - Allow the user to pick the numbers that they will guess between when the game starts: (1 - 1000 or 25 - 432)
    - Keep track of the number of guesses, tell them how many guesses they took at the end of the game.
*/
System.Console.WriteLine("------------------------------------------------------");
/*
// Declare Random class and declare playGame and answer variables 
string playGame = "null";
Random answer = new Random();
//initiate loop to ask user to play game
while(playGame == "null")
{
    System.Console.WriteLine("Do you want to play the Guessing Game? Y/N");
    playGame = Console.ReadLine();
    if (playGame == "N")
    {
        System.Console.WriteLine("I didn't want to play anyways...");
        break;
    }
    else if (playGame == "Y"); //starting game, converting answer to int and declaring guess variable
    {
        int randomAnswer = answer.Next(1, 100);
        //Console.WriteLine(randomAnswer); // Commented out - used to verify loop was working 
        int guess = 0;

        System.Console.WriteLine("YAY! Pick a number from 1 to 100.");
        string input = Console.ReadLine();
        if (input != null) guess = int.Parse(input);

        if (guess != randomAnswer)
        {
            System.Console.WriteLine("That is not correct.");
            
            while(guess != randomAnswer) // loop to cycle user through to find the correct answer
            {
                if(guess > randomAnswer)
                {
                    System.Console.WriteLine("Your number is too high, try again.");
                    input = Console.ReadLine();
                    if (input != null) guess = int.Parse(input);
                }
                else if(guess < randomAnswer)
                {
                    System.Console.WriteLine("Your number is too low, try again.");
                    input = Console.ReadLine();
                    if (input != null) guess = int.Parse(input);
                }
            }
        }
        if (guess == randomAnswer) // else if did not work - not sure why. also had to move this here, not at the beginning
        {
            playGame = "null";                
            System.Console.WriteLine("CONGRATULATIONS!! You got it right!");
        }

    }
}    

*/

System.Console.WriteLine("-------------------------------------------------------------");


// Staircase Challenge
// Print 1 '*' for the 1st row. Then 2 '*'s for the 2nd row, etc...
/*

*
**
***
****

*/
System.Console.WriteLine("Nested Loop Solution");
int size = 5;
// The outer loop deals with printing additional rows/"steps"
for(int i = 1; i <= size; i++)
{
    // The inner loop deals with managing the contents of each row/"step". Take square code and change size to i, to print
    // amount per iteration (i) -> increments per round of loop
    for(int j = 1; j <= i; j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Testing one loop solution");
for(int i = 1; i <= size; i++)
{
    string stair = "*";
    System.Console.WriteLine(string.Concat(Enumerable.Repeat(stair,i)));
}



System.Console.WriteLine("----------------------");

// Staircase Challenge (cont.)
// There are 3 other directions that the staircase can "face"
// Build them all. 
/*
1. 
     *
    **
   ***
  ****
*/
size = 4;
// set i = 1, if i less than or equal to size, process inside and add 1 to i (prints rows equal to size)
for(int i = 1; i <= size; i++)
{
    for(int j = size; j > i; j--)
    {
        System.Console.Write(" ");
    }
    
    for(int k = 1; k <= i; k++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("----------------------");
/*
2. 
  ****
  ***
  **
  *
*/
size = 4;

for(int i = 1; i <= size; i++)
{
    int k = size + 1;
    for(int j = k; j > i; j--)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("----------------------");
/*
3. 
  ****
   ***
    **
     *
*/

size = 4;

for(int i = 1; i <= size; i++)
{
    for(int j = 1; j <= i; j++)
    {
        System.Console.Write(" ");
    }
    //int k = size + 1;
    for(int j = size + 1; j > i; j--)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("----------------------");

for (int i = 0; i<= size; i++)
{
    for(int j = 1; j<= i; j++)
    {
        Console.Write(" ");
    }
    for (int k=1; k<=size-i; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


// Afterwards - try to solve any of them with a single loop


