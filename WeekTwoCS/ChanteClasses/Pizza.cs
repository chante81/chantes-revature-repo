class Pizza
{
    public string size;
    public string crust;
    public string cheese;
    public string sauce;
    public string doneness;
    public string topping1;
    public string topping2;
    public string topping3;
    public string topping4;
    public string topping5;
    public string topping6;
    public string topping7;
    public string topping8;
    public string topping9;
    public string topping10;


    //no args constructor
  /*  public Pizza()
    {

    }

    //full args constructor
    public Pizza(string size, string crust, string cheese, string sauce, string doneness, string topping1, string topping2, string topping3, string topping4, string topping5, string topping6, string topping7, string topping8, string topping9, string topping10)
    {
    this.size = size;
    this.crust = crust;
    this.cheese = cheese;
    this.sauce = sauce;
    this.doneness = doneness;
    this.topping1 = topping1;
    this.topping2 = topping2;
    this.topping3 = topping3;
    this.topping4 = topping4;
    this.topping5 = topping5;
    this.topping6 = topping6;
    this.topping7 = topping7;
    this.topping8 = topping8;
    this.topping9 = topping9;
    this.topping10 = topping10;
    }
*/
    public override string ToString()
    {
        string str = "";
        str += $"{{Size: '{size}' ";
        str += $"Crust: '{crust}' ";
        str += $"Cheese: '{cheese} ";
        str += $"Sauce: '{sauce} ";
        str += $"Doneness: '{doneness}' ";
        str += $"Topping 1: '{topping1}' ";
        str += $"Topping 2: '{topping2}' ";
        str += $"Topping 3: '{topping3}' ";
        str += $"Topping 4: '{topping4}' ";
        str += $"Topping 5: '{topping5}' ";
        str += $"Topping 6: '{topping6}' ";
        str += $"Topping 7: '{topping7}' ";
        str += $"Topping 8: '{topping8}' ";
        str += $"Topping 9: '{topping9}' ";
        str += $"Topping 10: '{topping10}' ";

        return str;
    }


}
