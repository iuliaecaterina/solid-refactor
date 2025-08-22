using ConsoleProject.Interfete;

namespace ConsoleProject.Models
{
    public class Romance : IBook
    {
        public string Title { get; private set; }
        public Romance(string title) { Title = title; }
    }
}
