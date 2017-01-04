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
    public partial class ATM6 : MetroFramework.Forms.MetroForm
    {
        
        private String sUserChoice="";
      
        public ATM6()
        {
            InitializeComponent();
        }

        private void ATM6_Load(object sender, EventArgs e1)
        {
            //update batterycharge and start BatteryNetworkTimer
            this.BatteryCharge.Value = battery.charge;
            this.BatteryNetworkTimer.Start();

        }

        //set the choice of the user and store it for the next confirmation step:
        private void Num1_Click(object sender, EventArgs e)
        {
            sUserChoice = "1";
            ConfirmMenuSelectionButton.Visible = true;

            //Log current operation:
            s3log.logOperation(sender);
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            sUserChoice = "2";
            ConfirmMenuSelectionButton.Visible = true;

            //Log current operation:
            s3log.logOperation(sender);
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            sUserChoice = "3";
            ConfirmMenuSelectionButton.Visible = true;

            //Log current operation:
            s3log.logOperation(sender);

        }

        //Confirm button that takes user choice and directs to the appropriate Form
        private void ConfirmPINentry_Click_1(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);


            switch (sUserChoice)
            {
                case "1":
                    //Withdraw moneeeeeeey
                    //Starting next form and close/hide this one
                    Form ATM7 = new ATM7(); // Instantiate a Form object.
                    ATM7.Show(); //show the new Form
                    this.Visible = false;  //Hide the old form
                   
                    //stop the BatteryNetworkTimer
                    this.BatteryNetworkTimer.Stop();

                    //update s3log:

                    break;
                    

                case "2":
                    //Starting next form and close/hide this one
                    //Go to PIN form
                    Form ATM8 = new ATM8(); // Instantiate a Form object.
                    ATM8.Show(); //show the new Form
                    this.Visible = false;  //Hide the old form
                    
                    //stop the BatteryNetworkTimer
                    this.BatteryNetworkTimer.Stop();

                    //update s3log:

                    break;

                case "3":
                    //Starting next form and close/hide this one
                    //Balance Enquiry form
                    Form ATM9 = new ATM9(); // Instantiate a Form object.
                    ATM9.Show(); //show the new Form
                    this.Visible = false;  //Hide the old form

                    //stop the BatteryNetworkTimer
                    this.BatteryNetworkTimer.Stop();

                    //update s3log:

                    break;

                default:
                    MetroMessageBox.Show(this, "Please provide a selection!");
                    
                    //stop the BatteryNetworkTimer
                    this.BatteryNetworkTimer.Stop();

                    //update s3log:

                    break;
            }

        }

        //possibly unnecessary code:
        private void PinEntry_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                ConfirmPINentry_Click_1(new object(), new EventArgs());
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);

            //Starting next form and close/hide this one
            Form ATM4 = new ATM4(); // Instantiate a Form object.
            ATM4.Show(); //show the new Form

            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();

            this.Visible = false;  //Hide the old form
        }

        private void PinEntry_TextChanged(object sender, EventArgs e)
        {

        }


        //Return to initial form
        private void metroButton1_Click(object sender, EventArgs e)
        {
            //CancelMsgBox
            AutoClosingMessageBox.Show("Cancelled current operation. Ejecting card and restarting...", "Aborting", 1500, this);

            //Starting next form and close/hide this one
            //Going back to first form (restart)
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            //Log current operation:
            s3log.logOperation(sender);

            
            

            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();

            this.Visible = false;
        }

        private void BatteryNetworkTimer_Tick(object sender, EventArgs e)
        {
            //getting the current Batterycharge & discharge and adjust network signal:
            battery.discharge(this.BatteryCharge);
            networkConnection.networkConnectionOK(this.NetworkSignal);

        }
    }
}
