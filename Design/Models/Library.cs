namespace Models;
using System;
using System.Collections.Generic;

public class Library
{
    public List<User> Users = new List<User>();

    //Well this is a mess
    public static User AddUser(User newUser)
    {
        return Users.Add(newUser);
    }

    public void PrintUsers()
    {
        foreach (var user in Users)
        {
            Console.WriteLine(user);
        }
    }
}