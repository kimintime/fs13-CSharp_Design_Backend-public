# Design Backend structure using CSharp
For the following project, I am building a Library system. There are many features that could be implemented, so at this stage, I chose to pick and choose what I consider to be the main examples. More on the explanation and structure to follow, but the main console printout is as follows. Our library system is populated and run from the Program, filled with books and users, as well as book reviews and loan status, the results printed from the Library class.

-----
## Library Features

A Library has Books (for our purposes) and Users. There are predefined categories of both, such as the type of book, and whether that user is a customer or a librarian. As the project grows, access control would depend on these user types.

In a library, you may search many ways, searching by Author is just but one example. Getting a user by ID would be another everyday occurence, as well as knowing who the librarians are. Also of course knowing whether or not a book is out on loan, and who has book loans, as well as the reviews and ratings for the books.

## Future Features
Of course we would need user login capabilities, searching by all book and user properties, the ability to change those properties that can be reasonably changed, with add, update, and delete options, depending on user type.

# The original project requirements
This project meets all the requirements below:

In this assignment, you are required to design structure and hierachy for a backend service. you can choose between two topics:

1. Library Management

You will decide to whether use class/interface/struct for each situation.

## Library management system suggestions (or come up with your own design)

- User (consider different types of User)
- Book
- Category
- Author
- Cart
- Optional: Review

# File Structure

