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
using System.Net.NetworkInformation;
using System.Windows;
using System.IO;

namespace Helios_ATM
{
   
    public partial class ATM1 : MetroFramework.Forms.MetroForm
    {
        public ATM1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.WelcomeProgressBar.Increment(10);  
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //timer to extend waiting and system setup :
            this.WelcomeTimer.Start();
            this.timer1.Start();
            this.WelcomeProgressBar.Visible = true;
            this.InitializeLabel.Visible = true;

            //Log current operation:
            s3log.logOperation(sender);

            //"await" needs the async in the function declaration and equals "Sleep"
            await Task.Delay(2000);

            //Starting next form and close/hide this one
            //start the next form
            Form ATM3 = new ATM3(); // Instantiate a Form object.
            ATM3.Show(); //show the new Form
            WelcomeTimer.Stop();
            this.BatteryNetworkTimer.Stop();

            //hide the old form
            this.Visible = false;  //Hide the old form

        }
        private void ATM1_Load(object sender, EventArgs e)
        {
            //hide the InitializeLabel
            this.InitializeLabel.Visible = false;

            //setting the current Batterycharge and Network signal:
            this.BatteryCharge.Value = battery.charge;
            this.BatteryNetworkTimer.Start();
        }
        
        //Quick jump to current Form:
        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Starting next form and close/hide this one
            MetroFramework.Forms.MetroForm ATM6 = new ATM6(); // Instantiate a Form object.
            ATM6.Show(); //show the new Form
            this.BatteryNetworkTimer.Stop();

            this.Visible = false;  //Hide the old form
        }


        private void BatteryNetworkTimer_Tick(object sender, EventArgs e)
        {
            //getting the current Batterycharge & discharge and adjust network signal:
            battery.discharge(this.BatteryCharge);
            networkConnection.networkConnectionOK(this.NetworkSignal);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {


        }
    }

}
