class MovieRepo
{
    /* 
        This class is in the Data Access / Repository layer of our application.

        Solely responsible for any data access and management centered around our Movie object.

        4 major operations we'd like to manage in this location. CRUD Operations:
            - C - Create
            - R - Read
            - U - Update
            - D - Delete

        Default to create all operations and use as/if needed.

    */

    MovieStorage movieStorage = new();

    public Movie AddMovie(Movie m)  //could leave as void to not return anything to the user, could replace with int and return id, 
                                    //could replace with Movie and return details of Movie. gives most flexiblity to those using 
                                    //this method
    {
        // First need to ensure movie being added is to make sure has correct id. First step, assume it doesn't, force it to 
        // have correct id using idCounter.
        m.Id = movieStorage.idCounter++; //incrementing the value afterwards to prep it for next time it's needed

        // Add movie into our collection
        movieStorage.movieInventory.Add(m.Id, m);
        return m;

    }

    public Movie? GetMovie(int id)
    {
        if (movieStorage.movieInventory.ContainsKey(id))
        {
            return movieStorage.movieInventory[id];
        }
        else
        {
            System.Console.WriteLine("Invalid Movie ID. Please try again.");
            return null;
        }
    }

    public Movie? UpdateMovie(Movie updatedMovie)
    {
        //Assuming that the ID is consistent with an ID that exists, then we only have to update the value (aka Movie object found in MovieStorage) for 
        //said key (ID) within the Dictionary.
        try
        {
            movieStorage.movieInventory[updatedMovie.Id] = updatedMovie;
            // Choosing to send updated movie back as feedback to the method.
            //method returning result of method
            return updatedMovie;
        }
        catch (Exception)
        {
            System.Console.WriteLine("Invalid Movie ID. Please try again.");
            return null;
        }
    }

    public Movie? DeleteMovie(Movie m)
    {
        // If we have the ID -> then simply Remove it from storage
        bool removed = movieStorage.movieInventory.Remove(m.Id);

        if (removed)
        {
            return m; //returns movie that got deleted
        }
        else
        {
            System.Console.WriteLine("Invalid Movie ID. Please try again.");
            return null;
        }
    }

}