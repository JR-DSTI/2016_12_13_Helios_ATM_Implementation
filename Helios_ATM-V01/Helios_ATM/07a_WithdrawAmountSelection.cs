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


        //refactored functions


        //check if the Balance is smaller than the withdrawn money
        //if not, then calls the function withdraw+print
        // the update of the bank account in the Amazon Dynamo DB is left to be implemented


        public void check_and_pay(int balance)
        
        {
            Boolean withdraw = true;
            if (Int32.Parse(Lib.getBalance()) < balance)
            {
                MessageBox.Show("Sorry, but ur broke dude.");
                withdraw=false;

            }
            else
            {
                String strBalance = Lib.getBalance();
                double newBalance=Int32.Parse(strBalance)-500;
                Lib.update("1111", false, newBalance);
                Lib.getBalance();
                withdrawPrintReceipt(balance);
            }
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


                String body=headz(WithdrawAmount);
                String title = "Thank you for using HELIOS Banking";
                Lib.sendMail(title, body);
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

        //Withdraw buttons options.

        private void Withdraw500_Click(object sender, EventArgs e)
        {
            check_and_pay(500);
        }

        private void Withdraw5_Click(object sender, EventArgs e)
        { 
            check_and_pay(5);   
        }

        private void Withdraw200_Click(object sender, EventArgs e)
        {
            check_and_pay(200);        
        }

        private void Withdraw100_Click(object sender, EventArgs e)
        {
            check_and_pay(100);       
        }

        private void Withdraw50_Click(object sender, EventArgs e)
        {
            check_and_pay(50);         
        }

        private void Withdraw20_Click(object sender, EventArgs e)
        {
            check_and_pay(20);      
        }

        private void Withdraw10_Click(object sender, EventArgs e)
        {
            check_and_pay(20);
        }

        private void WithdrawOther_Click(object sender, EventArgs e)
        {
            //Go to new form for further transaction
            Form ATM7b = new ATM7b(); // Instantiate a Form object.
            ATM7b.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
        }

        public String headz(int WithdrawAmount)
        {
  
        String header = "======================================";
        String header2 = "                 Receipt";
        String subject = "You have withdrawn " + WithdrawAmount+ "Pesos";
        String timeStamp = "Date :" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");
        String activity = "Action : Withdraw";
        String ATMlocation = "Location : Munchen";
        String AccountNumber = "Account N° : ***********"+Lib.getID().Substring(2,2);

        return (header + Environment.NewLine + header2 
            + Environment.NewLine + header 
            + Environment.NewLine + subject 
            + Environment.NewLine + timeStamp 
            + Environment.NewLine + activity
            + Environment.NewLine + ATMlocation
            + Environment.NewLine + AccountNumber
            );

        }

    }
}
