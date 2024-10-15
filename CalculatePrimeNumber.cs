using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersCalculatorGP
{
    public class CalculatePrimeNumber
    {
        CalculationResult _calculationResult = null;
        Dictionary<int, bool> keyValuePairsIncycle = new Dictionary<int, bool>();

        public CalculatePrimeNumber()
        {
            _calculationResult = new CalculationResult();
        }
        public CalculatePrimeNumber(CalculationResult calculationResult)
        {
            _calculationResult = calculationResult;
        }

        /// <summary>
        /// Prime number was calculated.
        /// </summary>
        /// <returns>True. if calculated.</returns>
        public bool Calculate()
        {
            bool primeNumberWasCalculated = false;
            int startNumber = _calculationResult.LastPrimeNumber;
            
            return primeNumberWasCalculated;
        }
        private bool isPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
