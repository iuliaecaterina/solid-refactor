using System.Collections.Generic;
using ConsoleProject.Interfete;
using ConsoleProject.Models;

namespace ConsoleProject.Servicii
{
    public class MembersManager : IMemberManager
    {
        private  List<IMember> members = new List<IMember>();

        public void AddMember(IMember member)
        {
            members.Add(member);
        }


    }
}
