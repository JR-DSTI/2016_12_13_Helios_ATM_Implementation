﻿using System;
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
            this.timer2.Start();
            this.WelcomeProgressBar.Visible = true;

            //Log current operation:
            s3log.logOperation(sender);

            //"await" needs the async in the function declaration and equals "Sleep"
            await Task.Delay(2000);

            //MetroFramework.MetroMessageBox.Show(this, (Pinger("stackoverflow.com", 4)).ToString());
            if (Pinger("stackoverflow.com", 5) > 129)
            {
                MetroFramework.MetroMessageBox.Show(this, "the connection is lost"); // this = current form        
                this.WelcomeProgressBar.Value = 0;
                WelcomeTimer.Stop();
                this.timer2.Stop();
            }
            else
            {
                //start the next form
                Form ATM3 = new ATM3(); // Instantiate a Form object.
                ATM3.Show(); //show the new Form
                WelcomeTimer.Stop();

                //hide the old form
                this.Visible = false;  //Hide the old form
            }

        }
        private void ATM1_Load(object sender, EventArgs e)
        {
            this.BatteryCharge.Value = Lib2.charge;
            //Lib2.form1visit += 1;
            //using (StreamWriter sr = new StreamWriter(@"Y:\Documents\GitHub\2016_12_13_Helios_ATM_Implementation\Project_Supplementary\2016_12_28_AWS_Log.txt"))
            //{     
            //    sr.WriteLine("Battery life: "+Lib2.charge +"% "+ (DateTime.Now).ToString());
            //    sr.WriteLine("visit to Main Menu: "+ (Lib2.form1visit).ToString()+ (DateTime.Now).ToString());
            //}
        }
        //Quick jump to current Form:
        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (Pinger("stackoverflow.com", 5) > 29)
            {
   
                MetroFramework.MetroMessageBox.Show(this, "the connection is lost");
            }
            else
            {

            MetroFramework.Forms.MetroForm ATM6 = new ATM6(); // Instantiate a Form object.
            ATM6.Show(); //show the new Form
            this.timer2.Stop();

            this.Visible = false;  //Hide the old form
        }
    }

        private void WelcomeProgressBar_Click(object sender, EventArgs e)
        {

        }


        public double Pinger(string host, int echoNum)
        {
  
        long totalTime = 0;
        int timeOut = 120;
        for (int i=0; i<echoNum; i++)
            {
                Ping pingSender=new Ping();
                PingReply r = pingSender.Send(host,timeOut);
                if (r.Status==IPStatus.Success)
                {
                    totalTime += r.RoundtripTime;
                }
            }
            return (totalTime / echoNum);
        }

        private void BatteryCharge_Click(object sender, EventArgs e)
        {
            
        }

        public void discharge()
        {
            if (BatteryCharge.Value > 0)
                {
                BatteryCharge.Value -= Lib2.decrement;
                Lib2.charge= BatteryCharge.Value;
            }
            else
            {
                AutoClosingMessageBox.Show("The ATM is running out of power. Disconnecting... and recharging.", "Low energy", 1500, this);
                Lib2.charge = 100;
                //Environment.Exit(0);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.discharge();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {


        }
    }

}
