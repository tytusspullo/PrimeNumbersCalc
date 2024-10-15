using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersCalculatorGP
{
    internal interface IXMLResultSaver
    {

        void WriteToXML();
        CalculationResult ReadFromXML();


    }
}
