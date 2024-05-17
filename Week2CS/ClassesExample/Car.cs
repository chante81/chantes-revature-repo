class Car
{
    //Fields
    public string color;
    public string make;
    public string model;
    public int year;
    public int mileage;


    /*
    Constructors - a special type of method whose purpose is to help us create new objects of that class. Along with any other 
    initial setup instructions we wish to provide.

    Syntax:
    access_modifier ClassName(Potential params)
    {
        //what you want the constructor to do while setting up your object.
            - setting initial values is common
    }

    C# will provide a "default" constructor when you do not explicitly create any constructors. As soon as you create even one 
    constructor, the default constructor is no longer provided.

    */
    //has no listed return type - no argument constructor
    public Car()
    {
        color = "Black";
    }

    // We can have multiple constructors - the only requirement is that the parameters have to be some 
    // unique combination of types.

    // Overloaded Methods -> Have multiple implementations to the same named method - with different params.

    public Car(string color)
    {
        //color = newColor; 
        this.color = color;
    }

    // full argument constructor - meaning a choice for us to provied all values for our fields.
    public Car(string color, string make, string model, int year, int mileage)
    {
        this.color = color;
        this.make = make;
        this.model = model;
        this.year = year;
        this.mileage = mileage;
    }

    // Bonus
    // Copy Consttuctor - takes in an object of that class
    public Car(Car other) //sometimes other or new are used instead of matching name of class/object
    {
        color = other.color;
        make = other.make;
        model = other.model;
        year = other.year;
        mileage = other.mileage;
    }


    //Methods
    public void Honk()
    {
        System.Console.WriteLine("Honk! Honk!");
    }

    public void Drive(int milesDriven)
    {
        mileage += milesDriven;
        System.Console.WriteLine($"The new total mileage is {milesDriven}.");
    }

    public string DisplayInfo()
    {
        string str = "";
        str += "{Color=" + color;
        str += "; Make=" + make;
        str += "; Model=" + model;
        str += "; Year=" + year;
        str += "; Mileage=" + mileage + "}";

        return str;
    }

    public override string ToString()
    {
        string str = "";
        str += $"{{Color='{color}' ";
        str += $"Make='{make}' ";
        str += $"Model='{model}' ";
        str += $"Year='{year}' ";
        str += $"Mileage='{mileage}'}} ";

        return str;
    }

}