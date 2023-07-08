using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenGurionAirportParkingPriceCalculator.CalculateStrategy
{
    internal interface ICalculateParkingPriceStrategy
    {
        int Calculate(DateTime startDate, DateTime endDate);
    }
}
