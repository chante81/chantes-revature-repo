class Dog : Animal, ICarnivore, IAdorable
{
    public string FavoriteChewToy { get; set; }
    public int Value { get; set; }

    public Dog()
    {
        FavoriteChewToy = "";
    }

    public override void MakeSound()
    {
        System.Console.WriteLine("Bark! Bark! Bark! Bark!");
    }

    public void EatMeat()
    {
        System.Console.WriteLine("Eats puppy chow.");
    }
}