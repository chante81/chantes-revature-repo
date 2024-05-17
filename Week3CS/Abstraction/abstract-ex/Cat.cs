class Cat : Animal, ICarnivore, IAdorable
{
    public string FavoriteFood { get; set; }
    public int Value { get ; set; }

    public Cat()
    {
        FavoriteFood = "";
    }
    
    public override void Sleep()
    {
        System.Console.WriteLine("Curls into fluff ball <3");
    }
    
    public override void MakeSound()
    {
        System.Console.WriteLine("Meow! Meow!");
    }

    public void EatMeat()
    {
        System.Console.WriteLine("Eats some Cat Food.");
    }
}