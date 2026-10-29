using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Mini_Project
{
    public class RentalBooking
    {
        public Customers Customer { get; set; }
        public Vehicles Car { get; set; }
        public int RentalDays { get; set; }
        public decimal BaseTotal { get; set; }
        public decimal FinalTotal { get; set; }

    }

}
