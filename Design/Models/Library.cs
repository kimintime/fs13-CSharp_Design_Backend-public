namespace Models;
using System;
using System.Collections.Generic;

public class Library
{
    public List<User> Users = new List<User>();
    public List<Book> Books = new List<Book>();
    public void AddUser(User newUser) => Users.Add(newUser);
    public void AddBook(Book newBook) => Books.Add(newBook);

    public void GetBookById(int id)
    {
        var book = Books.Find(item => item.BookId.Equals(id));

        Console.WriteLine("------ Finding Book by ID ------");

        if (book != null)
        {
            Console.WriteLine($"UserId: {book.BookId}");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author(s): {book.Author}");
            Console.WriteLine($"Subject: {book.Subject}");
            Console.WriteLine($"Publisher: {book.Publisher}");
            Console.WriteLine($"ISBN: {book.ISBN}");
            Console.WriteLine($"BookType: {book.BookType}");
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine($"Title with the ID {id} doesn't exist.");
        }
    }

    public void GetBookByAuthor(string author)
    {
        var book = Books.Find(item => item.Author.Equals(author));

        Console.WriteLine("------ Finding Book by Author ------");

        if (book != null)
        {
            Console.WriteLine($"UserId: {book.BookId}");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author(s): {book.Author}");
            Console.WriteLine($"Subject: {book.Subject}");
            Console.WriteLine($"Publisher: {book.Publisher}");
            Console.WriteLine($"ISBN: {book.ISBN}");
            Console.WriteLine($"BookType: {book.BookType}");
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine($"Title by author {author} doesn't exist.");
        }
    }

    public void ListAuthors()
    {
        Console.WriteLine("------ Author List ------");
        foreach (var book in Books)
        {
            Console.WriteLine(book.Author);
        }
        Console.WriteLine(" ");
    }

    public void ListLibrarians()
    {
        Console.WriteLine("------ Librarians ------");
        foreach (var user in Users)
        {
            if (user.UserType.ToString() == "Librarian")
            {
                Console.Write($"Name: {user.FirstName} {user.LastName}\n");
                Console.WriteLine(" ");
            }
        }
    }

    public void PrintUsers()
    {
        Console.WriteLine("------ User List ------");
        foreach (var user in Users)
        {
            Console.WriteLine($"UserId: {user.UserId}");
            Console.WriteLine($"Username: {user.Username}");
            Console.WriteLine($"Password: {user.Password}");
            Console.Write($"Name: {user.FirstName} {user.LastName}\n");
            Console.WriteLine($"UserType: {user.UserType}");
            Console.WriteLine(" ");
        }
    }

    public void PrintBooks()
    {
        Console.WriteLine("------ Book List ------");
        foreach (var book in Books)
        {
            Console.WriteLine($"UserId: {book.BookId}");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author(s): {book.Author}");
            Console.WriteLine($"Subject: {book.Subject}");
            Console.WriteLine($"Publisher: {book.Publisher}");
            Console.WriteLine($"ISBN: {book.ISBN}");
            Console.WriteLine($"BookType: {book.BookType}");
            Console.WriteLine(" ");
        }
    }


}