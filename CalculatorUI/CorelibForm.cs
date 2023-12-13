using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using Corex.UI;

namespace calculatorUI
{
    public class CorelibForm : CxForm
    {
        //digit button
        private CxButton zeroButton;
        private CxButton oneButton;
        private CxButton twoButton;
        private CxButton threeButton;
        private CxButton fourButton;
        private CxButton fiveButton;
        private CxButton sixButton;
        private CxButton sevenButton;
        private CxButton eightButton;
        private CxButton nineButton;

        //operator
        private CxButton addButton;
        private CxButton subtractButton;
        private CxButton multipleButton;
        private CxButton divideButton;

        //other 
        private CxButton equalButton;
        private CxButton pointButton;
        private CxButton removeButton;
        private CxButton cleanButton;
        private CxButton emptyButton;
        private CxButton emptyButton2;

        private CxLabel resultLabel;
        private CxLabel historyLabel;
        private LayoutControl bottonLayoutControl;
        private LayoutControl bottonLayoutControl2;
        private LayoutControl bottonLayoutControl3;
        private LayoutControl bottonLayoutControl4;
        private LayoutControl bottonLayoutControl5;
        private LayoutControl bigLayout;
        private LayoutControl allLayout;
        private Stopwatch clickInteralTimeWatch;

        private calculator calculator;
        private bool isFirstClick = true;
        private bool isDoubleClick = false;

        public CorelibForm()
        {
            initializeComponent();
            initialUI();

            calculator = new calculator();
            clickInteralTimeWatch = new Stopwatch();
        }

        #region Event 
        private void initialUI()
        {
            //new 
            this.zeroButton = new CxButton("0", "zeroButton");
            this.zeroButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zeroButton.Click += new System.EventHandler(this.keyIn_Click);

            this.oneButton = new CxButton("1", "oneButton");
            this.oneButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.oneButton.Click += new System.EventHandler(this.keyIn_Click);

            this.twoButton = new CxButton("2", "twoButton");
            this.twoButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.twoButton.Click += new System.EventHandler(this.keyIn_Click);

            this.threeButton = new CxButton("3", "threeButton");
            this.threeButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.threeButton.Click += new System.EventHandler(this.keyIn_Click);

            this.fourButton = new CxButton("4", "fourButton");
            this.fourButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fourButton.Click += new System.EventHandler(this.keyIn_Click);

            this.fiveButton = new CxButton("5", "fiveButton");
            this.fiveButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fiveButton.Click += new System.EventHandler(this.keyIn_Click);

            this.sixButton = new CxButton("6", "sixButton");
            this.sixButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sixButton.Click += new System.EventHandler(this.keyIn_Click);

            this.sevenButton = new CxButton("7", "sevenButton");
            this.sevenButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sevenButton.Click += new System.EventHandler(this.keyIn_Click);

            this.eightButton = new CxButton("8", "eightButton");
            this.eightButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.eightButton.Click += new System.EventHandler(this.keyIn_Click);

            this.nineButton = new CxButton("9", "nineButton");
            this.nineButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nineButton.Click += new System.EventHandler(this.keyIn_Click);

            //operation
            this.addButton = new CxButton("+", "addButton");
            this.addButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.Click += new System.EventHandler(this.keyIn_Click);

            this.subtractButton = new CxButton("-", "subtractButton");
            this.subtractButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.subtractButton.Click += new System.EventHandler(this.keyIn_Click);

            this.multipleButton = new CxButton("*", "multipleButton");
            this.multipleButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.multipleButton.Click += new System.EventHandler(this.keyIn_Click);

            this.divideButton = new CxButton("/", "divideButton");
            this.divideButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.divideButton.Click += new System.EventHandler(this.keyIn_Click);

            //other 
            this.equalButton = new CxButton("=", "equalButton");
            this.equalButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.equalButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botton_MouseDown);

            this.pointButton = new CxButton(".", "pointButton");
            this.pointButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pointButton.Click += new System.EventHandler(this.keyIn_Click);

            this.removeButton = new CxButton("<-", "removeButton");
            this.removeButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.removeButton.Click += new System.EventHandler(this.keyIn_Click);

            this.cleanButton = new CxButton("C", "cleanButton");
            this.cleanButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cleanButton.Click += new System.EventHandler(this.keyIn_Click);

            this.emptyButton = new CxButton("", "emptyButton");

            this.emptyButton2 = new CxButton("", "emptyButton2");

            //historyLabel
            this.historyLabel = new CxLabel("", "historyLabel");
            this.historyLabel.AutoSize = true;
            this.historyLabel.Location = new System.Drawing.Point(10, 30);
            this.historyLabel.ForeColor = System.Drawing.Color.Gray;
            this.historyLabel.Size = new System.Drawing.Size(65, 12);
            this.historyLabel.TabIndex = 0;
            this.historyLabel.Visible = true;
            this.historyLabel.Enabled = true;

            //resultLabel
            this.resultLabel = new CxLabel("0.", "resultLabel");
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(10, 80);
            this.resultLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabel.Size = new System.Drawing.Size(65, 12);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Visible = true;
            this.resultLabel.Enabled = true;

