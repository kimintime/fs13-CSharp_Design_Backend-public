namespace Models;

public class User
{
    public int UserId { get; init; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public UserType UserType { get; set; }

    public User(int userId, string username, string password, string firstName, string lastName, UserType userType) 
    {
        UserId = userId;
        Username = username;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        UserType = userType;
    }

    
}

public enum UserType {
        Librarian,
        Customer
    }