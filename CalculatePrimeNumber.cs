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
        public CalculatePrimeNumber()
        {
            _calculationResult = new CalculationResult();
        }
        public CalculatePrimeNumber(CalculationResult calculationResult)
        {
            _calculationResult = calculationResult;
        }

        public void Calculate()
        {
            Dictionary<int,bool> keyValuePairs = new Dictionary<int,bool>();
            
            int startNumber = _calculationResult.LastPrimeNumber;
            //c = a % b;


        }

    }
}
