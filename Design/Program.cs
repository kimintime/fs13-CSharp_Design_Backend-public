using Models;

class Program
{
    static async Task Main(string[] args)
    {
        var newUser = new User(
            1,
            "spiderman",
            "spideysense",
            "Peter",
            "Parker",
            UserType.Customer,
            false
        );

        var newUser2 = new User(
            2,
            "batman",
            "thebatman",
            "Bruce",
            "Wayne",
            UserType.Customer,
            false
        );

        var newUser3 = new User(
            3,
            "admin",
            "admin123",
            "Adam",
            "Admin",
            UserType.Librarian,
            false
        );

        var newBook = new Book(
            1,
            "Far From the Madding Crowd",
            "Thomas Hardy",
            "Penguin Classics",
            "0141439653",
            BookType.Fiction,
            true
        );

        var newBook2 = new Book(
            2,
            "Jane Eyre",
            "Charlotte Bronte",
            "Penguin Classics",
            "9780141441146",
            BookType.Fiction,
            true
        );

        var newLoan = new Loan(
            1,
            newBook,
            newUser
        );

        var userReview = new UserReview(

            "Far from the Madding Crowd, more like Far from the Maddening Crowd, am I right?",
            newUser,
            newBook,
            ReviewType.Fair
        );

        var userReview2 = new UserReview(

           "I loved it!",
           newUser2,
           newBook,
           ReviewType.Excellent
       );

        Book book = new Book();
        book.AddReview(userReview);
        book.AddReview(userReview2);

        Loans loans = new Loans();
        loans.AddLoan(newLoan);
        //loans.DeleteLoan(newLoan);

        loans.PrintLoans();

        Library library = new Library();
        library.AddUser(newUser);
        library.AddUser(newUser2);
        library.AddUser(newUser3);

        library.AddBook(newBook);
        library.AddBook(newBook2);

        library.GetBookById(2);
        library.GetBookByAuthor("Thomas Hardy");
        library.ListAuthors();
        library.ListLibrarians();

        await library.PrintUsers();
        await library.PrintBooks();

    }
}
