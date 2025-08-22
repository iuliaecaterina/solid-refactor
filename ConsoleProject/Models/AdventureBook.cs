using ConsoleProject.Interfete;

namespace ConsoleProject.Models
{
    public class Adventure : IBook
    {
        public string Title { get; private set; }
        public Adventure(string title) { Title = title; }
    }
}
