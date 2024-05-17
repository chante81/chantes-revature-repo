class MovieStorage
{
    /*
        This entire setup is temporary. We do not know how to work or communicate with databases yet.

        So, we are going to build some devices for storing Movies. 
        Everything is lost each time app shuts down (no persistent storage yet).

        Need a collection to work with for easy management. 
    */ 

    public Dictionary<int, Movie> movieInventory;
    public int idCounter = 101;

    public MovieStorage()
    {
        Movie movie1 = new(idCounter++, "Iron Man", 19.99, true, 0);
        Movie movie2 = new(idCounter++, "Spider Man", 24.99, true, 0);
        Movie movie3 = new(idCounter++, "The Avengers", 19.99, true, 0);

        movieInventory = []; //Sets dictionary to empty collection.

        movieInventory.Add(movie1.Id, movie1);
        movieInventory.Add(movie2.Id, movie2);
        movieInventory.Add(movie3.Id, movie3);

    }


}