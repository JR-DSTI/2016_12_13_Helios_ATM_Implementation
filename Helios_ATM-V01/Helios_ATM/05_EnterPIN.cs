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
using System.IO;

namespace Helios_ATM
{
    public partial class ATM5 : MetroFramework.Forms.MetroForm
    {   
        //necessary to grey out text of PIN Textfield
        private bool waterMarkActive;
        private String PIN;
        
        //here you could insert your Data base link to PIN, PINentries
        private int PINentries=0;
        private String correctPIN = Lib.getCode("ATM",useCaseVariables.useCase);

        public ATM5()
        {
            InitializeComponent();   
        }

        private void ATM5_Load(object sender, EventArgs e1)
        {
            //setting the current Batterycharge and Network signal:
            this.BatteryCharge.Value = battery.charge;
            this.BatteryNetworkTimer.Start();

            //Initiating the field and set its values
            this.waterMarkActive = true;
            this.PinEntry.ForeColor = Color.Gray;
            this.PinEntry.Text = "****";

            //giving focus to the Pin text field
            this.PinEntry.GotFocus += (source,e) =>
            {
                if (this.waterMarkActive)
                {
                    //change text and color of textfield
                    this.waterMarkActive = false;
                    this.PinEntry.Text = "";
                    this.PinEntry.ForeColor = Color.Black;
                }
            };

            this.PinEntry.LostFocus += (source, e) =>
            {
                    //if the textfield is empty and the watermark is false, set it's value to ****
                if (!this.waterMarkActive && string.IsNullOrEmpty(this.PinEntry.Text))
                {
                    this.waterMarkActive = true;
                    this.PinEntry.Text = "****";
                    this.PinEntry.ForeColor = Color.Gray;
                }
            };
        }

        private async void CardInserted_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            //Starting next form and close/hide this one
            Form ATM7 = new ATM7(); // Instantiate a Form object.
            ATM7.Show(); //show the new Form
            this.Visible = false;  //Hide the old form

            //Log current operation:
            s3log.logOperation(sender);

            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();
        }

        private void ConfirmPINentry_Click_1(object sender, EventArgs e)
        {
            //Boolean blocked = false;
            //checking whether PIN is correct:
            PIN = this.PinEntry.Text;

            //Log current operation & all inputs later
            s3log.logOperation(sender);
            

            //if ( useCaseVariables.bCheckBoxPINEntriesExhausted)
            if (Lib.getBlocked("ATM",useCaseVariables.useCase))
            {
                AutoClosingMessageBox.Show("No attempts left, no money for you, your card is being captured.", "Bad news", 2000, Parent: Form.ActiveForm);
                PINentries = 3;
                //blocked=true;
                
                //update s3log:
                s3log.logOperation(null, "PIN entries blocked.");

                this.Close();
            }
            
            //if not CHAR then continue
            else if (!PIN.Any(char.IsLetter)) //Continue if PIN contains only numeric
            {
                //blocked = false;
                //increasing the pin tries 1
                PINentries = PINentries + 1;
               

                //Checking if pin is correct and tries <=3
                if (PINentries<=3 & PIN == correctPIN)
                {
                    //Lib.update("ATM","0002",PINentries, blocked, Int32.Parse(Lib.getBalance()));
                    Lib.Newupdate(useCaseVariables.useCase, 
                                  0, 
                                  Int32.Parse(Lib.getBalance(useCaseVariables.useCase, "ATM")),
                                  "Credit Agricole",
                                  false, 
                                  Lib.getNummer("ATM", useCaseVariables.useCase),
                                  Int32.Parse(Lib.getCheckingBalance("ATM",useCaseVariables.useCase)), 
                                  Lib.getCode("ATM",useCaseVariables.useCase), 
                                  Lib.getName("ATM", useCaseVariables.useCase), 
                                  Lib.getSavingsBalance("ATM",useCaseVariables.useCase), Int32.Parse(Lib.getTrials()));
                    
                    
                    //delayed mesgbx
                    AutoClosingMessageBox.Show("PIN entry successful!", "Success", 2000, Parent: Form.ActiveForm);
                    
                    //update s3log:
                    s3log.logOperation(null, "PIN entry success.");

                    //Starting next form and close/hide this one
                    //next screen after messagebox
                    Form ATM6 = new ATM6(); // Instantiate a Form object.
                    ATM6.Show(); //show the new Form
                    
                    //Resetting the PIN:
                    PIN = "";
                    this.Visible = false;  //Hide the old form

                    //stop the BatteryNetworkTimer
                    this.BatteryNetworkTimer.Stop();
                }
                else if (PINentries < 3 & PIN != correctPIN)
                {
                    //Lib.update("ATM", "0002", PINentries, blocked, Int32.Parse(Lib.getBalance()));
                    Lib.Newupdate(useCaseVariables.useCase,
                                  0,
                                  Int32.Parse(Lib.getBalance(useCaseVariables.useCase, "ATM")),
                                  "Credit Agricole",
                                  false,
                                  Lib.getNummer("ATM", useCaseVariables.useCase),
                                  Int32.Parse(Lib.getCheckingBalance("ATM", useCaseVariables.useCase)),
                                  Lib.getCode("ATM", useCaseVariables.useCase),
                                  Lib.getName("ATM", useCaseVariables.useCase),
                                  Lib.getSavingsBalance("ATM", useCaseVariables.useCase), Int32.Parse(Lib.getTrials()) + 1);

                    //if incorrect PIN:
                    AutoClosingMessageBox.Show("PIN entry not successful, retry! Left attempts: " + Convert.ToString(3 - PINentries), "Retry!", 2000, Parent: Form.ActiveForm);
                    s3log.logOperation(null, "PIN entry fail, left attempts: " + Convert.ToString(3 - PINentries));

                    //Resetting the PIN:
                    PIN = "";

                    //update s3log:

                }
                else if (PINentries > 3)
                {
                    //set PIN blocked variables:
                    //blocked = true;
                    useCaseVariables.bCheckBoxPINEntriesExhausted = true;

                    //Update the database:
                    Lib.Newupdate(useCaseVariables.useCase, 0, Int32.Parse(Lib.getBalance(useCaseVariables.useCase, "ATM")), "Credit Agricole", true, "34535553535", 0, "1111", "Jonas Rathke", "0", Int32.Parse(Lib.getTrials()) + 1);


                    //3 times Wrong PIN entry:
                    AutoClosingMessageBox.Show("Last PIN entry not successful, no attempts left, no money for you, your card is being captured.", "Success", 2000, Parent: Form.ActiveForm);
                    
                    //update s3log:
                    s3log.logOperation(null, "Third PIN entry failure. PIN blocked.");

                    //reset PIN and return
                    PIN = "";
                    this.Close(); 


                };
                 
            }
            else
            {
                //in case of alphanumeric keyboard:
                AutoClosingMessageBox.Show("Please provide a numercial PIN.", "Error", 2000, Parent: Form.ActiveForm);
                PIN = "";
            }

            //set back to empty box:
            this.PinEntry.Text = "";
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
            //Starting next form and close/hide this one
            Form ATM4 = new ATM4(); // Instantiate a Form object.
            ATM4.Show(); //show the new Form

            this.Visible = false;  //Hide the old form

            //Log current operation:
            s3log.logOperation(sender);

            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();
        }

