interface IHerbivore
{
    public int HerbValue { get; set; }
    //"Concrete" Methods in Interfaces - "Default" Methods

    void EatPlant()
    {
        System.Console.WriteLine("The animal eats some plants");
    }
}