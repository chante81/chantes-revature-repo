class Buildings
{
    public int Walls {get; set; }
    public int Area {get; set; }

    
    public Buildings()
    {
        System.Console.WriteLine($"Constructing a new building.");
    }

    public Buildings(int walls, int area)
    {
        Walls = walls;
        Area = area;
        System.Console.WriteLine($"Constructing a new building with {walls} walls and {area} area.");
    }

    public override string ToString()
    {
        return "{walls:" + Walls + ",area:" + Area + "}";       
    }

}