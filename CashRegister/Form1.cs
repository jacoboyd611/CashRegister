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
using System.Media;

/*
Jacob Boyd
Mr. T
ICS3U

Basic cash register for Chicken.Co. 
It calculates total price and change according to the number of each item,
as well as prints a receipt.
*/


namespace CashRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double chickenPrice = 2.50;
        double gravyPrice = 1.25;
        double drinkPrice = 1.50;
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
            //Calculates subtotal, tax amount and total price
            chickenNumber = Convert.ToInt32(chickenInput.Text);
            gravyNumber = Convert.ToInt32(gravyInput.Text);
            drinkNumber = Convert.ToInt32(drinkInput.Text);
            subTotal = (chickenPrice * chickenNumber) + (gravyPrice * gravyNumber)
                + (drinkPrice * drinkNumber);
            taxAmount = taxRate * subTotal;
            totalPrice = taxAmount + subTotal;
            if (totalPrice > 0) 
            {
                subTotalOutput.Text = $"{subTotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalPrice.ToString("C")}";

                calculateChangeButton.Enabled = true;
                calculateTotalsButton.Enabled = false;
            }
            else
            {
                totalOutput.Text = "ERROR";
            }
        }

        private void CalculateChangeButton_Click(object sender, EventArgs e)
        {
            // Calculates change
            // Prevents incorrect inputs from crashinng the program
            try
            {
                tendered = Convert.ToInt32(tenderedInput.Text);
                // Prevents paying less than the total price
                if (tendered >= totalPrice)
                {
                    receiptButton.Enabled = true;
                    calculateChangeButton.Enabled = false;

                    change = tendered - totalPrice;
                    changeOuput.Text = $"{change.ToString("C")}";
                }
                else
                {
                    changeOuput.Text = "NOT ENOUGH";
                }
            }
            catch
            {
                changeOuput.Text = "NUMBERS ONLY";
            }
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            // Prints and formats the receipt
            receiptButton.Enabled = false;
            receiptLabel.Visible = true;
            wordsReceiptOutput.Visible = true;
            numbersReceiptOutput.Visible = true;

            SoundPlayer printSound = new SoundPlayer(Properties.Resources.typeWriter);
            Refresh();
            Thread.Sleep(1000);

            printSound.Play();
            receiptLabel.Text = "\n\nChicken.Co";
            Refresh();
            Thread.Sleep(500);

            printSound.Play();
            wordsReceiptOutput.Text = $"Chicken x{chickenNumber} ";
            numbersReceiptOutput.Text = $"@ {chickenPrice.ToString("C")}";
            Thread.Sleep(500);

            printSound.Play();
            wordsReceiptOutput.Text += $"\nGravy x{gravyNumber}";
            numbersReceiptOutput.Text += $"\n@ {gravyPrice.ToString("C")}";
            Thread.Sleep(500);

            printSound.Play();
            wordsReceiptOutput.Text += $"\nDrinks x{drinkNumber}";
            numbersReceiptOutput.Text += $"\n@ {drinkPrice.ToString("C")}";
            Thread.Sleep(500);

            printSound.Play();
            wordsReceiptOutput.Text += $"\n\nSubtotal ";
            numbersReceiptOutput.Text += $"\n\n{subTotal.ToString("C")}";
            Thread.Sleep(500);

            printSound.Play();
            wordsReceiptOutput.Text += $"\nTax ";
            numbersReceiptOutput.Text += $"\n{taxAmount.ToString("C")}";
            Thread.Sleep(500);

            printSound.Play();
            wordsReceiptOutput.Text += $"\nTotal ";
            numbersReceiptOutput.Text += $"\n{totalPrice.ToString("C")}";
            Thread.Sleep(500);

            printSound.Play();
            wordsReceiptOutput.Text += $"\n\nTendered ";
            numbersReceiptOutput.Text += $"\n\n{tendered.ToString("C")}";
            Thread.Sleep(500);

            printSound.Play();
            wordsReceiptOutput.Text += $"\nChange";
            numbersReceiptOutput.Text += $"\n{change.ToString("C")}";
            Thread.Sleep(500);

            wordsReceiptOutput.Text += $"\n\nHave a nice day.";
            Thread.Sleep(500);

        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            // Resets the program
            subTotal = 0;
            taxAmount = 0;
            totalPrice = 0;
            tendered = 0;
            change = 0;
            chickenNumber = 0;
            gravyNumber = 0;
            drinkNumber = 0;

            receiptLabel.Text = "";
            wordsReceiptOutput.Text = "";
            numbersReceiptOutput.Text = "";

            subTotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            changeOuput.Text = "";

            chickenInput.Text = "0";
            gravyInput.Text = "0";
            drinkInput.Text = "0";
            tenderedInput.Text = "";

            receiptLabel.Visible = false;
            wordsReceiptOutput.Visible = false;
            numbersReceiptOutput.Visible = false;

            calculateTotalsButton.Enabled = true;
            calculateChangeButton.Enabled = false;
            receiptButton.Enabled = false;
        }
    }
}
