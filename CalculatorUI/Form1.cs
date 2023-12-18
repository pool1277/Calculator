﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace calculatorUI
{
    public partial class Form1 : Form
    {
        private bool isFirstClick = true;
        private bool isDoubleClick = false;
        private calculator calculator = new calculator();

        private Stopwatch clickInteralTimeWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            intialUI();

            //event binding
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClose);
            this.doubleClickTimer.Tick += new EventHandler(doubleClickTimer_Tick);
            this.zeroButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.oneButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.twoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.threeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.fourButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.fiveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.sixButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.sevenButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.eightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.nineButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.addButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.subtractButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.multipleButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.divideButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.equalButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botton_MouseDown);
            this.pointButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.removeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);
            this.cleanButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.keyIn_Click);

            this.zeroButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.oneButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.twoButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.threeButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.fourButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.fiveButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.sixButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.sevenButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.eightButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.nineButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.addButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.subtractButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.multipleButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.divideButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.equalButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.pointButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.removeButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.cleanButton.GotFocus += new System.EventHandler(this.OnGetFocus);
            this.recordsRichTextBox.GotFocus += new System.EventHandler(this.OnGetFocus);

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);

            calculator.UpdateRecordUI += OnUpdateRecordUI;

        }

        private void keyIn_Click(object sender, EventArgs e)
        {
            Button keyInBtn = sender as Button;
            calculator.KeyIn(keyInBtn.Text);

            Console.WriteLine(sender.ToString());
            //show result
            resultLabel.Text = calculator.DigitExpression;
            historyLabel.Text = calculator.Expression;

        }

        private void OnGetFocus(object sender, EventArgs e)
        {
            resultLabel.Focus();
        }

        private void equalButton_DoubleClick(object sender, EventArgs e)
        {
            calculator.DoubleClickEqual();

            //show result
            resultLabel.Text = calculator.DigitExpression;
            historyLabel.Text = calculator.Expression;

        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) // number 
            {
                calculator.KeyIn(Convert.ToString(e.KeyCode - Keys.NumPad0));
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                calculator.KeyIn(".");
            }
            else if (e.KeyCode == Keys.Add)
            {
                calculator.KeyIn("+");
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                calculator.KeyIn("-");
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                calculator.KeyIn("*");
            }
            else if (e.KeyCode == Keys.Divide)
            {
                calculator.KeyIn("/");
            }
            else if (e.KeyCode == Keys.Enter)
            {
                calculator.KeyIn("=");
            }
            else if (e.KeyCode == Keys.Back)
            {
                calculator.KeyIn("<-");
            }
            else if (e.KeyCode == Keys.Delete)
            {
                calculator.KeyIn("C");
            }

            //show result
            resultLabel.Text = calculator.DigitExpression;
            historyLabel.Text = calculator.Expression;

        }

        private void Botton_MouseDown(object sender, MouseEventArgs e)
        {

            if (isFirstClick)
            {
                isFirstClick = false;
                doubleClickTimer.Start();
                clickInteralTimeWatch.Restart();
            }
            else
            {
                // Verify that the mouse click is within the double click
                // rectangle and is within the system-defined double
                // click period.
                if (clickInteralTimeWatch.Elapsed.TotalMilliseconds < SystemInformation.DoubleClickTime)
                {
                    isDoubleClick = true;
                }
            }

        }

        private void doubleClickTimer_Tick(object sender, EventArgs e)
        {
            // The timer has reached the double click time limit.
            if (clickInteralTimeWatch.Elapsed.TotalMilliseconds >= SystemInformation.DoubleClickTime)
            {
                doubleClickTimer.Stop();

                if (isDoubleClick)
                {
                    equalButton_DoubleClick(this.equalButton, e);
                }
                else
                {
                    keyIn_Click(this.equalButton, e);
                }

                // Allow the MouseDown event handler to process clicks again.
                isFirstClick = true;
                isDoubleClick = false;
                doubleClickTimer.Interval = 100;

            }
        }

        private void OnUpdateRecordUI()
        {
			recordsRichTextBox.AppendText(calculator.Records.Last().record + "\n");
            recordsRichTextBox.Refresh();
        }
        private void OnFormClose(object sender, FormClosingEventArgs e)
        {
            this.doubleClickTimer.Dispose();
        }
    }
}
