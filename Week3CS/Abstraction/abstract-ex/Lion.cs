class Lion : ICarnivore
{
    public int Value { get ; set ; }

    public void EatMeat()
    {
        System.Console.WriteLine("Eats Antelope.");
    }
}