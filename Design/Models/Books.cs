namespace Models;

public class Book
{
    public int BookId { get; init; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Publisher { get; set; }
    public string? Subject { get; set; }
    public string? ISBN { get; set; }
    public BookType BookType { get; set; }
    public bool OnLoan { get; set; }
    public UserReview? UserReview { get; set; }
    public List<UserReview>? Reviews { get; set; }

    public Book()
    {

    }

    public Book(int bookId, string title, string author, string publisher, BookType bookType, bool onLoan)
    {
        BookId = bookId;
        Title = title;
        Author = author;
        Publisher = publisher;
        BookType = bookType;
        OnLoan = onLoan;
    }

    public Book(int bookId, string title, string author, string publisher, string isbn, BookType bookType, bool onLoan)
    {
        BookId = bookId;
        Title = title;
        Author = author;
        Publisher = publisher;
        ISBN = isbn;
        BookType = bookType;
        OnLoan = onLoan;
        Reviews = new List<UserReview>();
    }

    public Book(int bookId, string title, string author, string publisher, string subject, string isbn, BookType bookType, bool onLoan)
    {
        BookId = bookId;
        Title = title;
        Author = author;
        Publisher = publisher;
        Subject = subject;
        ISBN = isbn;
        BookType = bookType;
        OnLoan = onLoan;
    }

    public void AddReview(UserReview userReview)
    {
        Console.WriteLine($"Adding review by {userReview.User.Username} to book {userReview.Book.Title}");
        Console.WriteLine($"Review: {userReview.UserText}");

        if (userReview.Book.Reviews == null)
        {
            userReview.Book.Reviews = new List<UserReview>();
        }

        if (userReview.ReviewType == ReviewType.Excellent)
        {
            userReview.UserText = $"Rating: ****\n {userReview.UserText}";
        }
        else if (userReview.ReviewType == ReviewType.Good)
        {
            userReview.UserText = $"Rating: ***\n {userReview.UserText}";
        }
        else if (userReview.ReviewType == ReviewType.Fair)
        {
            userReview.UserText = $"Rating: **\n {userReview.UserText}";
        }
        else if (userReview.ReviewType == ReviewType.Poor)
        {
            userReview.UserText = $"Rating: *\n {userReview.UserText}";
        }



        userReview.Book.Reviews.Add(userReview);
    }
}

public enum BookType
{
    Fiction,
    NonFiction,
    Reference,
    Periodical,
    Children
}