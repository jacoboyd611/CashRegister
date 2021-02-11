﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double chickenPrice = 4.00;
        double gravyPrice = 1.25;
        double drinkPrice = 2.00;
        int chickenNumber;
        int gravyNumber;
        int drinkNumber;
        double subTotal;
        double taxRate = 0.13;
        double taxAmount;
        double totalPrice;
        double tendered;
        double change;


        private void CalculateTotalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                chickenNumber = Convert.ToInt32(chickenInput.Text);
                gravyNumber = Convert.ToInt32(gravyInput.Text);
                drinkNumber = Convert.ToInt32(drinkInput.Text);
                subTotal = (chickenPrice * chickenNumber) + (gravyPrice * gravyNumber)
                    + (drinkPrice * drinkNumber);
                subTotalOutput.Text = $"{subTotal.ToString("C")}";

                taxAmount = taxRate * subTotal;
                taxOutput.Text = $"{taxAmount.ToString("C")}";

                totalPrice = taxAmount + subTotal;
                totalOutput.Text = $"{totalPrice.ToString("C")}";
            }
            catch
            {
                totalOutput.Text = "NUMBERS ONLY";
            }
        }

        private void CalculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToInt32(tenderedInput.Text);
                change = tendered - totalPrice;
                changeOuput.Text = $"{change.ToString("C")}";
            }
            catch
            {
                changeOuput.Text = "NUMBERS ONLY";
            }
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Visible = true;
            wordsReceiptOutput.Visible = true;
            numbersReceiptOutput.Visible = true;
            Thread.Sleep(500);

            receiptLabel.Text = "\n\nChicken.Co";
            Refresh();
            Thread.Sleep(500);

            wordsReceiptOutput.Text = $"Chicken x{chickenNumber} ";
            numbersReceiptOutput.Text = $"@ {chickenPrice.ToString("C")}";
            Thread.Sleep(500);

            wordsReceiptOutput.Text += $"\nGravy x{gravyNumber}";
            numbersReceiptOutput.Text += $"\n@ {gravyPrice.ToString("C")}";
            Thread.Sleep(500);

            wordsReceiptOutput.Text += $"\nDrinks x{drinkNumber}";
            numbersReceiptOutput.Text += $"\n@ {drinkPrice.ToString("C")}";
            Thread.Sleep(500);

            wordsReceiptOutput.Text += $"\n\nSubtotal ";
            numbersReceiptOutput.Text += $"\n\n{subTotal.ToString("C")}";
            Thread.Sleep(500);

            wordsReceiptOutput.Text += $"\nTax ";
            numbersReceiptOutput.Text += $"\n{taxAmount.ToString("C")}";
            Thread.Sleep(500);

            wordsReceiptOutput.Text += $"\nTotal ";
            numbersReceiptOutput.Text += $"\n{totalPrice.ToString("C")}";
            Thread.Sleep(500);

            wordsReceiptOutput.Text += $"\n\nTendered ";
            numbersReceiptOutput.Text += $"\n\n{tendered.ToString("C")}";
            Thread.Sleep(500);

            wordsReceiptOutput.Text += $"\nChange";
            numbersReceiptOutput.Text += $"\n{change.ToString("C")}";
            Thread.Sleep(500);
            
        }
    }
}
