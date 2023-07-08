using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenGurionAirportParkingPriceCalculator.CalculateStrategy
{
    class CalculateLongRangePrice : ICalculateParkingPriceStrategy
    {
        private bool cover;

        public CalculateLongRangePrice(bool cover)
        {
            this.cover = cover;
        }

        public int Calculate(DateTime startDate, DateTime endDate)
        {
            int price = cover ? calculateWithCover(startDate, endDate) : calculateWithoutCover(startDate, endDate);

            return price;
        }

        private int calculateWithCover(DateTime startDate, DateTime endDate)
        {
            int maxForDay = 80;
            int additionalCostEveryHour = 14;
            int totalPrice = 0;
            int totalPriceForLastDay = 0;

            TimeSpan parkingPeriod = endDate.Subtract(startDate);

            if (parkingPeriod.Days == 0 && parkingPeriod.Minutes > 0)
            {
                totalPrice = maxForDay; // Minimum price for a day
            }
            else
            {
                totalPrice += parkingPeriod.Days * maxForDay;

                if (parkingPeriod.Minutes > 0)
                {
                    totalPriceForLastDay += additionalCostEveryHour;
                }

                totalPriceForLastDay += parkingPeriod.Hours * additionalCostEveryHour;

                totalPriceForLastDay = Math.Min(totalPriceForLastDay, maxForDay);
            }

            totalPrice += totalPriceForLastDay;

            return totalPrice;
        }

        private int calculateWithoutCover(DateTime startDate, DateTime endDate)
        {
            int maxForDay = 45;
            int additionalCostEveryHour = 10;
            int totalPrice = 0;
            int totalPriceForLastDay = 0;

            TimeSpan parkingPeriod = endDate.Subtract(startDate);

            if (parkingPeriod.Days == 0 && parkingPeriod.Minutes > 0)
            {
                totalPrice = maxForDay; // Minimum price for a day
            }
            else
            {
                totalPrice += parkingPeriod.Days * maxForDay;

                if (parkingPeriod.Minutes > 0)
                {
                    totalPriceForLastDay += additionalCostEveryHour;
                }

                totalPriceForLastDay += parkingPeriod.Hours * additionalCostEveryHour;

                totalPriceForLastDay = Math.Min(totalPriceForLastDay, maxForDay);
            }

            totalPrice += totalPriceForLastDay;

            return totalPrice;
        }
    }
}
