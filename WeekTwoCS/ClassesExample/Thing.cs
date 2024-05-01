class Thing
{
    // Scopes - a way to measure a range of visibility or existence of a particular entity/variable.

    //Object Scope - exists within any object of this class. 
    //Each Object gets its own copy of this variable with its own value.

    public int objectNum;

    //Class Scope - belongs to the entire Class, and by extension each Object of that Class.
    //The value of Class Scoped variables remains the same between each Object.

    public static int classNum = 10;
    public static int count = 0;


    public Thing()
    {
        objectNum = 100;
        count++;
    }

    public static void StaticMethod()
    {
        System.Console.WriteLine("This is a static method!");
    }
}