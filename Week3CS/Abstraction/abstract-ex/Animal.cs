abstract class Animal
{
    public string? Species { get; set; }

    public Animal()
    {
        Species = "";
    }

    // Two types of methods you can make in abstract classes
    // Concrete methods - these methods have an Implementation.
    
    public virtual void Sleep()
    {
        System.Console.WriteLine("Animal rests to recover energy.");
    }

    // Abstract method - these methods will NOT have an Implementation and any class (that is not also abstract) will have to
    // provide that Implementation.

    public abstract void MakeSound();
    

}