using System;
using System.Collections.Generic;
using System.Text;


class PriceCalculator
{
    public static decimal CalculatePrice(double pricePerDay, int amountOfDays, Seasons season, DiscountType discount)
    {
        decimal price = (decimal)(pricePerDay * amountOfDays * (int)season);
        decimal discountAmount = (decimal)(pricePerDay * amountOfDays * (int)season) * ((decimal)(int)discount / 100);
        decimal totalPrice = price - discountAmount;
        return totalPrice;
    }
}

