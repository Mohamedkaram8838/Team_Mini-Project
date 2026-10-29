using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Mini_Project
{
    public class NoDiscount : IPricingStrategy
    {
        public decimal CalculateDiscount(decimal baseTotal)
        {
            return 0m;
        }

        public string GetDiscountDescription()
        {
            return "No Discount Applied";
        }
    }
}
