using System;

class Program
{
    static void Main(string[] args)
    {
        
        // string reverseWord = "";
        // bool isPalindrome;

        // foreach (var letter in word)
        // {
        //     reverseWord = letter + reverseWord;
        // }

        // if (reverseWord == word)
        // {
        //     isPalindrome = true;
        // }
        // else
        // {
        //     isPalindrome = false;
        // }
        //System.Console.WriteLine(isPalindrome);

        //char c = 'a';

        //System.Console.WriteLine(CharToInt(c));
        // int code;
        // foreach (char b in word)
        // {
        //     System.Console.WriteLine(b - 'a' + 1);

        // }

        // createSecretCode(word);

        //         string code = "";

        // foreach (char c in word)

        // {

        //     char d = char.ToLower(c);

        //     d = (char)(c - 'a' + 01);

        //     code = code + d;

        // }
        // System.Console.WriteLine(code);
        string word = "madam";
        createSecretCode(word);

        string code = createSecretCode(word);
        System.Console.WriteLine(code);

    }

    public static int CharToInt(char c)
    {
        // Convert the character to lowercase for simplicity
        c = char.ToLower(c);

        // Subtract the Unicode value of 'a' from the Unicode value of the character,
        // then add 1 to make 'a' correspond to 1, 'b' correspond to 2, and so on.
        return c - 'a' + 1;
    }

    public static bool checkForPalindrome(string s)
    {
        //WRITE YOUR CODE HERE
        string reverseString = "";
        //bool isPalindrome;

        foreach (var letter in s)
        {
            reverseString = letter + reverseString;
        }
        if (reverseString == s)
        {
            return true;
        }
        else
        {
            return false;
        }


    }

    // public static string createSecretCode(string s){
    //     //WRITE YOUR CODE HERE
    //     string code = "";
    //     for (int i = 0; i < s.Length; i++)
    //     {
    //         char c = s[i];
    //         c = char.ToLower(c);
    //         c = (char)(c - 'a' + 01);
    //         return code += c;
    //     }
    //     return code;     


    // }

    // public static string createSecretCode(string s){
    //     //WRITE YOUR CODE HERE
    //     string? code = "";
    //     foreach( char c in s)
    //     {
    //         char d = char.ToLower(c);
    //         d = (char)(c - 'a' + 01);
    //         string b = d.ToString();
    //         code = code + b;
    //     }
    //     return code;  
    // }
    
    
    public static string createSecretCode(string s)
    {

        //WRITE YOUR CODE HERE

        string code = "";

        foreach (char c in s)

        {

            char d = char.ToLower(c);

            var number = d - 'a' + 1;

            code = code + number.ToString("00");

        }

        return code;

    }
}