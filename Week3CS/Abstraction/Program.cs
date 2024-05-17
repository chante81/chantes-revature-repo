namespace Abstraction;

class Program
{
    static void Main(string[] args)
    {
        // intention over implementation - we care more about what it does vs how it does it
    System.Console.WriteLine("------DOG-----");
    Dog d = new();
    d.Sleep();
    d.MakeSound();
    d.Species = "Border Collie";
    d.FavoriteChewToy = "Bone"; // specific to Dogs
    d.EatMeat();
    d.Value = 100;
    System.Console.WriteLine(d.Value);
    System.Console.WriteLine("------BIRD-----");
    Bird b = new();
    b.MakeSound();
    b.Sleep();
    b.Home = "Bird cage";
    System.Console.WriteLine("------CAT-----");
    Cat c = new();
    c.FavoriteFood = "Mice";
    c.Sleep();
    c.MakeSound();
    c.EatMeat();
    c.Value = 80;
    System.Console.WriteLine(c.Value);
    // c.Home = ""; // cannot access method from Bird class, cannot inherit properties from other sub classes.
    System.Console.WriteLine("------LION-----");
    Lion l = new();
    l.EatMeat();
    l.Value = 1;
    System.Console.WriteLine(l.Value);
    l.Value = 21;
    System.Console.WriteLine(l.Value);

    System.Console.WriteLine("------ELEPHANT-----");
    IHerbivore e = new Elephant(); // Seems to be the only way to use a concrete interface method
    e.HerbValue = 2;
    e.EatPlant();
    
    Animal[] animals = new Animal[4]; //creates an array that can hold animals
    animals[0] = d;
    animals[1] = c;

    IAdorable[] adorables = new IAdorable[3];
    adorables[0] = d;
    adorables[1] = c;


    TeddyBear bear = new();

    adorables[2] = bear;


    


    }
    
}
