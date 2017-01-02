using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Helios_ATM
{

    public partial class ATM0 : MetroFramework.Forms.MetroForm
    {
        public ATM0()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //AutoClosingMessageBox.Show(EnvironmentComboBox.Text, "Info", 1500, this);

            //AutoClosingMessageBox.Show(ProblemsComboBox.SelectedItem.ToString(), "Info", 1500, this);

            useCaseVariables.strNotificationAddress = EmailTextBox.Text;
            useCaseVariables.bCheckBoxPowerSourceBattery = CheckBoxPowerSourceBattery.Checked;
            useCaseVariables.bCheckBoxPINEntriesExhausted = CheckBoxPINEntriesExhausted.Checked;
            useCaseVariables.bCheckBoxNetworkConnectionUnstable = CheckBoxNetworkConnectionUnstable.Checked;

            //start the First form
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form
            
            //hide the old form
            this.Visible = false;  //Hide the old form


        }
        private void ATM0_Load(object sender, EventArgs e)
        {
            this.BatteryCharge.Value = battery.charge;

        }
        //Quick jump to current Form:
        private void metroButton1_Click(object sender, EventArgs e)
        {

        }


        private void WelcomeProgressBar_Click(object sender, EventArgs e)
        {

        }


        public double Pinger(string host, int echoNum)
        {

            long totalTime = 0;
            int timeOut = 120;
            for (int i = 0; i < echoNum; i++)
            {
                Ping pingSender = new Ping();
                PingReply r = pingSender.Send(host, timeOut);
                if (r.Status == IPStatus.Success)
                {
                    totalTime += r.RoundtripTime;
                }
            }
            return (totalTime / echoNum);
        }

        private void BatteryCharge_Click(object sender, EventArgs e)
        {

        }

        

        private void timer2_Tick(object sender, EventArgs e)
        {
            //if batterymode==True then:
            //this.discharge();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {


        }

        private void InfoText_Click(object sender, EventArgs e)
        {

        }
    }

}
