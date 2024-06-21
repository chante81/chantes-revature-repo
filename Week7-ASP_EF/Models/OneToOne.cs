namespace EFCoreExample.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        // This establishes a relationship to the other entity
        public Profile Profile { get; set; }
    }

    public class Profile
    {
        public int ProfileId { get; set; }
        public string Bio { get; set; }

        // As profile contains the foreign key for the User
        // We need to provide a field for the key inside the profile class
        public int UserId { get; set; }
        public User User { get; set; }
    }


    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

