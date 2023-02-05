namespace Models;

public class UserReview
{
    public string UserText { get; set; }
    public User User { get; set; }
    public Book Book { get; set; }

    public UserReview(string userText, User user, Book book)
    {
        UserText = userText;
        User = user;
        Book = book;
    }
}
