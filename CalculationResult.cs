using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersCalculatorGP
{
    public class CalculationResult
    {
        long _lastPrimeNumber = 0;
        int _cycleNumber = 0;
        DateTime _cycleDuration = DateTime.MinValue;
        DateTime _whenPrimeNumberWasFound = DateTime.MinValue;

        public long LastPrimeNumber { get => _lastPrimeNumber; set => _lastPrimeNumber = value; }
        public int CycleNumber { get => _cycleNumber; set => _cycleNumber = value; }
        public DateTime CycleDuration { get => _cycleDuration; set => _cycleDuration = value; }
        public DateTime WhenPrimeNumberWasFound { get => _whenPrimeNumberWasFound; set => _whenPrimeNumberWasFound = value; }


    }
}
