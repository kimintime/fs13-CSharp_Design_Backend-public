namespace Models;
using System;
using System.Collections.Generic;

public class Library
{
    public List<User> Users = new List<User>();
    public List<Book> Books = new List<Book>();
    public void AddUser(User newUser) => Users.Add(newUser);

    public void AddBook(Book newBook) => Books.Add(newBook);

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