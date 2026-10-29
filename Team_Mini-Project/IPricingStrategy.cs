using System;
using System.Collections.Generic;
using System.Text;

namespace Team_Mini_Project
{
    public interface IPricingStrategy
    {
        decimal CalculateDiscount(decimal baseTotal);
        string GetDiscountDescription();
    }

}
