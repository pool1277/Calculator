using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            intialUI();

            //event binding
            this.zeroButton.Click += new System.EventHandler(this.keyIn_Click);
            this.oneButton.Click += new System.EventHandler(this.keyIn_Click);
            this.twoButton.Click += new System.EventHandler(this.keyIn_Click);
            this.threeButton.Click += new System.EventHandler(this.keyIn_Click);
            this.fourButton.Click += new System.EventHandler(this.keyIn_Click);
            this.fiveButton.Click += new System.EventHandler(this.keyIn_Click);
            this.sixButton.Click += new System.EventHandler(this.keyIn_Click);
            this.sevenButton.Click += new System.EventHandler(this.keyIn_Click);
            this.eightButton.Click += new System.EventHandler(this.keyIn_Click);
            this.nineButton.Click += new System.EventHandler(this.keyIn_Click);
            this.addButton.Click += new System.EventHandler(this.keyIn_Click);
            this.subtractButton.Click += new System.EventHandler(this.keyIn_Click);
            this.multipleButton.Click += new System.EventHandler(this.keyIn_Click);
            this.divideButton.Click += new System.EventHandler(this.keyIn_Click);
            this.equalButton.Click -= new System.EventHandler(this.keyIn_Click);
            this.equalButton.Click += new System.EventHandler(this.keyIn_Click);
            this.equalButton.DoubleClick += new System.EventHandler(this.equalButton_DoubleClick);
            this.pointButton.Click += new System.EventHandler(this.keyIn_Click);
            this.removeButton.Click += new System.EventHandler(this.keyIn_Click);
            this.cleanButton.Click += new System.EventHandler(this.keyIn_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
        }

        private void keyIn_Click(object sender, EventArgs e)
        {
            Button keyInBtn = sender as Button;
            Calculator.KeyIn(keyInBtn.Text);

            Console.WriteLine(sender.ToString());
            //show result
            resultLabel.Text = Calculator.DigitExpression;
            historyLabel.Text = Calculator.Expression;

        }
        private void equalButton_DoubleClick(object sender, EventArgs e)
        {
            Calculator.DoubleClickEqual();

            //show result
            resultLabel.Text = Calculator.DigitExpression;
            historyLabel.Text = Calculator.Expression;
        }
        private void OnKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) // number 
            {
                Calculator.KeyIn(Convert.ToString(e.KeyCode - Keys.NumPad0));
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                Calculator.KeyIn(".");
            }
            else if (e.KeyCode == Keys.Add)
            {
                Calculator.KeyIn("+");
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                Calculator.KeyIn("-");
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                Calculator.KeyIn("*");
            }
            else if (e.KeyCode == Keys.Divide)
            {
                Calculator.KeyIn("/");
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Calculator.KeyIn("=");
            }
            else if (e.KeyCode == Keys.Back)
            {
                Calculator.KeyIn("<-");
            }
            else if (e.KeyCode  == Keys.Delete)
            {
                Calculator.KeyIn("C");
            }

            //show result
            resultLabel.Text = Calculator.DigitExpression;
            historyLabel.Text = Calculator.Expression;
        }
        

    }
}
