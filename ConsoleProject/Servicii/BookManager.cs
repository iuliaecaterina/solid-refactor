using System.Collections.Generic;
using ConsoleProject.Interfete;
using ConsoleProject.Models;

namespace ConsoleProject.Servicii
{
    public class BookManager : IBookManager
    {
        private  List<IBook> books = new List<IBook>();

        public void AddBook(IBook book) { 
            books.Add(book); 
        }
        public void RemoveBook(IBook book)
        {
            books.Remove(book);
        }
    }
}
