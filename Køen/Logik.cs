using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class Logik
    {
        Queue<Guest> guests = new Queue<Guest>();

        public void Guest()
        {
            guests.Enqueue(new Guest() { Age = 25, Name = "John" });
            guests.Enqueue(new Guest() { Age = 24, Name = "Barbara" });
            guests.Enqueue(new Guest() { Age = 24, Name = "Phil" });
            guests.Enqueue(new Guest() { Age = 23, Name = "Fred" });
            guests.Enqueue(new Guest() { Age = 26, Name = "Hannah" });
            guests.Enqueue(new Guest() { Age = 27, Name = "Cindy" });
        }
        #region Add Item
        public void AddGuests(string name, int age)
        {
            guests.Enqueue(new Guest() { Age = age, Name = name });
        }
        #endregion
        #region Delete Items
        public string DeleteGuests()
        {
            Guest guest = guests.Dequeue();
            return $"{guest.Name} has been deleted";
        }
        #endregion
        #region Number of guests

        public string NumberOfGuests()
        {
            string guestNumber = "";
            guestNumber = $"Total Guests: {guests.Count()}";
            return guestNumber;
        }
        #endregion
        #region MinMaxGuest

        public void MinMaxGuest()
        {

        }
        #endregion

        #region Find an Guest
        public string findGuest()
        {
            Guest guest = guests.ElementAt(1);
            return $"Name: {guest.Name} Age: {guest.Age}";
        }

        #endregion
        #region Print Guest List

        public string PrintGuestList()
        {
            string temp = "";
            foreach (Guest guest in guests)
            {
                temp += $"Name: {guest.Name} Age:{guest.Age}\n";
            }
            return temp;
        }
        #endregion
    }
}
