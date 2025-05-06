using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using GuestBookLibrary.Models;

namespace GuestBookUI
{
    internal class Program
    {
        static Guest GetData()
        {
            Guest guest = new Guest();

            Console.Write("Enter first name (enter \"exit\" to exit): ");
            string potentialFirstName = Console.ReadLine();
            if(potentialFirstName.ToLower() == "exit")
            {
                return null;
            }
            guest.FirstName = potentialFirstName;

            Console.Write("Enter last name: ");
            guest.LastName = Console.ReadLine();

            Console.Write("Enter message: ");
            guest.Message = Console.ReadLine();

            return guest;
        }

        static void printData(Guest guest)
        {
            Console.WriteLine($"{guest.FirstName} {guest.LastName}");
            Console.WriteLine($"Message: {guest.Message}\n");
        }

        static void Main(string[] args)
        {
            List<Guest> allGuests = new List<Guest>();
            bool isRunning = true;
            while (isRunning)
            {
                
                Guest guest = GetData();
                if (guest == null)
                {
                    Console.WriteLine("Exited\n");
                    isRunning = false;
                }
                else
                {
                    allGuests.Add(guest);
                }
            }
            
            foreach (Guest guest in allGuests)
            {
                printData(guest);
            }
        }
    }
}
