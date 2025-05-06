using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace InstantiatedClasses.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address HomeAddress { get; set; }
        public Address WorkAddress { get; set; }

        public Person(string firstName, string lastName, int age, Address homeAddress, Address workAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeAddress = homeAddress;
            WorkAddress = workAddress;
        }
    }
}
