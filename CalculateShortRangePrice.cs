using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenGurionAirportParkingPriceCalculator
{
    class CalculateShortRangePrice : ICalculateParkingPriceStrategy
    {
        private int terminal;

        public CalculateShortRangePrice(int terminal)
        {
            this.terminal = terminal;
        }

        public int Calculate(DateTime startDate, DateTime endDate)
        {
            // TODO
            return 0;
        }
    }
}
