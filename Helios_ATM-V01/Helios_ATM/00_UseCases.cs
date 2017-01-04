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
   
    public partial class ATM0 : MetroFramework.Forms.MetroForm
    {
        public ATM0()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.WelcomeProgressBar.Increment(10);  
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            

            //Log current operation:
            s3log.logOperation(sender);

            useCaseVariables.strNotificationAddress = EmailTextBox.Text;
            useCaseVariables.bCheckBoxPowerSourceBattery = CheckBoxPowerSourceBattery.Checked;
            useCaseVariables.bCheckBoxPINEntriesExhausted = CheckBoxPINEntriesExhausted.Checked;
            useCaseVariables.bCheckBoxNetworkConnectionUnstable = CheckBoxNetworkConnectionUnstable.Checked;
            useCaseVariables.bCheckBoxZeroCash = CheckBoxZeroCash.Checked;

            //Starting next form and close/hide this one
            //start the First form
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            //hide the old form
            this.Visible = false;  //Hide the old form

        }
        private void ATM0_Load(object sender, EventArgs e)
        {
           // Lib.afunction();
            
            //setting the current Batterycharge
            this.BatteryCharge.Value = battery.charge;
            this.comboBox1.Items.Add("zero Cash On Account");        
            this.comboBox1.Items.Add("No more Pin entries left");
            
            this.comboBox1.Items.Add("Unstable Network Connection");
            this.comboBox1.Items.Add("Classic Usage: Jonas R.");
            this.comboBox1.Items.Add("Power Source:Battery");

        }

        ////Quick jump to current Form:
        //private void metroButton1_Click(object sender, EventArgs e)
        //{

        //    if (Pinger("stackoverflow.com", 5) > 29)
        //    {

        //        MetroFramework.MetroMessageBox.Show(this, "the connection is lost");
        //    }
        //    else
        //    {
        //        //Starting next form and close/hide this one
        //        MetroFramework.Forms.MetroForm ATM6 = new ATM6(); // Instantiate a Form object.
        //    ATM6.Show(); //show the new Form
        //    this.timer2.Stop();

        //    this.Visible = false;  //Hide the old form
        //}


        //private void WelcomeProgressBar_Click(object sender, EventArgs e)
        //{

        //}


        //public double Pinger(string host, int echoNum)
        //{

        //long totalTime = 0;
        //int timeOut = 120;
        //for (int i=0; i<echoNum; i++)
        //    {
        //        Ping pingSender=new Ping();
        //        PingReply r = pingSender.Send(host,timeOut);
        //        if (r.Status==IPStatus.Success)
        //        {
        //            totalTime += r.RoundtripTime;
        //        }
        //    }
        //    return (totalTime / echoNum);
        //}

        //private void BatteryCharge_Click(object sender, EventArgs e)
        //{

        //}

        //public void discharge()
        //{
        //    if (BatteryCharge.Value > 0)
        //        {
        //        BatteryCharge.Value -= battery.decrement;
        //        battery.charge= BatteryCharge.Value;
        //    }
        //    else
        //    {
        //        AutoClosingMessageBox.Show("The ATM is running out of power. Disconnecting... and recharging.", "Low energy", 1500, this);
        //        battery.charge = 100;
        //        //Environment.Exit(0);
        //    }
        //}

        private void timer2_Tick(object sender, EventArgs e)
        {
            //getting the current Batterycharge & discharge 
            battery.discharge(this.BatteryCharge);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show((comboBox1.SelectedIndex).ToString());

            switch (comboBox1.SelectedIndex)
                 {
                case 0:
                    useCaseVariables.useCase = "0004";
                    break;

                case 1:
                    useCaseVariables.useCase = "0003";
                    break;
                case 2:
                    useCaseVariables.useCase = "0002";
                    break;

                case 3:
                    useCaseVariables.useCase = "0002";
                    break;
                case 4:
                    useCaseVariables.useCase = "0002";
                    break;
                default:
                    useCaseVariables.useCase = "0002";
                    break;
            }
        }

        private void phoneFormatLabel_Click(object sender, EventArgs e)
        {

        }

        //private void metroButton2_Click(object sender, EventArgs e)
        //{


        //}
    }

}
