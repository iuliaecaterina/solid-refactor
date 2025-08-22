using System;

using System.Collections.Generic;
using ConsoleProject.Models;

namespace ConsoleProject.Interfete
{
    public interface IBookManager
    {
        void AddBook(IBook book);
        void RemoveBook(IBook book);
    }
}
