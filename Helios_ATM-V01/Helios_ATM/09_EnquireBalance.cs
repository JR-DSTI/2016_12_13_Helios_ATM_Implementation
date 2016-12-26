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

        }

        private async void CardInserted_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);

            Form ATM4 = new ATM4(); // Instantiate a Form object.
            ATM4.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
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
            //Set default value for other account
            SavingsLabel.Text = "XX,XXX.XX";
            //Insert here the code to get current checkings amount
            CheckingsLabel.Text= string.Format("{0:##,###.00}", Convert.ToDecimal("100000"));

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //Set default value for other account
            CheckingsLabel.Text = "XX,XXX.XX";
            //Insert here the code to get current savings amount
            SavingsLabel.Text = string.Format("{0:##,###.00}", Convert.ToDecimal("100000"));
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //CancelMsgBox
            AutoClosingMessageBox.Show("Cancelled current operation. Ejecting card and restarting...", "Aborting", 1500, this);

            //Going back to first form (restart)
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            this.Visible = false;
        }
    }
}
