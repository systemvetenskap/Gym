using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Träning
{
    class Gym
    {
        public string Name { get; private set; }
        public string Address { private get; set; }

        private List<Person> members = new List<Person>(); // en field = variabel

        public void SetName(string name)
        {
            Name = name;
        }

        public bool AddMember(Person person)
        {
            if (members.Count <= 5)
            {
                members.Add(person);
                return true;
            }
            return false;
        }

        public List<Person> GetMembers()
        {
            return members;
        }
    }
}
