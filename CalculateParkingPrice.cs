using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenGurionAirportParkingPriceCalculator
{
    class CalculateParkingPrice
    {
        private ICalculateParkingPriceStrategy calculateParkingPriceStrategy;

        public CalculateParkingPrice(ICalculateParkingPriceStrategy strategy)
        {
            this.calculateParkingPriceStrategy = strategy;
        }

        public int Calculate(DateTime startDate, DateTime endDate)
        {
            int parkingPrice = this.calculateParkingPriceStrategy.Calculate(startDate, endDate);

            return parkingPrice;
        }
    }
}