        private void PinEntry_TextChanged(object sender, EventArgs e)
        {

        }


        //Return to initial form
        private void metroButton1_Click(object sender, EventArgs e)
        {
            //CancelMsgBox
            AutoClosingMessageBox.Show("Cancelled current operation. Ejecting card and restarting...", "Aborting", 1500,this);

            //Starting next form and close/hide this one
            //Going back to first form (restart)
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            this.Visible = false;

            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();

            //Log current operation:
            s3log.logOperation(sender);

            
            
        }


        //Button clicks to insert PIN over the form (didnt make a function for that yet, would be improvement though)
        private void Num1_Click(object sender, EventArgs e)
        {
            pin_update("1");
            //Log current operation:
            s3log.logOperation(sender);
        }

        private void Num2_Click(object sender, EventArgs e)
        {        
            pin_update("2");
            //Log current operation:
            s3log.logOperation(sender);
        }

        private void Num3_Click(object sender, EventArgs e)
        {         
            pin_update("3");
            //Log current operation:
            s3log.logOperation(sender);
        }

        private void Num4_Click(object sender, EventArgs e)
        {       
            pin_update("4");
            //Log current operation:
            s3log.logOperation(sender);
        }

        private void Num5_Click(object sender, EventArgs e)
        {      
            pin_update("5");
            //Log current operation:
            s3log.logOperation(sender);
        }

        private void Num6_Click(object sender, EventArgs e)
        {      
            pin_update("6");
            //Log current operation:
            s3log.logOperation(sender);
        }

        private void Num7_Click(object sender, EventArgs e)
        {      
            pin_update("7");
            //Log current operation:
            s3log.logOperation(sender);
        }

        private void Num8_Click(object sender, EventArgs e)
        {    
            pin_update("8");
            //Log current operation:
            s3log.logOperation(sender);
        }

        private void Num9_Click(object sender, EventArgs e)
        { 
            pin_update("9");
            //Log current operation:
            s3log.logOperation(sender);
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            pin_update("0");
            //Log current operation:
            s3log.logOperation(sender);
        }
        
        // refactored function AS
        public void pin_update(String digit)
        {
            PIN = PIN + digit;
            this.PinEntry.Text = PIN;

        }

        //check if log is already inserted
        private void log(Boolean flag = true)
        {
            if (flag == true)
            {
                string path = @"Y:\Documents\GitHub\2016_12_13_Helios_ATM_Implementation\Project_Supplementary\2016_12_28_AWS_Log.txt";
                string appendText = "Correct Pin" + " " + (DateTime.Now).ToString() + Environment.NewLine;
                string appendText2 = "Battery life: " + battery.charge + "% " + (DateTime.Now).ToString() + Environment.NewLine;

                File.AppendAllText(path, appendText);
                File.AppendAllText(path, appendText2);
            }
            else
            {

                string path = @"Y:\Documents\GitHub\2016_12_13_Helios_ATM_Implementation\Project_Supplementary\2016_12_28_AWS_Log.txt";
                string appendText = "Incorrect Pin:" + " " + (DateTime.Now).ToString() + Environment.NewLine;
                string appendText2 = "Battery life: " + battery.charge + "% " + (DateTime.Now).ToString() + Environment.NewLine;

                File.AppendAllText(path, appendText);
                File.AppendAllText(path, appendText2);

            }


        }


        //Delete all of the PIN entry textbox
        private void NumDeleteAll_Click(object sender, EventArgs e)
        {
            PIN = "";
            this.PinEntry.Text = PIN;

            //Log current operation:
            s3log.logOperation(sender);
        }
        //Delete last number of the PIN entry textbox
        private void NumBack_Click(object sender, EventArgs e)
        {
            PIN = PIN.Substring(0, PIN.Length-1);
            this.PinEntry.Text = PIN;

            //Log current operation:
            s3log.logOperation(sender);
        }

        private void BatteryNetworkTimer_Tick(object sender, EventArgs e)
        {
            //getting the current Batterycharge & discharge and adjust network signal:
            battery.discharge(this.BatteryCharge);
            networkConnection.networkConnectionOK(this.NetworkSignal);
        }
    }
}
