using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class GUI
    {
        Guest guest = new Guest();
        Logik logik = new Logik();

        public void MainMenu()
        {
            logik.Guest();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine("             H1 Queue Operations Menu             ");
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();

            Console.WriteLine("1. Add guest");
            Console.WriteLine("2. Delete guest");
            Console.WriteLine("3. Show number of guests");
            Console.WriteLine("4. Show max number of guests");
            Console.WriteLine("5. Find guest");
            Console.WriteLine("6. Find all guests");
            Console.WriteLine("7. Exit");
        }

        public void QueueOption()
        {
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Insert name of your guest");
                    guest.Name = Console.ReadLine();

                    Console.WriteLine("Insert age of your guest");
                    guest.Age = Convert.ToInt32(Console.ReadLine());

                    logik.AddGuests(guest.Name, guest.Age);
                    Console.WriteLine($"Added to guest list {guest.Name} {guest.Age}");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(logik.DeleteGuests());
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(logik.NumberOfGuests());
                    Console.ReadKey();
                    break;
                case 4:
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine(logik.findGuest());
                    Console.ReadKey();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine(logik.PrintGuestList());
                    Console.ReadKey();
                    break;
                case 7:
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }

    }
}
