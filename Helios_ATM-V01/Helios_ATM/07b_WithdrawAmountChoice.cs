﻿using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helios_ATM
{
    public partial class ATM7b : MetroFramework.Forms.MetroForm
    {   
        //necessary to grey out text of PIN Textfield
        private bool waterMarkActive;
        private String strWithdrawAmount="";
        
        //here you could insert your Data base link to PIN, PINentries
        private int PINentries=0;
        private String correctPIN = "1111";

        public ATM7b()
        {
            InitializeComponent();
            
        }

        private void ATM7b_Load(object sender, EventArgs e1)
        {
            //Initiating the field and set its values
            this.waterMarkActive = true;
            this.WithdrawAmountTextbox.ForeColor = Color.Gray;
            this.WithdrawAmountTextbox.Text = "XX,XXX.XX";

            //giving focus to the Pin text field
            this.WithdrawAmountTextbox.GotFocus += (source,e) =>
            {
                if (this.waterMarkActive)
                {
                    //change text and color of textfield
                    this.waterMarkActive = false;
                    this.WithdrawAmountTextbox.Text = "";
                    this.WithdrawAmountTextbox.ForeColor = Color.Black;
                }
            };

            this.WithdrawAmountTextbox.LostFocus += (source, e) =>
            {
                    //if the textfield is empty and the watermark is false, set it's value to ****
                if (!this.waterMarkActive && string.IsNullOrEmpty(this.WithdrawAmountTextbox.Text))
                {
                    this.waterMarkActive = true;
                    this.WithdrawAmountTextbox.Text = "XX,XXX.XX";
                    this.WithdrawAmountTextbox.ForeColor = Color.Gray;
                }
            };
        }

        private async void CardInserted_Click(object sender, EventArgs e)
        {
            //await Task.Delay(500);

            //Form ATM7 = new ATM7(); // Instantiate a Form object.
            //ATM7.Show(); //show the new Form

            //this.Visible = false;  //Hide the old form
        }

        private void ConfirmPINentry_Click_1(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);

            //checking whether PIN is correct:
            strWithdrawAmount = this.WithdrawAmountTextbox.Text;

            //if not CHAR then continue
            if (!strWithdrawAmount.Any(char.IsLetter)) //Continue if PIN contains only numeric
            {
                if (Convert.ToInt32(strWithdrawAmount) <= 500)
                {
                    withdrawPrintReceipt(Convert.ToInt32(strWithdrawAmount));
                }
                else
                {
                    MetroMessageBox.Show(this, "Choose the withdraw amount up to 500 Pesos and not above!");

                }
               

            }
            else
            {

                MetroMessageBox.Show(this, "Please provide a numercial withdraw amount.");
                this.WithdrawAmountTextbox.Text = "";
            }

            //set back to empty box:
            //this.PinEntry.Text = "";
        }
        private void withdrawPrintReceipt(int WithdrawAmount)
        {
            //Dispense WithdrawAmount
            MetroMessageBox.Show(this, "Requested amount of " + WithdrawAmount + " Pesos is available in slot now");


            //Ask & send receipt

            var result = MetroMessageBox.Show(this, "Do you want to print a receipt?", "Receipt", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //Doing Assans AWS Printing magic here
                AutoClosingMessageBox.Show("Finished AWS printing magic.", "Info", 1500, this);
            }

            //Asking for Performing other transaction
            result = MetroMessageBox.Show(this, "Do you to perform another transaction?", "Return to main menu", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Return to main menu for other transaction
                Form ATM6 = new ATM6(); // Instantiate a Form object.
                ATM6.Show(); //show the new Form

                this.Visible = false;  //Hide the old form

            }
            else
            {
                AutoClosingMessageBox.Show("Finished current operation. Ejecting card and restarting...", "Restarting", 1500, this);
                //return to initial screen 

                Form ATM1 = new ATM1(); // Instantiate a Form object.
                ATM1.Show(); //show the new Form

                this.Visible = false;  //Hide the old form
            }


        }

        //in case of keyboard access:
        private void PinEntry_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                ConfirmPINentry_Click_1(new object(), new EventArgs());
            }
        }

        //Return to previous form
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);

            Form ATM6 = new ATM6(); // Instantiate a Form object.
            ATM6.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
        }

        private void PinEntry_TextChanged(object sender, EventArgs e)
        {

        }


        //Return to initial form
        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
            
            //CancelMsgBox
            AutoClosingMessageBox.Show("Cancelled current operation. Ejecting card and restarting...", "Aborting", 1500, this);

            //Going back to first form (restart)
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            this.Visible = false;
        }


        //Button clicks to insert PIN over the form (didnt make a function for that yet, would be improvement though)
        private void Num1_Click(object sender, EventArgs e)
        {

            strWithdrawAmount = strWithdrawAmount + "1";
            this.WithdrawAmountTextbox.Text = strWithdrawAmount;
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            strWithdrawAmount = strWithdrawAmount + "2";
            this.WithdrawAmountTextbox.Text = strWithdrawAmount;
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            strWithdrawAmount = strWithdrawAmount + "3";
            this.WithdrawAmountTextbox.Text = strWithdrawAmount;
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            strWithdrawAmount = strWithdrawAmount + "4";
            this.WithdrawAmountTextbox.Text = strWithdrawAmount;
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            strWithdrawAmount = strWithdrawAmount + "5";
            this.WithdrawAmountTextbox.Text = strWithdrawAmount;
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            strWithdrawAmount = strWithdrawAmount + "6";
            this.WithdrawAmountTextbox.Text = strWithdrawAmount;
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            strWithdrawAmount = strWithdrawAmount + "7";
            this.WithdrawAmountTextbox.Text = strWithdrawAmount;
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            strWithdrawAmount = strWithdrawAmount + "8";
            this.WithdrawAmountTextbox.Text = strWithdrawAmount;
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            strWithdrawAmount = strWithdrawAmount + "9";
            this.WithdrawAmountTextbox.Text = strWithdrawAmount;
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            strWithdrawAmount = strWithdrawAmount + "0";
            this.WithdrawAmountTextbox.Text = strWithdrawAmount;
        }

        //Delete all of the PIN entry textbox
        private void NumDeleteAll_Click(object sender, EventArgs e)
        {
            strWithdrawAmount = "";
            this.WithdrawAmountTextbox.Text = strWithdrawAmount;
        }
        //Delete last number of the PIN entry textbox
        private void NumBack_Click(object sender, EventArgs e)
        {
            strWithdrawAmount = strWithdrawAmount.Substring(0, strWithdrawAmount.Length-1);
            this.WithdrawAmountTextbox.Text = strWithdrawAmount;
        }
    }
}
