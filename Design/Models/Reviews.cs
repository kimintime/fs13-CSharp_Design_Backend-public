namespace Models;

public class UserReview
{
    public string UserText { get; set; }
    public User User { get; set; }
    public Book Book { get; set; }
    public ReviewType ReviewType { get; set; }

    public UserReview(string userText, User user, Book book, ReviewType reviewType)
    {
        UserText = userText;
        User = user;
        Book = book;
        ReviewType = reviewType;
    }
}

public enum ReviewType
{
    Excellent,
    Good,
    Fair,
    Poor
}
