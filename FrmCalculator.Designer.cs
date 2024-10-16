namespace PrimeNumbersCalculatorGP
{
    partial class FrmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbRetriveLastCalculations = new System.Windows.Forms.GroupBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.gbLast = new System.Windows.Forms.GroupBox();
            this.lblcycle = new System.Windows.Forms.Label();
            this.dtpWhenPrimeNumberWasFound = new System.Windows.Forms.DateTimePicker();
            this.tbCycle = new System.Windows.Forms.TextBox();
            this.dtpCycleDuration = new System.Windows.Forms.DateTimePicker();
            this.lblLastPrimeNumber = new System.Windows.Forms.Label();
            this.lblCycleDuration = new System.Windows.Forms.Label();
            this.tbLastPrimeNumber = new System.Windows.Forms.TextBox();
            this.lblWhenPrimenumberWasFound = new System.Windows.Forms.Label();
            this.gbCalculationsCycle = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblNewCycle = new System.Windows.Forms.Label();
            this.tbNewCycle = new System.Windows.Forms.TextBox();
            this.gbRetriveLastCalculations.SuspendLayout();
            this.gbLast.SuspendLayout();
            this.gbCalculationsCycle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRetriveLastCalculations
            // 
            this.gbRetriveLastCalculations.Controls.Add(this.btnRead);
            this.gbRetriveLastCalculations.Controls.Add(this.gbLast);
            this.gbRetriveLastCalculations.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbRetriveLastCalculations.Location = new System.Drawing.Point(0, 0);
            this.gbRetriveLastCalculations.Name = "gbRetriveLastCalculations";
            this.gbRetriveLastCalculations.Size = new System.Drawing.Size(800, 245);
            this.gbRetriveLastCalculations.TabIndex = 0;
            this.gbRetriveLastCalculations.TabStop = false;
            this.gbRetriveLastCalculations.Text = "Retrive Last Calculations";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 19);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(176, 34);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read from XML";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // gbLast
            // 
            this.gbLast.Controls.Add(this.lblcycle);
            this.gbLast.Controls.Add(this.dtpWhenPrimeNumberWasFound);
            this.gbLast.Controls.Add(this.tbCycle);
            this.gbLast.Controls.Add(this.dtpCycleDuration);
            this.gbLast.Controls.Add(this.lblLastPrimeNumber);
            this.gbLast.Controls.Add(this.lblCycleDuration);
            this.gbLast.Controls.Add(this.tbLastPrimeNumber);
            this.gbLast.Controls.Add(this.lblWhenPrimenumberWasFound);
            this.gbLast.Location = new System.Drawing.Point(12, 59);
            this.gbLast.Name = "gbLast";
            this.gbLast.Size = new System.Drawing.Size(376, 177);
            this.gbLast.TabIndex = 9;
            this.gbLast.TabStop = false;
            // 
            // lblcycle
            // 
            this.lblcycle.AutoSize = true;
            this.lblcycle.Location = new System.Drawing.Point(19, 26);
            this.lblcycle.Name = "lblcycle";
            this.lblcycle.Size = new System.Drawing.Size(36, 13);
            this.lblcycle.TabIndex = 0;
            this.lblcycle.Text = "Cycle:";
            // 
            // dtpWhenPrimeNumberWasFound
            // 
            this.dtpWhenPrimeNumberWasFound.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWhenPrimeNumberWasFound.Location = new System.Drawing.Point(191, 107);
            this.dtpWhenPrimeNumberWasFound.Name = "dtpWhenPrimeNumberWasFound";
            this.dtpWhenPrimeNumberWasFound.Size = new System.Drawing.Size(125, 20);
            this.dtpWhenPrimeNumberWasFound.TabIndex = 8;
            // 
            // tbCycle
            // 
            this.tbCycle.Location = new System.Drawing.Point(61, 23);
            this.tbCycle.Name = "tbCycle";
            this.tbCycle.Size = new System.Drawing.Size(255, 20);
            this.tbCycle.TabIndex = 1;
            // 
            // dtpCycleDuration
            // 
            this.dtpCycleDuration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCycleDuration.Location = new System.Drawing.Point(114, 45);
            this.dtpCycleDuration.Name = "dtpCycleDuration";
            this.dtpCycleDuration.Size = new System.Drawing.Size(202, 20);
            this.dtpCycleDuration.TabIndex = 7;
            // 
            // lblLastPrimeNumber
            // 
            this.lblLastPrimeNumber.AutoSize = true;
            this.lblLastPrimeNumber.Location = new System.Drawing.Point(19, 74);
            this.lblLastPrimeNumber.Name = "lblLastPrimeNumber";
            this.lblLastPrimeNumber.Size = new System.Drawing.Size(99, 13);
            this.lblLastPrimeNumber.TabIndex = 2;
            this.lblLastPrimeNumber.Text = "Last Prime Number:";
            // 
            // lblCycleDuration
            // 
            this.lblCycleDuration.AutoSize = true;
            this.lblCycleDuration.Location = new System.Drawing.Point(19, 46);
            this.lblCycleDuration.Name = "lblCycleDuration";
            this.lblCycleDuration.Size = new System.Drawing.Size(79, 13);
            this.lblCycleDuration.TabIndex = 6;
            this.lblCycleDuration.Text = "Cycle Duration:";
            // 
            // tbLastPrimeNumber
            // 
            this.tbLastPrimeNumber.Location = new System.Drawing.Point(124, 71);
            this.tbLastPrimeNumber.Name = "tbLastPrimeNumber";
            this.tbLastPrimeNumber.Size = new System.Drawing.Size(192, 20);
            this.tbLastPrimeNumber.TabIndex = 3;
            // 
            // lblWhenPrimenumberWasFound
            // 
            this.lblWhenPrimenumberWasFound.AutoSize = true;
            this.lblWhenPrimenumberWasFound.Location = new System.Drawing.Point(19, 107);
            this.lblWhenPrimenumberWasFound.Name = "lblWhenPrimenumberWasFound";
            this.lblWhenPrimenumberWasFound.Size = new System.Drawing.Size(166, 13);
            this.lblWhenPrimenumberWasFound.TabIndex = 4;
            this.lblWhenPrimenumberWasFound.Text = "When Prime Number Was Found:";
            // 
            // gbCalculationsCycle
            // 
            this.gbCalculationsCycle.Controls.Add(this.lblNewCycle);
            this.gbCalculationsCycle.Controls.Add(this.tbNewCycle);
            this.gbCalculationsCycle.Controls.Add(this.btnStop);
            this.gbCalculationsCycle.Controls.Add(this.btnStart);
            this.gbCalculationsCycle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCalculationsCycle.Location = new System.Drawing.Point(0, 245);
            this.gbCalculationsCycle.Name = "gbCalculationsCycle";
            this.gbCalculationsCycle.Size = new System.Drawing.Size(800, 205);
            this.gbCalculationsCycle.TabIndex = 1;
            this.gbCalculationsCycle.TabStop = false;
            this.gbCalculationsCycle.Text = "New Calculations";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(212, 28);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(176, 34);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop cycle";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(176, 34);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start new cycle";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblNewCycle
            // 
            this.lblNewCycle.AutoSize = true;
            this.lblNewCycle.Location = new System.Drawing.Point(31, 83);
            this.lblNewCycle.Name = "lblNewCycle";
            this.lblNewCycle.Size = new System.Drawing.Size(36, 13);
            this.lblNewCycle.TabIndex = 12;
            this.lblNewCycle.Text = "Cycle:";
            // 
            // tbNewCycle
            // 
            this.tbNewCycle.Location = new System.Drawing.Point(73, 80);
            this.tbNewCycle.Name = "tbNewCycle";
            this.tbNewCycle.Size = new System.Drawing.Size(255, 20);
            this.tbNewCycle.TabIndex = 13;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCalculationsCycle);
            this.Controls.Add(this.gbRetriveLastCalculations);
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prime Numbers Calculator";
            this.gbRetriveLastCalculations.ResumeLayout(false);
            this.gbLast.ResumeLayout(false);
            this.gbLast.PerformLayout();
            this.gbCalculationsCycle.ResumeLayout(false);
            this.gbCalculationsCycle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRetriveLastCalculations;
        private System.Windows.Forms.GroupBox gbCalculationsCycle;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblcycle;
        private System.Windows.Forms.TextBox tbLastPrimeNumber;
        private System.Windows.Forms.Label lblLastPrimeNumber;
        private System.Windows.Forms.TextBox tbCycle;
        private System.Windows.Forms.Label lblCycleDuration;
        private System.Windows.Forms.Label lblWhenPrimenumberWasFound;
        private System.Windows.Forms.DateTimePicker dtpWhenPrimeNumberWasFound;
        private System.Windows.Forms.DateTimePicker dtpCycleDuration;
        private System.Windows.Forms.GroupBox gbLast;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblNewCycle;
        private System.Windows.Forms.TextBox tbNewCycle;
    }
}