namespace Models;

public class Review
{
    public int ReviewId { get; init; }
    public string? UserText { get; set; }
    public User? User { get; set; }
    public Book? Book { get; set; }

}