using System.Runtime.CompilerServices;

namespace grocery;

class Program
{
    static void Main(string[] args)
    {
        List<string> groceryList = [];
        bool addToGroceryList = true;

        while (addToGroceryList == true)
        {
        Console.WriteLine("Enter an item to add to the grocery list");  
        groceryList.Add(Console.ReadLine());
        Console.WriteLine("Do you want to add another item? Y/N");
        string addItem = (Console.ReadLine());  
        if (addItem == "Y" || addItem == "y")
        {
            addToGroceryList = true;
        }
        else
        {
            addToGroceryList = false;
        }
        } 
        Console.WriteLine("Do you want to view your Grocery List? Y/N");
        string viewGroceryList = Console.ReadLine();
        if (viewGroceryList == "Y" || viewGroceryList == "y")
        {
            foreach(string item in groceryList)
                System.Console.WriteLine($"{item}, ");
        }
    }
}
