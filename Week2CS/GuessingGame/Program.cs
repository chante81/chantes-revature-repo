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
        int randomAnswer = answer.Next(1, 101);
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
        playGame = "null";                
        System.Console.WriteLine("CONGRATULATIONS!! You got it right!");
    }
}   