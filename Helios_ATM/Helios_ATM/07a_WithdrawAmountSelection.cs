using MetroFramework;
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
    public partial class ATM7a : MetroFramework.Forms.MetroForm
    {

        public ATM7a()
        {
            InitializeComponent();
        }

        private void ATM7a_Load(object sender, EventArgs e)
        {

        }

        private async void CardInserted_Click(object sender, EventArgs e)
        {   //name of Button is not fitting but renaming leads to trouble :-(

            withdrawPrintReceipt(500);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Cancel MsgBox & close the message after certain time:
            AutoClosingMessageBox.Show("Cancelled current operation. Ejecting card and restarting...", "Aborting", 1500);

            //Going back to first form (=restart)
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            this.Visible = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //continue to Main form
            Form ATM6 = new ATM6(); // Instantiate a Form object.
            ATM6.Show(); //show the new Form

            this.Visible = false;
        }

        private void withdrawPrintReceipt(int WithdrawAmount)
        {
            //Dispense WithdrawAmount
            MetroMessageBox.Show(this, "Requested amount of " + WithdrawAmount + " Pesos is available in slot now");
            
            
            //Ask & send receipt

            var result = MetroMessageBox.Show(this, "Do you want to print a receipt?","Receipt" , MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //Doing Assans AWS Printing magic here
                AutoClosingMessageBox.Show("Finished AWS printing magic." , "Info", 1500);
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
                    AutoClosingMessageBox.Show("Finished current operation. Ejecting card and restarting...", "Restarting", 1500);
                     //return to initial screen 

                     Form ATM1 = new ATM1(); // Instantiate a Form object.
                    ATM1.Show(); //show the new Form

                    this.Visible = false;  //Hide the old form
                }

            
        }
        private void Withdraw5_Click(object sender, EventArgs e)
        {
            withdrawPrintReceipt(5);
        }

        private void Withdraw200_Click(object sender, EventArgs e)
        {
            withdrawPrintReceipt(200);
        }

        private void Withdraw100_Click(object sender, EventArgs e)
        {
            withdrawPrintReceipt(100);
        }

        private void Withdraw50_Click(object sender, EventArgs e)
        {
            withdrawPrintReceipt(50);
        }

        private void Withdraw20_Click(object sender, EventArgs e)
        {
            withdrawPrintReceipt(20);
        }

        private void Withdraw10_Click(object sender, EventArgs e)
        {
            withdrawPrintReceipt(10);
        }

        private void WithdrawOther_Click(object sender, EventArgs e)
        {
            //Go to new form for further transaction
            Form ATM7b = new ATM7b(); // Instantiate a Form object.
            ATM7b.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
        }
    }
}
