class Book
{
    /*
    General Structure to Models:
        - fields (properties)
        - constructors
        - methods

    Vocab of the Day: Encapsulation
    - Hiding/Protecting our data to further control who has access
    -This is not to "secure or encrypt" our data.
    - Make private fields (implied unless explicitly updated to public)
    - Make public methods for accessing and manipulating those fields.
        - Accessing the field: Accessors -> Getters
        -Modifying the field: Modifiers/Mutators -> Setters

        Alternative to fields and getters and setters is to use Properties
    */

/*
    string title;
    string author;
    int pages;
*/

    // Alternative - Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }

    // Constructors
    
    public Book()
    {

    }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    // Getters and Setters
/*
    public string GetTitle()
    {
        return title;
    }
    public void SetTitle(string title)
    {
        this.title = title;
    }
*/

    // ToString
    public override string ToString()
    {
        string str = "";

        str += $"Title: {Title} ";
        str += $"Author: {Author} ";
        str += $"Pages: {Pages}" ;
        
        return str;
    }

} 
