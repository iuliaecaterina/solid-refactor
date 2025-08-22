using System;
using ConsoleProject.Interfete;
using ConsoleProject.Models;
using ConsoleProject.Servicii;

namespace ConsoleProject
{
    class Program
    {
        static void Main()
        {
            LibrarySystem library = new LibrarySystem();

            
            IMember member1 = new Member("Maria");
            IMember member2 = new Member("Andrei");

          
            IBook romanceBook = new Romance("Pride and Prejudice");
            IBook adventureBook = new Adventure("Moby Dick");

            library.AddMember(member1);
            library.AddMember(member2);
            library.AddBook(romanceBook);
            library.AddBook(adventureBook);

            library.BorrowBook(member1, romanceBook);
            library.ReturnBook(member1, romanceBook);

            library.BorrowBook(member2, adventureBook);
            library.ReturnBook(member2, adventureBook);
        }
    }
}
