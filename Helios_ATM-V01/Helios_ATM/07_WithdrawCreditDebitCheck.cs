using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helios_ATM
{
    public partial class ATM7 : MetroFramework.Forms.MetroForm
    {
        public ATM7()
        {
            InitializeComponent();
            delay_progressbar();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.metroProgressBarENTER.Increment(1);
        }

        private async void delay_progressbar(){
            //Show infos to user:
            this.metroProgressBarENTER.Visible = true;
            this.ProgressLabel.Text = "Initializing data retrieval...";
            await Task.Delay(1000);
           
            //retrieve account details:
            Lib.RetrieveAccount(useCaseVariables.useCase,"ATM");

            //Show infos to user:
            this.ProgressLabel.Text = "Data retrieval success!";
            await Task.Delay(200);
        }


        private  void button1_Click(object sender, EventArgs e)
        {
            //Starting next form and close/hide this one
            //Going to withdraw form ()
            Form ATM7a = new ATM7a(); // Instantiate a Form object.
            ATM7a.Show(); //show the new Form

            this.Visible = false;

            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Starting next form and close/hide this one
            //Going to withdraw form ()
            Form ATM7a = new ATM7a(); // Instantiate a Form object.
            ATM7a.Show(); //show the new Form

            this.Visible = false;

            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.ProgressLabel.Text = "Logging operation...";

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
            //discharge battery and check network connection:
            battery.discharge(this.BatteryCharge);
            networkConnection.networkConnectionOK(this.NetworkSignal);
        }

        private void ATM7_Load(object sender, EventArgs e)
        {
            //initialize the label to Init state
            this.ProgressLabel.Text = "Initializing card check...";

            //starting the timer
            this.timer1.Start();

            //update batterycharge and start BatteryNetworkTimer
            this.BatteryCharge.Value = battery.charge;
            this.BatteryNetworkTimer.Start();
        }
    }
}
