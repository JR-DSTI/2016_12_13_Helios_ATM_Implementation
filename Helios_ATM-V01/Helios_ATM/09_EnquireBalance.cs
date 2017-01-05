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
    public partial class ATM9 : MetroFramework.Forms.MetroForm
    {
        public ATM9()
        {
            InitializeComponent();
        }

        private void ATM9_Load(object sender, EventArgs e)
        {
            Lib.stfu();
            //update batterycharge and start BatteryNetworkTimer
            this.BatteryCharge.Value = battery.charge;
            this.BatteryNetworkTimer.Start();
        }


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

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);

            //Set default value for other account
            SavingsLabel.Text ="XX,XXX.XX";

            //Insert here the code to get current checkings amount
            CheckingsLabel.Text= string.Format("{0:##,###.00}", Convert.ToDecimal(Lib.getCheckingBalance()));

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);

            //Set default value for other account
            CheckingsLabel.Text =  "XX,XXX.XX";

            //Insert here the code to get current savings amount
            SavingsLabel.Text = string.Format("{0:##,###.00}", Convert.ToDecimal(Lib.getSavingsBalance()));
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);

            
            

            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();

            //CancelMsgBox
            AutoClosingMessageBox.Show("Cancelled current operation. Ejecting card and restarting...", "Aborting", 1500, this);
            
            //Starting next form and close/hide this one
            //Going back to first form (restart)
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            this.Visible = false;
        }

        private void BatteryNetworkTimer_Tick(object sender, EventArgs e)
        {
            //discharge battery and check network connection:
            battery.discharge(this.BatteryCharge);
            networkConnection.networkConnectionOK(this.NetworkSignal);
        }
    }
}
