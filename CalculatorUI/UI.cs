using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    partial class Form1
    {
        //digit button
        private Button zeroButton;
        private Button oneButton;
        private Button twoButton;
        private Button threeButton;
        private Button fourButton;
        private Button fiveButton;
        private Button sixButton;
        private Button sevenButton;
        private Button eightButton;
        private Button nineButton;
        
        //operator
        private Button addButton;
        private Button subtractButton;
        private Button multipleButton;
        private Button divideButton;

        //other 
        private DoubleClickButton equalButton;
        private Button pointButton;
        private Button removeButton;
        private Button cleanButton;
        private Label resultLabel;
        private Label historyLabel;
        private RichTextBox RecordRichTextBox;

        private void intialUI()
        {
            //new 
            this.zeroButton = new Button();
            this.oneButton = new Button();
            this.twoButton = new Button();
            this.threeButton = new Button();
            this.fourButton = new Button();
            this.fiveButton = new Button();
            this.sixButton = new Button();
            this.sevenButton = new Button();
            this.eightButton = new Button();
            this.nineButton = new Button();

            //operation
            this.addButton = new Button();
            this.subtractButton = new Button();
            this.multipleButton = new Button();
            this.divideButton = new Button();

            //other 
            this.equalButton = new DoubleClickButton();
            this.pointButton = new Button();
            this.removeButton = new Button();
            this.cleanButton = new Button();
            this.historyLabel = new Label();
            this.resultLabel = new Label();
            this.RecordRichTextBox = new RichTextBox();

            //zeroButton
            this.zeroButton.Location = new System.Drawing.Point(110, 450);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(75, 75);
            this.zeroButton.TabIndex = 3;
            this.zeroButton.Text = "0";
            this.zeroButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Visible = true;
            this.zeroButton.Enabled = true;

            //oneButton
            this.oneButton.Location = new System.Drawing.Point(10, 350);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(75, 75);
            this.oneButton.TabIndex = 3;
            this.oneButton.Text = "1";
            this.oneButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Visible = true;
            this.oneButton.Enabled = true;

            //twoButton
            this.twoButton.Location = new System.Drawing.Point(110, 350);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(75, 75);
            this.twoButton.TabIndex = 3;
            this.twoButton.Text = "2";
            this.twoButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Visible = true;
            this.twoButton.Enabled = true;

            //threeButton
            this.threeButton.Location = new System.Drawing.Point(210, 350);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(75, 75);
            this.threeButton.TabIndex = 3;
            this.threeButton.Text = "3";
            this.threeButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Visible = true;
            this.threeButton.Enabled = true;

            //fourButton
            this.fourButton.Location = new System.Drawing.Point(10, 250);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(75, 75);
            this.fourButton.TabIndex = 3;
            this.fourButton.Text = "4";
            this.fourButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Visible = true;
            this.fourButton.Enabled = true;

            //fiveButton
            this.fiveButton.Location = new System.Drawing.Point(110, 250);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(75, 75);
            this.fiveButton.TabIndex = 3;
            this.fiveButton.Text = "5";
            this.fiveButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Visible = true;
            this.fiveButton.Enabled = true;


            //sixButton
            this.sixButton.Location = new System.Drawing.Point(210, 250);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(75, 75);
            this.sixButton.TabIndex = 3;
            this.sixButton.Text = "6";
            this.sixButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Visible = true;
            this.sixButton.Enabled = true;

            //sevenButton
            this.sevenButton.Location = new System.Drawing.Point(10, 150);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(75, 75);
            this.sevenButton.TabIndex = 3;
            this.sevenButton.Text = "7";
            this.sevenButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Visible = true;
            this.sevenButton.Enabled = true;

            //eightButton
            this.eightButton.Location = new System.Drawing.Point(110, 150);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(75, 75);
            this.eightButton.TabIndex = 3;
            this.eightButton.Text = "8";
            this.eightButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Visible = true;
            this.eightButton.Enabled = true;

            //nineButton
            this.nineButton.Location = new System.Drawing.Point(210, 150);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(75, 75);
            this.nineButton.TabIndex = 3;
            this.nineButton.Text = "9";
            this.nineButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Visible = true;
            this.nineButton.Enabled = true;

            //addButton
            this.addButton.Location = new System.Drawing.Point(310, 150);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 75);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "+";
            this.addButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = true;
            this.addButton.Enabled = true;

            //subtractButton
            this.subtractButton.Location = new System.Drawing.Point(310, 250);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 75);
            this.subtractButton.TabIndex = 3;
            this.subtractButton.Text = "-";
            this.subtractButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Visible = true;
            this.subtractButton.Enabled = true;

            //multipleButton
            this.multipleButton.Location = new System.Drawing.Point(310, 350);
            this.multipleButton.Name = "multipleButton";
            this.multipleButton.Size = new System.Drawing.Size(75, 75);
            this.multipleButton.TabIndex = 3;
            this.multipleButton.Text = "*";
            this.multipleButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.multipleButton.UseVisualStyleBackColor = true;
            this.multipleButton.Visible = true;
            this.multipleButton.Enabled = true;

            //divideButton
            this.divideButton.Location = new System.Drawing.Point(310, 450);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 75);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "/";
            this.divideButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Visible = true;
            this.divideButton.Enabled = true;

            //equalButton
            this.equalButton.Location = new System.Drawing.Point(10, 450);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(75, 75);
            this.equalButton.TabIndex = 3;
            this.equalButton.Text = "=";
            this.equalButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Visible = true;
            this.equalButton.Enabled = true;

            //pointButton
            this.pointButton.Location = new System.Drawing.Point(210, 450);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(75, 75);
            this.pointButton.TabIndex = 3;
            this.pointButton.Text = ".";
            this.pointButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Visible = true;
            this.pointButton.Enabled = true;

            //removeButton
            this.removeButton.Location = new System.Drawing.Point(310, 50);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 75);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "<-";
            this.removeButton.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Visible = true;
            this.removeButton.Enabled = true;

            //cleanButton
            this.cleanButton.Location = new System.Drawing.Point(210, 50);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 75);
            this.cleanButton.TabIndex = 3;
            this.cleanButton.Text = "C";
            this.cleanButton.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Visible = true;
            this.cleanButton.Enabled = true;

            //resultLabel
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(10, 80);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabel.Size = new System.Drawing.Size(65, 12);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Visible = true;
            this.resultLabel.Enabled = true;
            this.resultLabel.Text = "0.";

            //historyLabel
            this.historyLabel.AutoSize = true;
            this.historyLabel.Location = new System.Drawing.Point(10, 30);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.historyLabel.ForeColor = System.Drawing.Color.Gray;
            this.historyLabel.Size = new System.Drawing.Size(65, 12);
            this.historyLabel.TabIndex = 0;
            this.historyLabel.Visible = true;
            this.historyLabel.Enabled = true;
            this.historyLabel.Text = "";

            //RecordRichTextBox
            this.RecordRichTextBox.AutoSize = true;
            this.RecordRichTextBox.Location = new System.Drawing.Point(410, 50);
            this.RecordRichTextBox.Name = "historyRichTextBox";
            this.RecordRichTextBox.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RecordRichTextBox.Size = new System.Drawing.Size(200, 300);
            this.RecordRichTextBox.TabIndex = 0;
            this.RecordRichTextBox.Visible = true;
            this.RecordRichTextBox.Enabled = true;
            this.RecordRichTextBox.Text = "";

            // digit 
            this.Controls.Add(zeroButton);
            this.Controls.Add(oneButton);
            this.Controls.Add(twoButton);
            this.Controls.Add(threeButton);
            this.Controls.Add(fourButton);
            this.Controls.Add(fiveButton);
            this.Controls.Add(sixButton);
            this.Controls.Add(sevenButton);
            this.Controls.Add(eightButton);
            this.Controls.Add(nineButton);
            
            // operator
            this.Controls.Add(addButton);
            this.Controls.Add(subtractButton);
            this.Controls.Add(multipleButton);
            this.Controls.Add(divideButton);
            
            // other
            this.Controls.Add(equalButton);
            this.Controls.Add(pointButton);
            this.Controls.Add(removeButton);
            this.Controls.Add(cleanButton);
            this.Controls.Add(historyLabel);
            this.Controls.Add(resultLabel);
            //this.Controls.Add(RecordRichTextBox);
        }


    }
}
