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
                _calculationResult = new CalculationResult();
                _calculationResult.CycleNumber = 3;
                //var xmlResultSaver = new XMLResultSaver();
                //_calculationResult = 
                //var xmlResultSaver = new XMLResultSaver();
            }
            else
            {
                MessageBox.Show("Calculations in progress, can't read now.", "Information"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnStart_ClickAsync(object sender, EventArgs e)
        {
            isStarted = true;
            btnStart.Enabled = !isStarted;
            btnStop.Enabled = isStarted;
            
            _calculator = new CalculatePrimeNumber(_calculationResult);
            var result = await _calculator.CalculateAsync();
            tbNewCycle.Text = result.CycleNumber.ToString();
            tbNewPrimeNumber.Text = result.LastPrimeNumber.ToString();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            isStarted = false;
            btnStart.Enabled = !isStarted;
            btnStop.Enabled = isStarted;

            _calculator.CancelManual();
        }


    }
}
