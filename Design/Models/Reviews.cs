namespace Models;

public class UserReview
{
    public int ReviewId { get; init; }
    public string UserText { get; set; }
    public User User { get; set; }
    public Book Book { get; set; }

    public UserReview(int reviewId, string userText, User user, Book book)
    {
        ReviewId = reviewId;
        UserText = userText;
        User = user;
        Book = book;
    }
}
