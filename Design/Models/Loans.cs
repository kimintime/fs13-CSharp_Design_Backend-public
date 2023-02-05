namespace Models;

public class Loan
{
    public int LoanId { get; init; }
     public Book Book { get; set; }
    public User User { get; set; }
   
    public Loan(int loanId, Book book, User user)
    {
        LoanId = loanId;
        Book = book;
        User = user;
    }
}

public class Loans
{
    public List<Loan> LoansList = new List<Loan>();

    public void AddLoan(Loan newLoan)
    {
        newLoan.Book.OnLoan = false;
        newLoan.User.HasLoan = true;

        LoansList.Add(newLoan);
    }

    public void DeleteLoan(Loan newLoan)
    {
        newLoan.Book.OnLoan = true;
        newLoan.User.HasLoan = false;

        LoansList.Remove(newLoan);
    }

    public void PrintLoans()
    {
        Console.WriteLine("------ Loans ------");

        foreach (var loan in LoansList)
        {
            Console.Write($"Title: {loan.Book.Title} - ");
            Console.Write($"Username: {loan.User.Username}\n");
            Console.WriteLine(" ");
        }
    }
}