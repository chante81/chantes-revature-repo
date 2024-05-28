// using System.Linq;  unneccessary using statement, but may need to add if getting issue when attempting to use LINQ 

using System.Runtime.InteropServices;

class Program
{
    static IUserRepo ur;
    static void Main(string[] args)
    {

        /*
        Code First approach:
        Create Models and Context first, the generate migration that will hellp with translation between code and what is expected in db
        Will modify our db based on what is needed from app.

        Opposite approach is scaffold approach/DB first
        Uses Design package
        Set up DB, then run commands that scaffold project, will develop dbcontext and models

        */
        using AppDbContext context = new();
        ur = new UserRepo(context);

        //Create a new user
        // User newUser = new(0, "User2", "pass2", "user");
        // ur.AddUser(newUser);
        // ur.Save();

        // Get user by Id
        // User? u = ur.GetUser(1);
        // if (u != null)
        // {
        //     System.Console.WriteLine(u.Username);
        // }
        // else
        // {
        //     System.Console.WriteLine("User not found.");
        // }

        // u.Password = "pass123";
        // ur.UpdateUser(u);
        // ur.Save();
        // System.Console.WriteLine(u.Password);
        ur.GetAllUsers();

    }


}