using System;

class Program
{
    static void Main(string[] args)
    {
        //FindMin([4,8,3,2,88,42,3,2,50]);
        //rockGame(100, 7, 5);




    }

    public static int FindMin(int[] intArray)
    {
        int min = intArray[0];

        foreach (int number in intArray)
        {
            if (number < min)
            {
                min = number;
            }
        }
        return min;
    }

    public static int rockGame(int b, int s, int t)
    {
        //track the number of rocks each takes out of the bag
        int steveTotal = 0;
        int tommyTotal = 0;

        // taking a turn involves:
        // taking out the rocks for that person
        // simultaneously check if they can take out a full set of rocks
        // if rocks left > 0, move to next person's turn
        
        while (b > 0)
        {
            // Steve's turn
            if (b > s)
            {
                b -= s;
                steveTotal += s;
            }
            else
            {
                steveTotal += b;
                // Game Over
                return steveTotal;
            }

            // Tommy's turn
            if (b > t)
            {
                b -= t;
                tommyTotal += t;
            }
            else
            {
                tommyTotal += b;
                // Game Over
                return tommyTotal;
            }
        }
        return 0;
    }
}

