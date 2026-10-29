using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Mini_Project
{
    public class WeeklyDiscount : IPricingStrategy
    {
        public decimal CalculateDiscount(decimal baseTotal)
        {
            return baseTotal * 0.10m;
        }

        public string GetDiscountDescription()
        {
            return "Weekly Rental Discount (10% OFF)";
        }
    }
}
