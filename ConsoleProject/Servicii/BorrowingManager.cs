using System;
using ConsoleProject.Interfete;
using ConsoleProject.Models;
using System.Collections.Generic;

namespace ConsoleProject.Servicii
{
    public class BorrowingManager : IBorrowingManager
    {
        private readonly List<IBook> books;
        private readonly List<IMember> members;

        public BorrowingManager(List<IBook> books, List<IMember> members)
        {
            this.books = books;
            this.members = members;
        }

        public void BorrowBook(IMember member, IBook book)
        {
            if (books.Contains(book) && members.Contains(member))
            {
                books.Remove(book);
                Console.WriteLine($"{member.Name} borrowed {book.Title}");
            }
            else
            {
                Console.WriteLine("Book or member not found.");
            }
        }

        public void ReturnBook(IMember member, IBook book)
        {
            books.Add(book);
            Console.WriteLine($"{member.Name} returned {book.Title}");
        }
    }
}
