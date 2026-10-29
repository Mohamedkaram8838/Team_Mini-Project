using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Mini_Project
{
    public class RentalService
    {
        private readonly IRentalRepository repository;
        private readonly INotificationService notificationService;
        private readonly RentalManager rentalManager;

        public RentalService(
            IRentalRepository repository,
            INotificationService notificationService,
            RentalManager rentalManager)
        {
            this.repository = repository;
            this.notificationService = notificationService;
            this.rentalManager = rentalManager;
        }

        public RentalBooking RentVehicle(
            Customers customer,
            Vehicles vehicle,
            int rentalDays)
        {
            RentalBooking booking = rentalManager.CreateBooking(
                customer,
                vehicle,
                rentalDays
            );

            if (booking == null)
            {
                notificationService.SendNotification(
                    "Vehicle is not available."
                );

                return null;
            }

            repository.AddBooking(booking);

            notificationService.SendNotification(
                "Booking created successfully!"
            );

            return booking;
        }

        public void ShowAllBookings()
        {
            List<RentalBooking> bookings =
                repository.GetAllBookings();

            if (bookings.Count == 0)
            {
                notificationService.SendNotification(
                    "No bookings found:("
                );

                return;
            }

            foreach (RentalBooking booking in bookings)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Customer: {booking.Customer.Name}");
                Console.WriteLine($"Vehicle: {booking.Car.Brand}");
                Console.WriteLine($"Rental Days: {booking.RentalDays}");
                Console.WriteLine($"Base Total: {booking.BaseTotal}");
                Console.WriteLine($"Final Total: {booking.FinalTotal}");
                Console.WriteLine("------------------------------");
            }
        }
    }
}
