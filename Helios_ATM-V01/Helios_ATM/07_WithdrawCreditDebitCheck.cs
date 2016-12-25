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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.WelcomeProgressBar.Increment(1);  // this = is the current form
        }

        private async void delay_progressbar(){
            this.WelcomeTimer.Start();
            this.WelcomeProgressBar.Visible = true;
            await Task.Delay(2000);
            //Lib.getBankName();
            Lib.RetrieveAccount();
            //Lib.getBalance();
        }


        private  void button1_Click(object sender, EventArgs e)
        {
            
            //Going to withdraw form ()
            Form ATM7a = new ATM7a(); // Instantiate a Form object.
            ATM7a.Show(); //show the new Form

            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Going to withdraw form ()
            Form ATM7a = new ATM7a(); // Instantiate a Form object.
            ATM7a.Show(); //show the new Form

            this.Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //CancelMsgBox
            AutoClosingMessageBox.Show("Cancelled current operation. Ejecting card and restarting...", "Aborting", 1500);

            //Going back to first form (restart)
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            this.Visible = false;
        }
    }
}
