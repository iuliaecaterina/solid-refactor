using System;
using System.Collections.Generic;
using ConsoleProject.Interfete;
using ConsoleProject.Servicii;
using ConsoleProject.Models;

namespace ConsoleProject
{
    public class LibrarySystem : IBookManager, IMemberManager, IBorrowingManager
    {
        private  List<IBook> books = new List<IBook>();
        private  List<IMember> members = new List<IMember>();
        private  IBorrowingManager borrowingManager;
        private  IBookManager bookManager;
        private  IMemberManager memberManager;

        public LibrarySystem()
        {
            bookManager = new BookManager();
            memberManager = new MembersManager();
            borrowingManager = new BorrowingManager(books, members);
        }

        public void AddBook(IBook book)
        {
            books.Add(book);
            bookManager.AddBook(book);
        }

        public void RemoveBook(IBook book)
        {
            books.Remove(book);
            bookManager.RemoveBook(book);
        }

        public void AddMember(IMember member)
        {
            members.Add(member);
            memberManager.AddMember(member);
        }

        public void BorrowBook(IMember member, IBook book)
        {
            borrowingManager.BorrowBook(member, book);
        }

        public void ReturnBook(IMember member, IBook book)
        {
            borrowingManager.ReturnBook(member, book);
        }
    }
}