            //bottonLayoutControl
            this.bottonLayoutControl = LayoutControl.NewV();
            this.bottonLayoutControl.BorderStyle = BorderStyle.None;
            this.bottonLayoutControl.Size = new Size(75, 500);
            this.bottonLayoutControl.Gap = 10;
            this.bottonLayoutControl.AddControl(oneButton, 0.25);
            this.bottonLayoutControl.AddControl(fourButton, 0.25);
            this.bottonLayoutControl.AddControl(sevenButton, 0.25);
            this.bottonLayoutControl.AddControl(equalButton, 0.25);

            this.bottonLayoutControl2 = LayoutControl.NewV();
            this.bottonLayoutControl2.BorderStyle = BorderStyle.None;
            this.bottonLayoutControl2.Size = new Size(75, 500);
            this.bottonLayoutControl2.Gap = 10;
            this.bottonLayoutControl2.AddControl(twoButton, 0.25);
            this.bottonLayoutControl2.AddControl(fiveButton, 0.25);
            this.bottonLayoutControl2.AddControl(eightButton, 0.25);
            this.bottonLayoutControl2.AddControl(zeroButton, 0.25);

            this.bottonLayoutControl3 = LayoutControl.NewV();
            this.bottonLayoutControl3.BorderStyle = BorderStyle.None;
            this.bottonLayoutControl3.Size = new Size(75, 500);
            this.bottonLayoutControl3.Gap = 10;
            this.bottonLayoutControl3.AddControl(threeButton, 0.25);
            this.bottonLayoutControl3.AddControl(sixButton, 0.25);
            this.bottonLayoutControl3.AddControl(nineButton, 0.25);
            this.bottonLayoutControl3.AddControl(pointButton, 0.25);

            this.bottonLayoutControl4 = LayoutControl.NewV();
            this.bottonLayoutControl4.BorderStyle = BorderStyle.None;
            this.bottonLayoutControl4.Size = new Size(75, 500);
            this.bottonLayoutControl4.Gap = 10;
            this.bottonLayoutControl4.AddControl(addButton, 0.25);
            this.bottonLayoutControl4.AddControl(subtractButton, 0.25);
            this.bottonLayoutControl4.AddControl(multipleButton, 0.25);
            this.bottonLayoutControl4.AddControl(divideButton, 0.25);

            this.bottonLayoutControl5 = LayoutControl.NewV();
            this.bottonLayoutControl5.Size = new Size(75, 500);
            this.bottonLayoutControl5.Gap = 10;
            this.bottonLayoutControl5.AddControl(removeButton, 0.25);
            this.bottonLayoutControl5.AddControl(cleanButton, 0.25);
            this.bottonLayoutControl5.AddControl(emptyButton, 0.25);
            this.bottonLayoutControl5.AddControl(emptyButton2, 0.25);

            // BigLayout
            this.bigLayout = LayoutControl.NewH();
            this.bigLayout.BorderStyle = BorderStyle.FixedSingle;
            this.bigLayout.Location = new System.Drawing.Point(10, 150);
            this.bigLayout.Size = new Size(500, 500);
            this.bigLayout.Gap = 10;
            this.bigLayout.AddControl(bottonLayoutControl, 0.2);
            this.bigLayout.AddControl(bottonLayoutControl2, 0.2);
            this.bigLayout.AddControl(bottonLayoutControl3, 0.2);
            this.bigLayout.AddControl(bottonLayoutControl4, 0.2);
            this.bigLayout.AddControl(bottonLayoutControl5, 0.2);

            // BigLayout
            this.allLayout = LayoutControl.NewV();
            this.allLayout.BorderStyle = BorderStyle.FixedSingle;
            this.allLayout.Location = new System.Drawing.Point(10, 150);
            this.allLayout.Dock = DockStyle.Fill;
            this.allLayout.Size = new Size(500, 500);
            this.allLayout.Gap = 10;
            this.allLayout.AddControl(historyLabel, 0.1);
            this.allLayout.AddControl(resultLabel, 0.1);
            this.allLayout.AddControl(bigLayout, 0.80);
            this.allLayout.Render();
            this.Controls.Add(this.allLayout);

        }

        private void initializeComponent()
        {
            //this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Text = "calculator";
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
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

                Corex.UI.Scheduler.UIScheduler.Schedule(this, doubleClickTimer_Tick, SystemInformation.DoubleClickTime + 50 ,
                              taskType: Corex.UI.Scheduler.UITaskType.RunOnce,
                              invokePolicy: Corex.UI.Scheduler.UITaskInvokePolicy.Always);

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

        private void doubleClickTimer_Tick()
        {
            // The timer has reached the double click time limit.
            if (clickInteralTimeWatch.Elapsed.TotalMilliseconds >= SystemInformation.DoubleClickTime)
            {
                if (isDoubleClick)
                {
                    equalButton_DoubleClick(this.equalButton, null);
                }
                else
                {
                    keyIn_Click(this.equalButton, null);
                }

                // Allow the MouseDown event handler to process clicks again.
                isFirstClick = true;
                isDoubleClick = false;
            }
        }
        #endregion
    }
}
