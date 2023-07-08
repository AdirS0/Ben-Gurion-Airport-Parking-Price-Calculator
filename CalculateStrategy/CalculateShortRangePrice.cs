﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenGurionAirportParkingPriceCalculator.CalculateStrategy
{
    internal class CalculateShortRangePrice : ICalculateParkingPriceStrategy
    {
        private int terminal;

        public CalculateShortRangePrice(int terminal)
        {
            this.terminal = terminal;
        }

        public int Calculate(DateTime startDate, DateTime endDate)
        {
            int price = terminal == 1 ? calculateTerminalOne(startDate, endDate) : calculateTerminalThree(startDate, endDate);

            return price;
        }

        private int calculateTerminalOne(DateTime startDate, DateTime endDate)
        {
            int maxForDay = 45;
            int additionalCostEveryFifteenMins = 4;
            int twoShekelsToAddForFirstHour = 2;
            int totalPrice = 0;
            int totalPriceForLastDay = 0;

            TimeSpan parkingPeriod = endDate.Subtract(startDate);

            totalPrice += parkingPeriod.Days * maxForDay;

            if (parkingPeriod.Hours == 0)
            {
                totalPriceForLastDay += 18; // Minimum price for a day
            }
            else
            {
                totalPriceForLastDay += (int)Math.Ceiling((parkingPeriod.Hours * 60 + parkingPeriod.Minutes) / 15.0) * additionalCostEveryFifteenMins;
                totalPriceForLastDay += twoShekelsToAddForFirstHour;

                totalPriceForLastDay = Math.Min(totalPriceForLastDay, maxForDay);
            }

            totalPrice += totalPriceForLastDay;

            return totalPrice;
        }

        private int calculateTerminalThree(DateTime startDate, DateTime endDate)
        {
            int maxForDay = 90;
            int additionalCostEveryFifteenMins = 5;
            int totalPrice = 0;
            int totalPriceForLastDay = 0;

            TimeSpan parkingPeriod = endDate.Subtract(startDate);

            totalPrice += parkingPeriod.Days * maxForDay;

            if (parkingPeriod.Hours == 0)
            {
                totalPriceForLastDay += 20; // Minimum price for a day
            }
            else
            {
                totalPriceForLastDay += (int)Math.Ceiling((parkingPeriod.Hours * 60 + parkingPeriod.Minutes) / 15.0) * additionalCostEveryFifteenMins;

                totalPriceForLastDay = Math.Min(totalPriceForLastDay, maxForDay);
            }

            totalPrice += totalPriceForLastDay;

            return totalPrice;
        }
    }
}