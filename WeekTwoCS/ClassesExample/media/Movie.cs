namespace Media
{
    class Movie
    {
        public string Title { get; set; }
        public int Rating { get; set; }


        public Movie()
        {
            Title = "";
        }

        public Movie(string title, int rating)
        {
            Title = title;
            Rating = rating;
        }


    }
}