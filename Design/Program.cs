using System;
using Models;

class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("Testing creating objects for each class as it's slowly built.");
        Console.WriteLine("New user - ");

        int userId = 0;

        var newUser = new User(
            userId + 1,
            "spiderman",
            "spideysense",
            "Peter",
            "Parker",
            UserType.Customer
        );

        //This isn't how to handle passwords

        Console.WriteLine($"UserId: {newUser.UserId}");
        Console.WriteLine($"Username: {newUser.Username}");
        Console.WriteLine($"Password: {newUser.Password}");
        Console.Write($"Name: {newUser.FirstName} {newUser.LastName}\n");
        Console.WriteLine($"UserType: {newUser.UserType}");

    }
}


