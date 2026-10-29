using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Mini_Project
{
        public class VipDiscount : IPricingStrategy
        {
            public decimal CalculateDiscount(decimal baseTotal)
            {
                return baseTotal * 0.20m;
            }

            public string GetDiscountDescription()
            {
                return "VIP Customer Discount (20% OFF)";
            }
        }
    
}
