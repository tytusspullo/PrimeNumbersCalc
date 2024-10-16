using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbersCalculatorGP
{
    public partial class FrmCalculator : Form
    {
        CalculationResult _calculationResult = null;
        CalculatePrimeNumber _calculator = null;
        string fileName = "results.xml";
        int lastcycle = 0;
        bool isStarted = false;
        int defaultCycleLength = 120;// 2mins = 120s
        public FrmCalculator()
        {
            _calculator = new CalculatePrimeNumber(_calculationResult, defaultCycleLength);
            InitializeComponent();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                try
                {
                    var xmlResultRetriver = new XMLResultRetriver(fileName);
                    _calculationResult = xmlResultRetriver.ReadFromXML();
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("There was problem with file read.", "Warning!"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                if (_calculationResult == null)
                {
                    _calculationResult = new CalculationResult();
                    _calculationResult.CycleNumber = 0;
                }
                DisplayResult(_calculationResult);
            }
            else
            {
                MessageBox.Show("Calculations in progress, can't read now.", "Information"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnStart_ClickAsync(object sender, EventArgs e)
        {
            StartCycle();

            _calculator = new CalculatePrimeNumber(_calculationResult, defaultCycleLength);
            var result = await _calculator.CalculateAsync();
            _calculationResult = result;
            //save
            try 
            { 
                XMLResultSaver xmlSaver = new XMLResultSaver(result, fileName);
                xmlSaver.WriteToXML();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("There was problem with file write.", "Warning!"
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!_calculationResult.PrimeNumberWasCalculated)
                tbError.Text = "For cycle:" + _calculationResult.CycleNumber.ToString() + " prime number was not found!";
            //display as old now
            DisplayResult(_calculationResult);

            StopCycle();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopCycle();
            _calculator.CancelManual();
        }

        private void StartCycle()
        {
            isStarted = true;
            btnStart.Enabled = !isStarted;
            btnStop.Enabled = isStarted;
            //display new 
            int newCycle = _calculationResult.CycleNumber + 1;
            tbNewCycle.Text = "Starting cycle:" + newCycle.ToString();
        }
        private void StopCycle()
        {
            isStarted = false;
            btnStart.Enabled = !isStarted;
            btnStop.Enabled = isStarted;
            //clean display new 
            tbNewCycle.Text = string.Empty;
        }
        private void DisplayResult(CalculationResult calculationResult)
        { 
            tbCycle.Text = calculationResult.CycleNumber.ToString();
            tbLastPrimeNumber.Text = calculationResult.LastPrimeNumber.ToString();
            tbWhenPrimeNumberWasFound.Text = calculationResult.WhenPrimeNumberWasFound.ToLongDateString() 
                            + " " + calculationResult.WhenPrimeNumberWasFound.ToLongTimeString();
            tbCycleDuration.Text = calculationResult.CycleDuration.ToLongTimeString();
        }
    }
}
