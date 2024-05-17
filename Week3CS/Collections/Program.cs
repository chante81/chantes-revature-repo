using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        //Lists();
        //StacksAndQueues();
        //HashSets();
        //Dictionaries();


    }

    private static void Dictionaries()
    {
        /*
        Dictionaries - store Key-Value Pairs
        Two datatypes that you have to pick. One representing the Key, the other
        Real World equivalences - Dictionary, SSN -> Person
        */

        Dictionary<string, int> studentScores = []; // could be any two things - could be string, List for example

        studentScores.Add("Chante", 80);
        studentScores.Add("Emma", 95);
        studentScores.Add("Julie", 84);
        studentScores.Add("Brian", 78);
        studentScores.Add("Omar", 78);

        //System.Console.WriteLine($"Bob's socre is: {studentScores["Bob"]}"); // - cannot access key not shown. 
        // System.Collections.Generic.KeyNotFoundException: The given key 'Bob' was not present in the dictionary.

        foreach (KeyValuePair<string, int> kvp in studentScores)
        {
            System.Console.Write(kvp);
            System.Console.WriteLine(" --- " + kvp.Key + ": " + kvp.Value);
        }

        // shorter way
        foreach (var kvp in studentScores)
        {
            System.Console.Write(kvp);
            System.Console.WriteLine(" --- " + kvp.Key + ": " + kvp.Value);
        }

    }

    private static void HashSets()
    {
        /*
        Hash - a way of storing values - usally using some of the item's data to help formulate a spot for the hash
        to store the said item.

        Set - do not preserve any order of insertion
            - duplicates are not allowed.

        */

        HashSet<int> set = [1, 4502, 52, 17, 632, 27, 3, 2, 4, 1];
        set.Add(5);
        set.Add(5); // ignores duplicates.

        System.Console.WriteLine(set.Contains(4));

        foreach (int num in set)
        {
            System.Console.WriteLine(num);
        }

        HashSet<int> set2 = [2, 3, 4, 7, 10];

        HashSet<int> result = [];

        System.Console.WriteLine(string.Join(",", set));

        set.UnionWith(set2);
        System.Console.WriteLine(string.Join(",", set));
    }


    private static void StacksAndQueues()
    {
        // There are more collections than just Lists.
        // Stacks and Queues take a slightly different stragegy to data storage.
        // They see it as a holding cell where data enters in a particular order
        // An then exits (removed from collection) in a particular order.

        /*
        Stacks have a strategy -> First In, Last Out -> FILO
        Queues have a strategy -> First In, First Out -> FIFO
              
        */

        Queue<int> queue = new();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Dequeue();
        queue.Enqueue(4);

        while (queue.Count > 0)
        {
            System.Console.WriteLine($"Dequeued: {queue.Dequeue()}");
        }

        Stack<int> stack = new(); // only difference is which item comes out/handled first
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        System.Console.WriteLine($"First popped item: {stack.Pop()}");

        stack.Push(40);

        while (stack.Count > 0)
        {
            System.Console.WriteLine($"Popped: {stack.Pop()}");
        }




    }


    private static void Lists()
    {
        // Arrays have fixed size and cannot be changed. 
        // Data Structure -> Arrays
        int[] numbers = new int[5];

        // Collections

        // List -> stores all of its values inside an array. One of the most common used options to store.

        // Parameterized Class 
        // Generics - Generic Classes
        // DataType<elementType> variableName = new DataType<elementType>();

        // List<int> numbersList = new List<int>(); // full proper syntax, can be simplified using below:


        List<int> numbersList = [];

        // Add Values
        numbersList.Add(10);
        numbersList.Add(3);
        numbersList.Add(5);
        numbersList.Add(12);
        numbersList.Add(27);
        numbersList.Add(96);
        numbersList.Add(61);

        // Printing out items in a Collection

        foreach (int num in numbersList)
        {
            Console.WriteLine(num);
        }

        numbersList.Insert(0, 40); // inserts an item somewhere other than at the end

        // One-liner to print 
        System.Console.WriteLine(string.Join(",", numbersList));

        // Add multiple values at one time
        // Another list
        List<int> numbersList2 = [1, 2, 3];
        numbersList.AddRange(numbersList2);
        numbersList.InsertRange(0, [4, 5, 6]);
        System.Console.WriteLine(string.Join(",", numbersList));

        // IndexOf
        System.Console.WriteLine(numbersList.IndexOf(12));
        System.Console.WriteLine(numbersList.Contains(25));

        // Accessing an Element
        System.Console.WriteLine(numbersList[0]);

        // Remove 
        // numbersList.Remove(20); // Removes 20 from the List.
        // numbersList.RemoveAt(0); // Removes the 0-indexed element.

        numbersList.Sort();
        System.Console.WriteLine(string.Join(",", numbersList));
    }

}
