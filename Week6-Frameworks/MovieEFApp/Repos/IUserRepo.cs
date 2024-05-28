/*
    Coding to interfaces - practice wherein we will start these "classes" that are functionality focused
    (Repos, Services, Controllers, etc.)
    we will opt to outline their functionality through an interface first.

    The overall goal is to promote flexibility/resuability. If we ever need to change implementations, you
    can simply create a new class that implements the same interface thereby letting us know it will service 
    all the same intentions.
*/



interface IUserRepo
{
    public void AddUser(User u);

    public User? GetUser(int id);

    public List<User> GetAllUsers();

    public void UpdateUser(User u);

    public void DeleteUser(int id);

    public void Save();  //Necessary for EF Core - Saves changes to database
}