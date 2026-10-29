using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Mini_Project
{
    public interface IRentalRepository
    {
        void AddBooking(RentalBooking booking);

        List<RentalBooking> GetAllBookings();
    }
}
