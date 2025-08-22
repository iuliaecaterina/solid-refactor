using System;

namespace ConsoleProject.Interfete
{
    public interface ILibrarySystem
    {
        void AddBook(IBook book);
        void AddMember(IMember member);
        void BorrowBook(IMember member, IBook book);
        void ReturnBook(IMember member, IBook book);
    }
} 