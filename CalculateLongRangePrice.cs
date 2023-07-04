using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenGurionAirportParkingPriceCalculator
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
            // TODO
            return 0;
        }
    }
}
