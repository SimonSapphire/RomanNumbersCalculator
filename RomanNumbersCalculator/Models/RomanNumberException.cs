using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    internal class RomanNumberException: Exception
    {
        private const string errorMessage = "#ERROR";
        public RomanNumberException(string message=errorMessage) : base(message) { }
    }
}
