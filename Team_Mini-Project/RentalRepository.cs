using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Mini_Project
{
    public class RentalRepository : IRentalRepository
    {
        private readonly List<RentalBooking> bookings =
            new List<RentalBooking>();

        public void AddBooking(RentalBooking booking)
        {
            bookings.Add(booking);
        }

        public List<RentalBooking> GetAllBookings()
        {
            return bookings;
        }
    }
}
