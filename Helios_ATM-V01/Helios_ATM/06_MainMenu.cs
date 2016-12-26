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
    public partial class ATM6 : MetroFramework.Forms.MetroForm
    {
        
        private String sUserChoice="";
      
        public ATM6()
        {
            InitializeComponent();
        }

        private void ATM6_Load(object sender, EventArgs e1)
        {
  
        }

        //set the choice of the user and store it for the next confirmation step:
        private void Num1_Click(object sender, EventArgs e)
        {
            sUserChoice = "1";
            ConfirmMenuSelection.Visible = true;
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            sUserChoice = "2";
            ConfirmMenuSelection.Visible = true;

        }

        private void Num3_Click(object sender, EventArgs e)
        {
            sUserChoice = "3";
            ConfirmMenuSelection.Visible = true;

        }

        //Confirm button that takes user choice and directs to the appropriate Form
        private void ConfirmPINentry_Click_1(object sender, EventArgs e)
        {

            switch(sUserChoice)
            {
                case "1":
                    //Withdraw moneeeeeeey
                    Form ATM7 = new ATM7(); // Instantiate a Form object.
                    ATM7.Show(); //show the new Form
                    this.Visible = false;  //Hide the old form
                    break;
                    

                case "2":
                    //Change PIN form
                    Form ATM8 = new ATM8(); // Instantiate a Form object.
                    ATM8.Show(); //show the new Form
                    this.Visible = false;  //Hide the old form
                    break;

                case "3":
                    //Balance Enquiry form
                    Form ATM9 = new ATM9(); // Instantiate a Form object.
                    ATM9.Show(); //show the new Form
                    this.Visible = false;  //Hide the old form
                    break;

                default:
                    MetroMessageBox.Show(this, "Please provide a selection!");
                    break;
            }

        }

        //possibly unnecessary code:
        private void PinEntry_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                ConfirmPINentry_Click_1(new object(), new EventArgs());
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form ATM4 = new ATM4(); // Instantiate a Form object.
            ATM4.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
        }

        private void PinEntry_TextChanged(object sender, EventArgs e)
        {

        }


        //Return to initial form
        private void metroButton1_Click(object sender, EventArgs e)
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
