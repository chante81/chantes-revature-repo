class House : Buildings
{
    public int Bedrooms {get; set; }
    public string? Owner {get; set; }


    //Constructor starts by calling parent's constructor

    public House()
    {
        System.Console.WriteLine("Now let's make that building into a House!");
        Owner = "";

    }

    // above is same as 
    /* 
    public House() : base()
    {

    }
    */

    public House(int walls, int area) : base(walls, area)
        {
            Owner = "";
            System.Console.WriteLine("Now let's make that building with an area and walls into a House.");
        }

    public House(int walls, int area, int bedrooms, string owner) : this(walls, area)
    {
        Bedrooms = bedrooms;
        Owner = owner;
    }    
    public override string ToString()
    {
        //return base.ToString(); //Calls parent class' ToString, could concatenate if desired.
        return "{walls:" + Walls 
        + ",area:" + Area 
        + ",bedrooms:" + Bedrooms 
        + ",owner:'" + Owner + "'}";
    }

}