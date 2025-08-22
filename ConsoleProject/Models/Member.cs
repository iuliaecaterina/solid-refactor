using ConsoleProject.Interfete;

namespace ConsoleProject.Models
{
    public class Member : IMember
    {
        public string Name { get; private set; }

        public Member(string name)
        {
            Name = name;
        }
    }
}
