using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Person : IComparable
    {
        public string FirstName { get; init; }
        public string LastName { get; }
        public Address Address { get; }

        public Person(string _firstName, string _lastName, Address _address)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Address = _address;
        }

        public int CompareTo(object incomingObject)
        { 
            //Store the incoming object in a temp variable
            Person incomingPerson = incomingObject as Person;

            return this.LastName.CompareTo(incomingPerson.LastName);
        }

        public override string ToString()
        {
            return FirstName + "|" + LastName + "|" + Address.ToString();
        }
    }
}