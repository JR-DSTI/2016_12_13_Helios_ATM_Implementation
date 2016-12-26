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
    public partial class ATM4 : MetroFramework.Forms.MetroForm
    {

        public ATM4()
        {
            InitializeComponent();
        }

        private void ATM4_Load(object sender, EventArgs e)
        {

        }

        private async void CardInserted_Click(object sender, EventArgs e)
        {   //name of Button is not fitting but renaming leads to trouble :-(
            //English selection continues
            await Task.Delay(500);

            Form ATM5 = new ATM5(); // Instantiate a Form object.
            ATM5.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Cancel MsgBox & close the message after certain time:
            AutoClosingMessageBox.Show("Cancelled current operation. Ejecting card and restarting...", "Aborting", 1500,this);

            //Going back to first form (=restart)
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            this.Visible = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //continue to next form
            Form ATM3 = new ATM3(); // Instantiate a Form object.
            ATM3.Show(); //show the new Form

            this.Visible = false;
        }

       
    }
}
