﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PrimeNumbersCalculatorGP
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private void primeNumersCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var frm in this.MdiChildren)
            {
                if (frm is FrmCalculator)
                {
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Normal;
                    }
                    frm.Focus();
                    return;
                }
            }
            var frmCalculator = new FrmCalculator();
            if (this.IsMdiContainer && !frmCalculator.IsMdiContainer)
            {
                frmCalculator.MdiParent = this;
                frmCalculator.Show();
                frmCalculator.BringToFront();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
