namespace Models;

public class Book
{
    public int BookId { get; init; }
    public string Title  { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public string? Subject { get; set; }
    public string? ISBN { get; set; }
    public BookType BookType { get; set; }
    public bool OnLoan { get; set; }

    public Book(int bookId, string title, string author, string publisher, BookType bookType, bool onLoan )
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
}

public enum BookType
{
    Fiction,
    NonFiction,
    Reference,
    Periodical,
    Children
}