using Microsoft.Data.SqlClient;

class UserRepo
{

    private readonly string _connectionString;

    //Dependency Injection -> Constructor Injection
    public UserRepo(string connString)
    {
        _connectionString = connString;
    }



    //add, get-one, get-all, update, and delete
    public User AddUser(User u)
    {
        //Set up DB Connection
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        //Create the SQL String
        string sql = "INSERT INTO dbo.[User] OUTPUT inserted.* VALUES (@Username, @Password, @Role)";

        //Set up SqlCommand Object and use its methods to modify the Parameterized Values
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@Username", u.Username);
        cmd.Parameters.AddWithValue("@Password", u.Password);
        cmd.Parameters.AddWithValue("@Role", u.Role);

        //Execute the Query
        // cmd.ExecuteNonQuery(); //This executes a non-select SQL statement (inserts, updates, deletes)
        using SqlDataReader reader = cmd.ExecuteReader();

        //Extract te Results
        if (reader.Read())
        {
            //If Read() found data -> then extract it.
            User newUser = BuildUser(reader);
            return newUser;
        }
        else
        {
            //Else Read() found nothing -> Insert Failed. :(
            return null;
        }
    }

    public User GetUser(int id)
    {
        try
        {
            // Set up the DB connection
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            // Create the SQL String
            string sql = "SELECT * FROM dbo.[User] WHERE @id = id";

            // Set up the SqlCommand Object
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@id", id);

            // Execute the query
            using var reader = cmd.ExecuteReader();  // using var instead of sqlDataReader

            // Extract the results
            while (reader.Read()) //as long as data continues to be read
            {
                // for each iteration -> extract the results to a User Object
                User user = BuildUser(reader);
                // Don't return, add to list
                return user;
            }

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
    }

    public List<User> GetAllUsers()
    {
        List<User> users = [];

        try
        {
            // Set up the DB connection
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            // Create the SQL String
            string sql = "SELECT * FROM dbo.[User]";

            // Set up the SqlCommand Object
            using SqlCommand cmd = new(sql, connection);

            // Execute the query
            using var reader = cmd.ExecuteReader();  // using var instead of sqlDataReader

            // Extract the results
            while (reader.Read()) //as long as data continues to be read
            {
                // for each iteration -> extract the results to a User Object
                User newUser = BuildUser(reader);
                // Don't return, add to list
                users.Add(newUser);
            }
            return users;
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }

    }

    public User UpdateUser(User updatedUser)
    {
        // Set up the DB connection
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        // Create the SQL String
        string sql = "";

        // Set up the SqlCommand Object
        using SqlCommand cmd = new(sql, connection);

        // Execute the query
        using var reader = cmd.ExecuteReader();  // using var instead of sqlDataReader

        // Extract the results
    }

    public User DeleteUser(User u)
    {
        // Set up the DB connection
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        // Create the SQL String
        string sql = "DELETE FROM dbo.[User] WHERE @userId = @u ";

        // Set up the SqlCommand Object
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@userId", u.Id);
        cmd.Parameters.AddWithValue("@id", id);

        // Execute the query
        using var reader = cmd.ExecuteReader();  // using var instead of sqlDataReader

        // Extract the results
    }

    // Helper Method
    private static User BuildUser(SqlDataReader reader)
    {
        User newUser = new();
        newUser.Id = (int)reader["Id"];
        newUser.Username = (string)reader["Username"];
        newUser.Password = (string)reader["Password"];
        newUser.Role = (string)reader["Role"];
        return newUser;
    }
}