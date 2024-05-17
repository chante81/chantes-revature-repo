class Bird : Animal
{
    public string Home { get; set; }

    public Bird()
    {
        Home = "";
    }
    public override void MakeSound()
    {
        System.Console.WriteLine("Chirp! Chirp! Chirp!");
    }
}