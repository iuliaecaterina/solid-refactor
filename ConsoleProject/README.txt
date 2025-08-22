
This project started from the following base repository:  
-> [tap25-tema1-codebase](https://github.com/rusuiuliancen/tap25-tema1-codebase)
The goal of this assignment was to **apply the SOLID principles** by refactoring the existing code.  

  Applied Principles
1. **Single Responsibility Principle** 
2. **Open/Closed Principle** 
3. **Liskov Substitution Principle** 
4. **Interface Segregation Principle** 
5. **Dependency Inversion Principle**

I modified the initial project as follows:

1. Single Responsibility Principle (SRP)

Identified problem:
    In the LibrarySystem class, books, members, and borrowings were all managed in one place, meaning the class had multiple responsibilities.
Solution:

I separated the logic into multiple classes, each with a single responsibility:

BookManager – manages books
MemberManager – manages members
BorrowingManager – manages borrowings

I then updated LibrarySystem to use these classes, reducing it's responsibilities.

2.Open/Closed Principle (OCP)

Identified problem:
    Any change to the book types required modifications to the LibrarySystem class, violating OCP.
Solution:

->Introduced interfaces (IBookManager.cs, IMemberManager.cs, IBorrowingManager.cs), allowing behavior to be extended without modifying existing code.
->Added AdventureBook.cs and RomanceBook.cs to extend book behavior without changing current implementations.
->Updated LibrarySystem to use interfaces so no modifications are required when adding new book types.
->By using interfaces and inheritance, the system is now extensible, following OCP.

3. Liskov Substitution Principle (LSP)

Goal: We should be able to use a derived object in place of its base class without affecting program functionality.

Identified problem:
    Classes using LibrarySystem could not substitute derived objects in place of the base class.
Solution:

->Created the IBook interface, implemented by AdventureBook and RomanceBook.
->Functions operating on IBook now work with any derived book type without issues.
->This allows extension with new book types (e.g., ScienceFictionBook) without modifying existing code.

4. Interface Segregation Principle (ISP)

Identified problem:
    ILibrarySystem contained all methods (AddBook, AddMember, BorrowBook, ReturnBook), forcing implementing classes to define methods they might not need.
Solution:

->I separated responsibilities from ILibrarySystem into multiple interfaces:

IBookManager.cs – for book management
IMemberManager.cs – for member management
IBorrowingManager.cs – for borrowing management

Now each class implements only the relevant methods without being forced to implement unused functionality.

5. Dependency Inversion Principle (DIP)

Identified problem:
    Initially, LibrarySystem depended directly on concrete implementations (e.g., List<string> for books and members).
Solution:

->In LibrarySystem.cs, direct dependencies on specific classes were replaced with interfaces, enabling dependency injection.
->The code now supports different implementations without modifying dependent code.
->LibrarySystem no longer creates objects directly but receives instances through its constructor.
->Instead of depending on lists, it depends on abstractions (IBookManager, IMemberManager, IBorrowingManager). This allows internal implementations to change without affecting the code using LibrarySystem.