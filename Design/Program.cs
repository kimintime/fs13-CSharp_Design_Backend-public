using System;
using System.Collections.Generic;
using Models;

class Program {
    static void Main(string[] args)
    {
        var newUser = new User(
            1,
            "spiderman",
            "spideysense",
            "Peter",
            "Parker",
            UserType.Customer
        );

        var newUser2 = new User(
            2,
            "batman",
            "thebatman",
            "Bruce",
            "Wayne",
            UserType.Customer
        );

        var newBook = new Book(
            1,
            "Far From the Madding Crowd",
            "Thomas Hardy",
            "Penguin Classics",
            "0141439653",
            BookType.Fiction
        );

        var newBook2 = new Book(
            2,
            "Jane Eyre",
            "Charlotte Bronte",
            "Penguin Classics",
            "9780141441146",
            BookType.Fiction
        );


        Library library = new Library();
        library.AddUser(newUser);
        library.AddUser(newUser2);
        library.AddBook(newBook);
        library.AddBook(newBook2);

        library.PrintUsers();
        library.PrintBooks();
    }
}


