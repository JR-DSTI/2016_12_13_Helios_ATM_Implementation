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
            Lib.stfu();
            //update batterycharge and start BatteryNetworkTimer
            this.BatteryCharge.Value = battery.charge;
            this.BatteryNetworkTimer.Start();
        }



        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Cancel MsgBox & close the message after certain time:
            AutoClosingMessageBox.Show("Cancelled current operation. Ejecting card and restarting...", "Aborting", 1500, this);
            
            //Log current operation:
            s3log.logOperation(sender);

            
            

            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();

            //Starting next form and close/hide this one
            //Going back to first form (=restart)
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            this.Visible = false;

            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();

            //Starting next form and close/hide this one
            //continue to Main form
            Form ATM6 = new ATM6(); // Instantiate a Form object.
            ATM6.Show(); //show the new Form

            this.Visible = false;

            //Log current operation:
            s3log.logOperation(sender);
        }


        //refactored functions


        //check if the Balance is smaller than the withdrawn money
        //if not, then calls the function withdraw+print
        // the update of the bank account in the Amazon Dynamo DB is left to be implemented


        public Boolean check_and_pay(int balance,String mycase,String code)
        {
            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();

            if (Int32.Parse(Lib.getBalance(mycase, "ATM")) < balance)
            {
                AutoClosingMessageBox.Show("Sorry, but ur broke dude.", "Poor broke dude", 1000, Parent: Form.ActiveForm);
                //update s3log:
                s3log.logOperation(null , "Blocked withdrawal due to unsufficient account balance.");
                return false;
            }
            else
            {   
                //get the balance
                String strBalance = Lib.getBalance(mycase, "ATM");
                double newBalance=Int32.Parse(strBalance)- balance;

                //Update database with new balance:
                Lib.Newupdate(mycase,
                                0,
                                Int32.Parse(Lib.getBalance(mycase, "ATM")),
                                Lib.getBankName("ATM",mycase), 
                                Lib.getBlocked("ATM",mycase), Lib.getCode("ATM",mycase), 
                                Int32.Parse(Lib.getCheckingBalance("ATM",useCaseVariables.useCase)),
                                Lib.getCode("ATM",mycase), 
                                Lib.getName("ATM",mycase),
                                Lib.getSavingsBalance("ATM", mycase), 
                                0);
                //Lib.update("ATM","0002",0, false, newBalance,"1111"); 
                //Lib.getBalance(mycase, "ATM");

                //Print the receipt:
                withdrawPrintReceipt(balance);
                s3log.logOperation(null, "Withdrawal success.");
                return true;
            }

        }
        private void withdrawPrintReceipt(int WithdrawAmount)
        {
            //Dispense WithdrawAmount
            AutoClosingMessageBox.Show("Requested amount of " + WithdrawAmount + " Pesos is available in slot now","Info", 1500, this);
            s3log.logOperation(null, "Withdrawal success: " + WithdrawAmount + " Pesos given out in slot.");

            //Ask & send receipt

            var result = MetroMessageBox.Show(this, "Do you want to print a receipt?","Receipt" , MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //s3 logging
                s3log.logOperation(null, "Receipt printing requested.");

               
                
                //Doing Assans AWS Printing magic here
                //Building the message and sending the mail:
                //String body =headz(WithdrawAmount);
                //String title = "Thank you for using HELIOS Banking";

                Lib.sendText(WithdrawAmount,useCaseVariables.strNotificationAddress);
                //Lib.sendMail(title, body);
                AutoClosingMessageBox.Show("Finished AWS printing magic." , "Info", 1500, this);

            }
           
                //Asking for Performing other transaction
                result = MetroMessageBox.Show(this, "Do you to perform another transaction?", "Return to main menu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //s3 logging
                    s3log.logOperation(null, "User requested another transaction.");

                    //stop the BatteryNetworkTimer
                    this.BatteryNetworkTimer.Stop();

                    //Starting next form and close/hide this one
                    //Return to main menu for other transaction
                    Form ATM6 = new ATM6(); // Instantiate a Form object.
                    ATM6.Show(); //show the new Form

                    this.Visible = false;  //Hide the old form

                }
                else
                {
                    AutoClosingMessageBox.Show("Finished current operation. Ejecting card and restarting...", "Restarting", 1500, this);
                    //return to initial screen 

                    //stop the BatteryNetworkTimer
                    this.BatteryNetworkTimer.Stop();

                    //Starting next form and close/hide this one
                    Form ATM1 = new ATM1(); // Instantiate a Form object.
                    ATM1.Show(); //show the new Form

                    this.Visible = false;  //Hide the old form
                }

            
        }

        //Withdraw buttons options.

        private void Withdraw500_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
            string s = Lib.getATMCash("AccountATM","0001");
            Lib.NotEnoughCash(500, s); 
                Lib l = new Lib();
                if (l.ScanTable(500) )
                    {
                     Lib.updateTransactions(DateTime.Now.ToString("yyyyMMddHHmmss")
                    ,500,DateTime.Now,Lib.getName("ATM",useCaseVariables.useCase)
                    );
                    Boolean flag = check_and_pay(500, useCaseVariables.useCase, Lib.getCode("ATM", useCaseVariables.useCase));
                    if (flag == true)
                    {
                        Lib.Newupdate(useCaseVariables.useCase, 0,
                        Int32.Parse(Lib.getBalance(useCaseVariables.useCase, "ATM")) - 500,
                        Lib.getBankName("ATM", useCaseVariables.useCase),
                        false,
                        Lib.getNummer("ATM", useCaseVariables.useCase),
                        Int32.Parse(Lib.getCheckingBalance("ATM", useCaseVariables.useCase)),
                        Lib.getCode("ATM", useCaseVariables.useCase),
                        Lib.getName("ATM", useCaseVariables.useCase),
                        Lib.getSavingsBalance("ATM", useCaseVariables.useCase),
                        0);
                        Lib.updateATM(Int32.Parse(s) - 500);
                }
            }
            else
                {        
                    ATM1 a = new ATM1();
                    a.Show();
                    this.Close();
                }
            }
        

        private void Withdraw5_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
            string s = Lib.getATMCash("AccountATM", "0001");
            Lib.NotEnoughCash(5, s);
            Lib l = new Lib();
            if (l.ScanTable(5))
            {
                Lib.updateTransactions(DateTime.Now.ToString("yyyyMMddHHmmss")
               , 5, DateTime.Now, Lib.getName("ATM", useCaseVariables.useCase)
               );
                Boolean flag = check_and_pay(5, useCaseVariables.useCase, Lib.getCode("ATM", useCaseVariables.useCase));
                if (flag == true)
                {
                    Lib.Newupdate(useCaseVariables.useCase, 0,
                    Int32.Parse(Lib.getBalance(useCaseVariables.useCase, "ATM")) - 5,
                    Lib.getBankName("ATM", useCaseVariables.useCase),
                    false,
                    Lib.getNummer("ATM", useCaseVariables.useCase),
                    Int32.Parse(Lib.getCheckingBalance("ATM", useCaseVariables.useCase)),
                    Lib.getCode("ATM", useCaseVariables.useCase),
                    Lib.getName("ATM", useCaseVariables.useCase),
                    Lib.getSavingsBalance("ATM", useCaseVariables.useCase),
                    0);
                    Lib.updateATM(Int32.Parse(s) - 5);
                }
            }
            else
            {
                ATM1 a = new ATM1();
                a.Show();
                this.Close();
            }
        }
        private void Withdraw200_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
            string s = Lib.getATMCash("AccountATM", "0001");
            Lib.NotEnoughCash(200, s);
            Lib l = new Lib();
            if (l.ScanTable(200))
            {
                Lib.updateTransactions(DateTime.Now.ToString("yyyyMMddHHmmss")
               , 200, DateTime.Now, Lib.getName("ATM", useCaseVariables.useCase)
               );
                Boolean flag = check_and_pay(200, useCaseVariables.useCase, Lib.getCode("ATM", useCaseVariables.useCase));
                if (flag == true)
                {
                    Lib.Newupdate(useCaseVariables.useCase, 0,
                    Int32.Parse(Lib.getBalance(useCaseVariables.useCase, "ATM")) - 200,
                    Lib.getBankName("ATM", useCaseVariables.useCase),
                    false,
                    Lib.getNummer("ATM", useCaseVariables.useCase),
                    Int32.Parse(Lib.getCheckingBalance("ATM", useCaseVariables.useCase)),
                    Lib.getCode("ATM", useCaseVariables.useCase),
                    Lib.getName("ATM", useCaseVariables.useCase),
                    Lib.getSavingsBalance("ATM", useCaseVariables.useCase),
                    0);
                    Lib.updateATM(Int32.Parse(s) - 200);
                }
            }
            else
            {
                ATM1 a = new ATM1();
                a.Show();
                this.Close();
            }
        }

        private void Withdraw100_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
            string s = Lib.getATMCash("AccountATM", "0001");
            Lib.NotEnoughCash(100, s);
            Lib l = new Lib();
            if (l.ScanTable(100))
            {
                Lib.updateTransactions(DateTime.Now.ToString("yyyyMMddHHmmss")
               , 100, DateTime.Now, Lib.getName("ATM", useCaseVariables.useCase)
               );
                Boolean flag = check_and_pay(100, useCaseVariables.useCase, Lib.getCode("ATM", useCaseVariables.useCase));
                if (flag == true)
                {
                    Lib.Newupdate(useCaseVariables.useCase, 0,
                    Int32.Parse(Lib.getBalance(useCaseVariables.useCase, "ATM")) - 100,
                    Lib.getBankName("ATM", useCaseVariables.useCase),
                    false,
                    Lib.getNummer("ATM", useCaseVariables.useCase),
                    Int32.Parse(Lib.getCheckingBalance("ATM", useCaseVariables.useCase)),
                    Lib.getCode("ATM", useCaseVariables.useCase),
                    Lib.getName("ATM", useCaseVariables.useCase),
                    Lib.getSavingsBalance("ATM", useCaseVariables.useCase),
                    0);
                    Lib.updateATM(Int32.Parse(s) - 100);
                }
            }
            else
            {
                ATM1 a = new ATM1();
                a.Show();
                this.Close();
            }
        }

        private void Withdraw50_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
            string s = Lib.getATMCash("AccountATM", "0001");
            Lib.NotEnoughCash(50, s);
            Lib l = new Lib();
            if (l.ScanTable(50))
            {
                Lib.updateTransactions(DateTime.Now.ToString("yyyyMMddHHmmss")
               , 50, DateTime.Now, Lib.getName("ATM", useCaseVariables.useCase)
               );
                Boolean flag = check_and_pay(50, useCaseVariables.useCase, Lib.getCode("ATM", useCaseVariables.useCase));
                if (flag == true)
                {
                    Lib.Newupdate(useCaseVariables.useCase, 0,
                    Int32.Parse(Lib.getBalance(useCaseVariables.useCase, "ATM")) - 50,
                    Lib.getBankName("ATM", useCaseVariables.useCase),
                    false,
                    Lib.getNummer("ATM", useCaseVariables.useCase),
                    Int32.Parse(Lib.getCheckingBalance("ATM", useCaseVariables.useCase)),
                    Lib.getCode("ATM", useCaseVariables.useCase),
                    Lib.getName("ATM", useCaseVariables.useCase),
                    Lib.getSavingsBalance("ATM", useCaseVariables.useCase),
                    0);
                    Lib.updateATM(Int32.Parse(s) - 50);
                }
            }
            else
            {
                ATM1 a = new ATM1();
                a.Show();
                this.Close();
            }
        }

        private void Withdraw20_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
            string s = Lib.getATMCash("AccountATM", "0001");
            Lib.NotEnoughCash(20, s);
            Lib l = new Lib();
            if (l.ScanTable(20))
            {
                Lib.updateTransactions(DateTime.Now.ToString("yyyyMMddHHmmss")
               , 20, DateTime.Now, Lib.getName("ATM", useCaseVariables.useCase)
               );
                Boolean flag = check_and_pay(20, useCaseVariables.useCase, Lib.getCode("ATM", useCaseVariables.useCase));
                if (flag == true)
                {
                    Lib.Newupdate(useCaseVariables.useCase, 0,
                    Int32.Parse(Lib.getBalance(useCaseVariables.useCase, "ATM")) - 20,
                    Lib.getBankName("ATM", useCaseVariables.useCase),
                    false,
                    Lib.getNummer("ATM", useCaseVariables.useCase),
                    Int32.Parse(Lib.getCheckingBalance("ATM", useCaseVariables.useCase)),
                    Lib.getCode("ATM", useCaseVariables.useCase),
                    Lib.getName("ATM", useCaseVariables.useCase),
                    Lib.getSavingsBalance("ATM", useCaseVariables.useCase),
                    0);
                    Lib.updateATM(Int32.Parse(s) - 20);
                }
            }
            else
            {
                ATM1 a = new ATM1();
                a.Show();
                this.Close();
            }
        }
        private void Withdraw10_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
            string s = Lib.getATMCash("AccountATM", "0001");
            Lib.NotEnoughCash(10, s);
            Lib l = new Lib();
            if (l.ScanTable(10))
            {
                Lib.updateTransactions(DateTime.Now.ToString("yyyyMMddHHmmss")
               , 10, DateTime.Now, Lib.getName("ATM", useCaseVariables.useCase)
               );
                Boolean flag = check_and_pay(10, useCaseVariables.useCase, Lib.getCode("ATM", useCaseVariables.useCase));
                if (flag == true)
                {
                    Lib.Newupdate(useCaseVariables.useCase, 0,
                    Int32.Parse(Lib.getBalance(useCaseVariables.useCase, "ATM")) - 10,
                    Lib.getBankName("ATM", useCaseVariables.useCase),
                    false,
                    Lib.getNummer("ATM", useCaseVariables.useCase),
                    Int32.Parse(Lib.getCheckingBalance("ATM", useCaseVariables.useCase)),
                    Lib.getCode("ATM", useCaseVariables.useCase),
                    Lib.getName("ATM", useCaseVariables.useCase),
                    Lib.getSavingsBalance("ATM", useCaseVariables.useCase),
                    0);
                    Lib.updateATM(Int32.Parse(s) - 10);
                }
            }
            else
            {
                ATM1 a = new ATM1();
                a.Show();
                this.Close();
            }
        }

        private void WithdrawOther_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
            
            //Go to new form for further transaction
            Form ATM7b = new ATM7b(); // Instantiate a Form object.
            ATM7b.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
        }

        public String headz(int WithdrawAmount)
        {
            //Building the string for the message:
            String header = "======================================";
            String header2 = "                 Receipt";
            String subject = "You have withdrawn " + WithdrawAmount+ " Pesos";
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

        private void BatteryNetworkTimer_Tick(object sender, EventArgs e)
        {
            //discharge battery and check network connection:
            battery.discharge(this.BatteryCharge);
            networkConnection.networkConnectionOK(this.NetworkSignal);
        }
    }
}
