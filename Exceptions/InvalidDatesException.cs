using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenGurionAirportParkingPriceCalculator.Exceptions
{
    class InvalidDatesException : Exception
    {
        public InvalidDatesException() { }

        public InvalidDatesException(string message) : base(message) { }

        public InvalidDatesException(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return "Start Date can't be later than End Date!";
        }
    }
}
