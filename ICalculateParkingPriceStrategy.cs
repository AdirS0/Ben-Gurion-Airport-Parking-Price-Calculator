using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenGurionAirportParkingPriceCalculator
{
    internal interface ICalculateParkingPriceStrategy
    {
        int Calculate(DateTime startDate, DateTime endDate);
    }
}
