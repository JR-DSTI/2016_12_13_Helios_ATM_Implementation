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
    public partial class ATM7b : MetroFramework.Forms.MetroForm
    {   
        //necessary to grey out text of PIN Textfield
        private bool waterMarkActive;
        private String strWithdrawAmount="";
     
        public ATM7b()
        {
            InitializeComponent();
        }

        private void ATM7b_Load(object sender, EventArgs e1)
        {
            
            //update batterycharge and start BatteryNetworkTimer
            this.BatteryCharge.Value = battery.charge;
            this.BatteryNetworkTimer.Start();

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

        private void CardInserted_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmPINentry_Click_1(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);

            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();

            //checking whether PIN is correct:
            strWithdrawAmount = this.WithdrawAmountTextbox.Text;

            //if not CHAR then continue
            if (!strWithdrawAmount.Any(char.IsLetter)) //Continue if PIN contains only numeric
            {
                int conversion = Convert.ToInt32(strWithdrawAmount);
                if (conversion <= 500)
                {
                    string s = Lib.getATMCash("AccountATM", "0001");
                    Lib.NotEnoughCash(conversion, s);
                    Helios_ATM.ATM7a a = new Helios_ATM.ATM7a();
                     Lib l = new Lib();
                    if (l.ScanTable(conversion))
                        
                    {
                        Lib.updateTransactions(DateTime.Now.ToString("yyyyMMddHHmmss")
                          , conversion, DateTime.Now, Lib.getName("ATM", useCaseVariables.useCase)
                          );
                        Boolean flag = a.check_and_pay(conversion, useCaseVariables.useCase, Lib.getCode("ATM", useCaseVariables.useCase));

                        if (flag == true)
                        {
                            Lib.Newupdate(useCaseVariables.useCase, 0, 
                            Int32.Parse(Lib.getBalance(useCaseVariables.useCase, "ATM")) - conversion, 
                            Lib.getBankName("ATM", useCaseVariables.useCase), 
                            false, 
                            Lib.getNummer("ATM", useCaseVariables.useCase), 
                            Int32.Parse(Lib.getCheckingBalance("ATM", useCaseVariables.useCase)),
                            Lib.getCode("ATM", useCaseVariables.useCase), 
                            Lib.getName("ATM", useCaseVariables.useCase), 
                            Lib.getSavingsBalance("ATM",useCaseVariables.useCase), 
                            0);
                                Lib.updateATM(Int32.Parse(s) - conversion);
                            withdrawPrintReceipt(conversion);
                        }
                        }
                    else
                    {
                        ATM1 b = new ATM1();
                        a.Show();
                        this.Close();   
                    }
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
                String body = headz(WithdrawAmount);
                String title = "Thank you for using HELIOS Banking";
                Lib.sendMail(title, body);
                AutoClosingMessageBox.Show("Finished AWS printing magic.", "Info", 1500, this);
            }

            //Asking for Performing other transaction
            result = MetroMessageBox.Show(this, "Do you to perform another transaction?", "Return to main menu", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
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
                //Starting next form and close/hide this one
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

            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();

            //Starting next form and close/hide this one
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
            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();

            //CancelMsgBox
            AutoClosingMessageBox.Show("Cancelled current operation. Ejecting card and restarting...", "Aborting", 1500, this);

            //Log current operation:
            s3log.logOperation(sender);

            
            

            //Starting next form and close/hide this one
            //Going back to first form (restart)
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            this.Visible = false;
        }

        public String headz(int WithdrawAmount)
        {

            String header = "======================================";
            String header2 = "                 Receipt";
            String subject = "You have withdrawn " + WithdrawAmount + " Pesos";
            String timeStamp = "Date :" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");
            String activity = "Action : Withdraw";
            String ATMlocation = "Location : Munchen";
            String AccountNumber = "Account N° : ***********" + Lib.getID().Substring(2, 2);

            return (header + Environment.NewLine + header2
                + Environment.NewLine + header
                + Environment.NewLine + subject
                + Environment.NewLine + timeStamp
                + Environment.NewLine + activity
                + Environment.NewLine + ATMlocation
                + Environment.NewLine + AccountNumber
                );

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

        private void BatteryNetworkTimer_Tick(object sender, EventArgs e)
        {
            //discharge battery and check network connection:
            battery.discharge(this.BatteryCharge);
            networkConnection.networkConnectionOK(this.NetworkSignal);

            //check if the KILLSWITCH was set in the database:
            Lib.stfu();
        }
    }
}
