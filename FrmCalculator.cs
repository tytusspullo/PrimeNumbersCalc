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
        public FrmCalculator()
        {
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
                    _calculationResult.CycleNumber = 1;
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

            _calculator = new CalculatePrimeNumber(_calculationResult, 10);
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
            //display new 
            tbNewCycle.Text = result.CycleNumber.ToString();
            tbNewPrimeNumber.Text = result.LastPrimeNumber.ToString();
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
        }
        private void StopCycle()
        {
            isStarted = false;
            btnStart.Enabled = !isStarted;
            btnStop.Enabled = isStarted;
        }
        private void DisplayResult(CalculationResult calculationResult)
        { 
            tbCycle.Text = calculationResult.CycleNumber.ToString();
            tbLastPrimeNumber.Text = calculationResult.LastPrimeNumber.ToString();
            //dtpWhenPrimeNumberWasFound.Value = calculationResult.WhenPrimeNumberWasFound;
            //dtpCycleDuration.Value = calculationResult.CycleDuration;
        }

    }
}
