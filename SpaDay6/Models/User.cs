namespace SpaDay6.Models;

public class User
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime Date { get; }
    public int Id { get; }
    private static int nextId = 1;

    public User()
    {
        Date = DateTime.Now;
        Id = nextId;
        nextId++;
    }
    public User(string username, string email, string password) : this()
    {
        Username = username;
        Email = email;
        Password = password;
    }
}