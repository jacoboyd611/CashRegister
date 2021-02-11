namespace CashRegister
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chickenInput = new System.Windows.Forms.TextBox();
            this.gravyInput = new System.Windows.Forms.TextBox();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.calculateTotalsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.changeOuput = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.wordsReceiptOutput = new System.Windows.Forms.Label();
            this.numbersReceiptOutput = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Chicken";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Gravy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Drinks";
            // 
            // chickenInput
            // 
            this.chickenInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chickenInput.Location = new System.Drawing.Point(225, 9);
            this.chickenInput.Name = "chickenInput";
            this.chickenInput.Size = new System.Drawing.Size(51, 26);
            this.chickenInput.TabIndex = 3;
            this.chickenInput.Text = "0";
            // 
            // gravyInput
            // 
            this.gravyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravyInput.Location = new System.Drawing.Point(225, 41);
            this.gravyInput.Name = "gravyInput";
            this.gravyInput.Size = new System.Drawing.Size(51, 26);
            this.gravyInput.TabIndex = 4;
            this.gravyInput.Text = "0";
            // 
            // drinkInput
            // 
            this.drinkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkInput.Location = new System.Drawing.Point(225, 72);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(51, 26);
            this.drinkInput.TabIndex = 5;
            this.drinkInput.Text = "0";
            // 
            // calculateTotalsButton
            // 
            this.calculateTotalsButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.calculateTotalsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateTotalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateTotalsButton.Location = new System.Drawing.Point(12, 114);
            this.calculateTotalsButton.Name = "calculateTotalsButton";
            this.calculateTotalsButton.Size = new System.Drawing.Size(264, 31);
            this.calculateTotalsButton.TabIndex = 6;
            this.calculateTotalsButton.Text = "Calculate Totals";
            this.calculateTotalsButton.UseVisualStyleBackColor = false;
            this.calculateTotalsButton.Click += new System.EventHandler(this.CalculateTotalsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sub Total";
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.Control;
            this.totalOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(104, 215);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(165, 19);
            this.totalOutput.TabIndex = 15;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.SystemColors.Control;
            this.taxOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(104, 184);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(161, 26);
            this.taxOutput.TabIndex = 16;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.BackColor = System.Drawing.SystemColors.Control;
            this.subTotalOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.Location = new System.Drawing.Point(118, 155);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(147, 26);
            this.subTotalOutput.TabIndex = 17;
            this.subTotalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(19, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(225, 275);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(51, 26);
            this.tenderedInput.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tendered";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.calculateChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChangeButton.Location = new System.Drawing.Point(12, 307);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(264, 31);
            this.calculateChangeButton.TabIndex = 21;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = false;
            this.calculateChangeButton.Click += new System.EventHandler(this.CalculateChangeButton_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.receiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Location = new System.Drawing.Point(12, 390);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(264, 31);
            this.receiptButton.TabIndex = 24;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "Change";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeOuput
            // 
            this.changeOuput.BackColor = System.Drawing.SystemColors.Control;
            this.changeOuput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOuput.Location = new System.Drawing.Point(112, 357);
            this.changeOuput.Name = "changeOuput";
            this.changeOuput.Size = new System.Drawing.Size(157, 19);
            this.changeOuput.TabIndex = 25;
            this.changeOuput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptLabel
            // 
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(360, 13);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(275, 368);
            this.receiptLabel.TabIndex = 26;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.receiptLabel.Visible = false;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Location = new System.Drawing.Point(316, 390);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(369, 31);
            this.newOrderButton.TabIndex = 27;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // wordsReceiptOutput
            // 
            this.wordsReceiptOutput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.wordsReceiptOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsReceiptOutput.Location = new System.Drawing.Point(395, 102);
            this.wordsReceiptOutput.Name = "wordsReceiptOutput";
            this.wordsReceiptOutput.Size = new System.Drawing.Size(110, 260);
            this.wordsReceiptOutput.TabIndex = 28;
            this.wordsReceiptOutput.Visible = false;
            // 
            // numbersReceiptOutput
            // 
            this.numbersReceiptOutput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.numbersReceiptOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersReceiptOutput.Location = new System.Drawing.Point(511, 102);
            this.numbersReceiptOutput.Name = "numbersReceiptOutput";
            this.numbersReceiptOutput.Size = new System.Drawing.Size(89, 260);
            this.numbersReceiptOutput.TabIndex = 29;
            this.numbersReceiptOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.numbersReceiptOutput.Visible = false;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 89);
            this.label10.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(12, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 96);
            this.label11.TabIndex = 31;
            this.label11.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CashRegister.Properties.Resources.chickenBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.numbersReceiptOutput);
            this.Controls.Add(this.wordsReceiptOutput);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.changeOuput);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calculateTotalsButton);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.gravyInput);
            this.Controls.Add(this.chickenInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chicken.Co";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox chickenInput;
        private System.Windows.Forms.TextBox gravyInput;
        private System.Windows.Forms.TextBox drinkInput;
        private System.Windows.Forms.Button calculateTotalsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label changeOuput;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label wordsReceiptOutput;
        private System.Windows.Forms.Label numbersReceiptOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

