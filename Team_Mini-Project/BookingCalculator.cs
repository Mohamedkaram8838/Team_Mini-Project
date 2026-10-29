using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Mini_Project
{
    public class BookingCalculator
    {
        public decimal PriceTotal(decimal dailyPrice, int rentalDays)
        {
            return dailyPrice * rentalDays;
        }

    }
}
