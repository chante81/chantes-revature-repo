class Parent
{
    public string JobTitle {get; set; } //property
    
    
    
    public Parent()
    {
        JobTitle = "";
    }

public Parent(string jobTitle)
{
    JobTitle = jobTitle;
}

public virtual void Work() //method
{
    System.Console.WriteLine($"Work hard all day to make money at my job as a {JobTitle}.");
}

    public override string ToString()
    {
        return "{jobTitle:" + JobTitle + "}";
    }

}