using System;

using ConsoleProject.Models;

namespace ConsoleProject.Interfete
{
    public interface IBorrowingManager
    {
        void BorrowBook(IMember member, IBook book);
        void ReturnBook(IMember member, IBook book);
    }
}
