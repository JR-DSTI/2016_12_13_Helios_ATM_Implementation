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
    public partial class ATM4 : MetroFramework.Forms.MetroForm
    {

        public ATM4()
        {
            InitializeComponent();
        }

        private void ATM4_Load(object sender, EventArgs e)
        {
            //setting the current Batterycharge and Network signal:
            this.BatteryCharge.Value = battery.charge;
            this.BatteryNetworkTimer.Start();
        }

        private async void CardInserted_Click(object sender, EventArgs e)
        {   //name of Button is not fitting but renaming leads to trouble :-(
            //English selection continues
            await Task.Delay(500);
           
            //Log current operation:
            s3log.logOperation(sender);

            //Starting next form and close/hide this one
            Form ATM5 = new ATM5(); // Instantiate a Form object.
            ATM5.Show(); //show the new Form
            this.Visible = false;  //Hide the old form
            
            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();

        }





        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Cancel MsgBox & close the message after certain time:
            AutoClosingMessageBox.Show("Cancelled current operation. Ejecting card and restarting...", "Aborting", 1500,this);

            //Starting next form and close/hide this one
            //Going back to first form (=restart)
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            //Log current operation: (to be repeated)
            s3log.logOperation(sender);
            string s = s3log.strLog;
            var sb = new StringBuilder();
            sb.Append(s);
            File.WriteAllText("afile.txt", sb.ToString());
            s3log.uploadtoS3("afile.txt");
            this.Visible = false;
            
            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //Starting next form and close/hide this one
            //continue to next form
            Form ATM3 = new ATM3(); // Instantiate a Form object.
            ATM3.Show(); //show the new Form

            //Log current operation:
            s3log.logOperation(sender);

            this.Visible = false;

            //stop the BatteryNetworkTimer
            this.BatteryNetworkTimer.Stop();
        }

        private void SpanishButton_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
        }

        private void BatteryNetworkTimer_Tick(object sender, EventArgs e)
        {
            //getting the current Batterycharge & discharge and adjust network signal:
            battery.discharge(this.BatteryCharge);
            networkConnection.networkConnectionOK(this.NetworkSignal);
        }

        private void FrenchButton_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
        }

        private void PortuguesButton_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
        }

        private void MandarinButton_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
        }
    }
}
