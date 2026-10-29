using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Mini_Project
{
    public class PricingCalculator
    {
        private readonly IPricingStrategy _pricingStrategy;

        public PricingCalculator(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy ?? new NoDiscount();
        }

        public (decimal baseTotal, decimal discountValue, decimal finalTotal, string description) Calculate(decimal dailyRate, int rentalDays)
        {
            decimal baseTotal = dailyRate * rentalDays;
            decimal discountValue = _pricingStrategy.CalculateDiscount(baseTotal);
            decimal finalTotal = baseTotal - discountValue;
            string description = _pricingStrategy.GetDiscountDescription();

            return (baseTotal, discountValue, finalTotal, description);
        }
    }

}
