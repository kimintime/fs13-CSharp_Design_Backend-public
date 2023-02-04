namespace Models;

public class Loan
{
    public int LoanId { get; init; }
    public DateTime Due { get; init; }
    public Book? Book { get; set; }
    public User? User { get; set; }

}