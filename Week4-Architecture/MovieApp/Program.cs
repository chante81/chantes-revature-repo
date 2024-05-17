using System;

class Program
{

    static void Main(string[] args)
    {
        MovieRepo mr = new();

        //LinearTest(mr);

    }

    private static void LinearTest(MovieRepo mr)
    {
        RetrievingMovie(mr); // Tested the MovieRepo - GetMovie()

        //Let's test out adding a new movie to our collection.

        AddingNewMovie(mr);

        //Let's test updating a movie in our collection.

        UpdatingMovie(mr);

        //Let's test deleting a movie in our collection.

        DeletingMovie(mr);
    }

    private static void DeletingMovie(MovieRepo mr)
    {
        // Pick a Movie -> Ask for an ID of a Movie -> Retrieve the Movie with that ID
        Movie movie = PromptUserForMovie(mr);
        System.Console.WriteLine(movie);
        // Remove that movie from our storage
        System.Console.WriteLine($"Deleted Movie: {mr.DeleteMovie(movie)}");

    }

    private static void UpdatingMovie(MovieRepo mr)
    {
        // Pick a Movie -> Ask for an ID of a Movie -> Retrieve the Movie with that ID
        Movie movie = PromptUserForMovie(mr);
        System.Console.WriteLine(movie);

        // Let the user update some fields - could add more steps to update more fields
        System.Console.WriteLine("Please provide a new Title: ");
        movie.Title = Console.ReadLine() ?? "";

        // Save those changed values to our storage
        System.Console.WriteLine($"Updated Movie: {mr.UpdateMovie(movie)}");
    }

    private static void AddingNewMovie(MovieRepo mr)
    {
        System.Console.WriteLine("Let's add in a new Movie");
        System.Console.WriteLine("Please provide a Movie Title");
        string title = Console.ReadLine() ?? "";

        System.Console.WriteLine("Please provide a price");
        double price = double.Parse(Console.ReadLine() ?? "");
        // Let's just assume that the Available will default to True and by extension the returnDate will be 0.

        //Also not going ot ask for an ID, because our MovieRepo - AddMovie already gives it the next correct value for ID.

        //Now we need to collect all of this information into a new movie Object.

        Movie movie = new(0, title, price, true, 0);
        // Now that the information is collected into a movie object, let's use the MovieRepo to add it to our data storage. 
        movie = mr.AddMovie(movie); // resuing movie variable to store the updated values, if any, from the AddMovie() process.

        // for the sake of clarity to the user of the app, LazyThreadSafetyMode inform them of the newly added movie
        System.Console.WriteLine($"Newly Added Movie: {movie}");

    }

    private static void RetrievingMovie(MovieRepo mr)
    {
        //Let's test out retrieving a movie that exists.
        //we have to make a little bit of an assumption
        //The user has to know what kind of IDs might work.

        Movie retrievedMovie = PromptUserForMovie(mr);

        System.Console.WriteLine($"Retrieved Movie: {retrievedMovie}");

    }

// Helper Method 
    public static Movie PromptUserForMovie(MovieRepo mr)
    {
        Movie? retrievedMovie = null;
        while (retrievedMovie == null)
        {
            System.Console.WriteLine("Please enter a movie ID: ");
            int input = int.Parse(Console.ReadLine() ?? "0");
            retrievedMovie = mr.GetMovie(input);
        }
        return retrievedMovie;
    }
}

