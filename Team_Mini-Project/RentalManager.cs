using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Mini_Project
{
    public class RentalManager
    {
        private BookingCalculator calculator;

        public RentalManager()
        {
            calculator = new BookingCalculator();
        }

        public RentalBooking CreateBooking(Customers customer, Vehicles car, int rentalDays)
        {
            if (car.statue != Statue.avaliable)
            {
                return null;
            }

            decimal baseTotal = calculator.PriceTotal(car.Price, rentalDays);

            RentalBooking booking = new RentalBooking();

            booking.Customer = customer;
            booking.Car = car;
            booking.RentalDays = rentalDays;
            booking.BaseTotal = baseTotal;
            booking.FinalTotal = baseTotal;

            car.statue = Statue.Rented;

            return booking;

        }

    }

}
