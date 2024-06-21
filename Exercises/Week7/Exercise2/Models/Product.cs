namespace ProductAPI.Models;

public class Product
{
    public int ProductId {get;set;}
    public string ProductName {get;set;}
    public bool Available {get;set;}

    public Product(int ProductId, string ProductName, bool Available)
    {
        this.ProductId = ProductId;
        this.ProductName = ProductName;
        this.Available = Available;
    }

}