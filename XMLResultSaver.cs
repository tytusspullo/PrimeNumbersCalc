using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersCalculatorGP
{
    public class XMLResultSaver:IXMLResultSaver
    {
        private CalculationResult _calculationResult = null;
        private string _fileNameWithPath = string.Empty;

        public XMLResultSaver(CalculationResult calculationResult, string fileNameWithPath)
        {
            _calculationResult = calculationResult;
            _fileNameWithPath = fileNameWithPath;
        }
        public CalculationResult ReadFromXML()
        {
            throw new NotImplementedException();
        }

        public void WriteToXML()
        {
            throw new NotImplementedException();
        }

    }
}
