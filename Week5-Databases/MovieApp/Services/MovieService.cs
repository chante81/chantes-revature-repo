class MovieService
{
    /*
        Services:
            - Check out Movie
            - Check in Movie
            - Get (Your) Checked out Movies (not the view, just retrieval of data)
            - Get Available Movies

        Trivial Services:
            - Remember why we organize our application into layers. 
                - Allows us to organize and clearly conceptualize the flow of operations within the app at any given moment in time
            - We like to have the app always flow up and down one layer at a time
    */
    MovieRepo mr = new();

    // m is the movie we want to try to check out
    public Movie Checkout(Movie m)
    {
        // Let's first check to see if the movie is available
        // OR lets return null if it's not available - get that out of the way.
        if (!m.Available)
        {
            System.Console.WriteLine("Movie Currently Unavailble.");
            return null; // Movie doesn't get checked out
        }
        // Happy path Execution -> Movie is good to go and can be checked out
        // What does it actually mean to check out the movie?
        //1. The movie becomes unavailable
        //2. a return Date is set
        //3. (Optional) - it's set to a particular user
        // Make sure to update the data storage with these changes

        m.Available = false;
        m.ReturnDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + (60 * 60 * 48);
        // m.ReturnDate = DateTimeOffset.UtcNow.AddDays(14).ToUnixTimeSeconds();

        mr.UpdateMovie(m);
        return m;  // I am choosing to send back the checked out movie. Your choice. 

    }

    public List<Movie> GetAvailableMovies()
    {
        // Get All Movies
        List<Movie> allMovies = mr.GetAllMovies();
        // Filter out Movies you don't want
        List<Movie> availableMovies = new();
        // run a loop over all movies to see if they make the cut to be added to filtered list
        foreach (Movie m in allMovies)
        {
            if (m.Available == true) // could also say if (m.Available)  - bools are if true
            {
                availableMovies.Add(m);
            }
        }
        // Retrun filtered List
        return availableMovies;
    }
}