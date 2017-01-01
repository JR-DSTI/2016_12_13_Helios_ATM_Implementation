using MetroFramework;
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
    public partial class ATM8 : MetroFramework.Forms.MetroForm
    {
        //initialization of PIN entries 
        private String oldPIN;
        private String newPIN;
        private String newPIN2;
        //here you could insert your Data base link to PIN, PINentries
        private int PINentries = 0;
        //here can the database get the correct PIN
        private String correctPIN="1111";

        public ATM8()
        {
            InitializeComponent();
            //delay_progressbar();
            //Tell user what to do
            AutoClosingMessageBox.Show("Please provide your PIN and confirm.","PIN change",1500, this);

            OLDPinEntry.Enabled = true;
            NewPinEntry.Enabled = false;
            ConfirmNewPinEntry.Enabled = false;
        }


        private  void button1_Click(object sender, EventArgs e)
        {
            

            //Form ATM3 = new ATM3(); // Instantiate a Form object.
            //ATM3.Show(); //show the new Form

            //this.Visible = false;  //Hide the old form


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);
            
            //CancelMsgBox
            AutoClosingMessageBox.Show("Cancelled current operation. Ejecting card and restarting...", "Aborting", 1500, this);

            //Going back to first form (restart)
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            this.Visible = false;
        }

        //Clicking events, calling the function to insert Numeric values
        private void Num1_Click(object sender, EventArgs e)
        {

            InsertNumInTextbox("1");

        }

        private void Num2_Click(object sender, EventArgs e)
        {
            InsertNumInTextbox("2");
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            InsertNumInTextbox("3");
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            InsertNumInTextbox("4");
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            InsertNumInTextbox("5");
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            InsertNumInTextbox("6");
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            InsertNumInTextbox("7");
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            InsertNumInTextbox("8");
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            InsertNumInTextbox("9");
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            InsertNumInTextbox("0");
        }

        //delete all of the textbox value
        private void NumDeleteAll_Click(object sender, EventArgs e)
        {

            InsertNumInTextbox("");
        }

        //delete last number, depending which textbox enabled
        private void NumBack_Click(object sender, EventArgs e)
        {
            if (OLDPinEntry.Enabled == true)
            {
                oldPIN = oldPIN.Substring(0, oldPIN.Length - 1);
                this.OLDPinEntry.Text = oldPIN;

            }
            if (NewPinEntry.Enabled == true)
            {
                newPIN = newPIN.Substring(0, newPIN.Length - 1);
                this.NewPinEntry.Text = newPIN;

            }
            if (ConfirmNewPinEntry.Enabled == true)
            {
                newPIN2 = newPIN2.Substring(0, newPIN2.Length - 1);
                this.ConfirmNewPinEntry.Text = newPIN2;

            }
        }

        private void ATM8_Load(object sender, EventArgs e)
        {

        }


        private void ConfirmPINentry_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);

            if (ConfirmNewPinEntry.Enabled == true)
            {
                if (newPIN == newPIN2)
                {
                    AutoClosingMessageBox.Show("PIN successful changed.","Success", 1000, this);
                    correctPIN = newPIN2;
                    //Going back to first form (restart)
                    Form ATM6 = new ATM6(); // Instantiate a Form object.
                    ATM6.Show(); //show the new Form
                    this.Visible = false;
                }
                else
                {
                    AutoClosingMessageBox.Show("Incorrect re-entry PIN. Please try again.","Incorrect PIN.",1000, this);
                    ConfirmNewPinEntry.Enabled = false;
                    NewPinEntry.Enabled = true;
                    ConfirmNewPinEntry.Text = "";
                    NewPinEntry.Text = "";
                }
            }

            if (NewPinEntry.Enabled == true)
            {
                if (newPIN.Length >= 4 && newPIN.Length < 9)
                {
                    AutoClosingMessageBox.Show("Entry success. Please re-enter the new PIN.","Reentry", 1000, this);
                    ConfirmNewPinEntry.Enabled = true;
                    NewPinEntry.Enabled = false;
                }
                else
                {
                    AutoClosingMessageBox.Show("Incorrect PIN. Please try again.","Incorrect PIN", 1000, this);
                    NewPinEntry.Text = "";
                }
            }

            if (OLDPinEntry.Enabled == true)
            {
                //increasing the pin tries 1
                PINentries = PINentries + 1;

                if (PINentries <= 3 & correctPIN == oldPIN)
                {
                    AutoClosingMessageBox.Show( "Correct PIN. Please enter the new PIN.","Nice one", 1000, this);
                    NewPinEntry.Enabled = true;
                    OLDPinEntry.Enabled = false;
                }
                else if (PINentries < 3 & oldPIN != correctPIN)
                {
                    //if incorrect PIN:
                    MetroMessageBox.Show(this, "PIN entry not successful, retry! Left attempts: " + Convert.ToString(3 - PINentries));
                    //Resetting the PIN:
                    oldPIN = "";
                }
                else if (PINentries > 3)
                {
                    //3 times Wrong  PIN:
                    MetroMessageBox.Show(this, "Last PIN entry not successful, no attempts left, no money for you, your card is being captured.");
                    oldPIN = "";
                    this.Close(); //return;
                };
            }

           
            

        }

        //Insert number in textbox, depending which textbox enabled
        private void InsertNumInTextbox(String Num)
        {
            if (Num == "")
            {
                if (OLDPinEntry.Enabled == true)
                {
                    oldPIN = "";
                    this.OLDPinEntry.Text = oldPIN;

                }
                if (NewPinEntry.Enabled == true)
                {
                    newPIN = "";
                    this.NewPinEntry.Text = newPIN;

                }
                if (ConfirmNewPinEntry.Enabled == true)
                {
                    newPIN2 = "";
                    this.ConfirmNewPinEntry.Text = newPIN2;

                }
            }
            else
            {


                if (OLDPinEntry.Enabled == true)
                {
                    oldPIN = oldPIN + Num;
                    this.OLDPinEntry.Text = oldPIN;

                }
                if (NewPinEntry.Enabled == true)
                {
                    newPIN = newPIN + Num;
                    this.NewPinEntry.Text = newPIN;

                }
                if (ConfirmNewPinEntry.Enabled == true)
                {
                    newPIN2 = newPIN2 + Num;
                    this.ConfirmNewPinEntry.Text = newPIN2;

                }
            }
        }

        //return to main form
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Log current operation:
            s3log.logOperation(sender);

            Form ATM6 = new ATM6(); // Instantiate a Form object.
            ATM6.Show(); //show the new Form
            this.Visible = false;  //Hide the old form
        }
    }
}
