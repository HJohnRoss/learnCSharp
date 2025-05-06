using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InstantiatedClasses.Models;

namespace InstantiatedClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address homeAddress = new Address("Home", "Whistling Acres Avenue", "Nevada", "Las Vegas", "United States", 89131, 5008);
            Address workAddress = new Address("Work", "Amigo Street", "Nevada", "Las Vegas", "United States", 89119, 7120);
            Person person = new Person("John", "Ross", 23, homeAddress, workAddress);
        }
    }
}
