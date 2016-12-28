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
    public partial class ATM5 : MetroFramework.Forms.MetroForm
    {   
        //necessary to grey out text of PIN Textfield
        private bool waterMarkActive;
        private String PIN;
        
        //here you could insert your Data base link to PIN, PINentries
        private int PINentries=0;
        private String correctPIN = "1111";

        public ATM5()
        {
            InitializeComponent();   
        }

        private void ATM5_Load(object sender, EventArgs e1)
        {
            //Initiating the field and set its values
            this.waterMarkActive = true;
            this.PinEntry.ForeColor = Color.Gray;
            this.PinEntry.Text = "****";

            //giving focus to the Pin text field
            this.PinEntry.GotFocus += (source,e) =>
            {
                if (this.waterMarkActive)
                {
                    //change text and color of textfield
                    this.waterMarkActive = false;
                    this.PinEntry.Text = "";
                    this.PinEntry.ForeColor = Color.Black;
                }
            };

            this.PinEntry.LostFocus += (source, e) =>
            {
                    //if the textfield is empty and the watermark is false, set it's value to ****
                if (!this.waterMarkActive && string.IsNullOrEmpty(this.PinEntry.Text))
                {
                    this.waterMarkActive = true;
                    this.PinEntry.Text = "****";
                    this.PinEntry.ForeColor = Color.Gray;
                }
            };
        }

        private async void CardInserted_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            Form ATM7 = new ATM7(); // Instantiate a Form object.
            ATM7.Show(); //show the new Form
            this.Visible = false;  //Hide the old form
        }

        private void ConfirmPINentry_Click_1(object sender, EventArgs e)
        {
            Boolean blocked = false;
            //checking whether PIN is correct:
            PIN = this.PinEntry.Text;

            if (Lib.getBlocked())
            {
                MetroMessageBox.Show(this, "no attempts left, no money for you, your card is being captured.");
                PINentries = 3;
                blocked=true;             
                this.Close();
            }

            

            //if not CHAR then continue
            else if (!PIN.Any(char.IsLetter)) //Continue if PIN contains only numeric
            {
                blocked = false;
                //increasing the pin tries 1
                PINentries = PINentries + 1;
               

                //Checking if pin is correct and tries <=3
                if (PINentries<=3 & PIN == correctPIN)
                {
                    Lib.update(PINentries.ToString(), blocked, Int32.Parse(Lib.getBalance()));
                    //here i wat to insert the delayed mesgbx
                    MetroMessageBox.Show(this, "PIN entry successful!");

                    //next screen after messagebox
                    Form ATM6 = new ATM6(); // Instantiate a Form object.
                    ATM6.Show(); //show the new Form
                    //Resetting the PIN:
                    PIN = "";
                    this.Visible = false;  //Hide the old form
                }
                else if (PINentries < 3 & PIN != correctPIN)
                {
                    Lib.update(PINentries.ToString(), blocked, Int32.Parse(Lib.getBalance()));
                    //if incorrect PIN:
                    MetroMessageBox.Show(this, "PIN entry not successful, retry! Left attempts: " + Convert.ToString(3-PINentries));
                    //Resetting the PIN:
                    PIN = "";
                }
                else if (PINentries > 3)
                {
                    blocked = true;
                    Lib.update(PINentries.ToString(), blocked, Int32.Parse(Lib.getBalance()));
                    //3 times Wrong  PIN:
                    MetroMessageBox.Show(this, "Last PIN entry not successful, no attempts left, no money for you, your card is being captured.");
                    PIN = "";
                    this.Close(); //return;
                };
                 
            }
            else
            {

                MetroMessageBox.Show(this, "Please provide a numercial PIN.");
                PIN = "";
            }

            //set back to empty box:
            this.PinEntry.Text = "";
        }

        //in case of keyboard access:
        private void PinEntry_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                ConfirmPINentry_Click_1(new object(), new EventArgs());
            }
        }

        //Return to previous form
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
            AutoClosingMessageBox.Show("Cancelled current operation. Ejecting card and restarting...", "Aborting", 1500,this);

            //Going back to first form (restart)
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            this.Visible = false;
        }


        //Button clicks to insert PIN over the form (didnt make a function for that yet, would be improvement though)
        private void Num1_Click(object sender, EventArgs e)
        {
            pin_update("1");
        }

        private void Num2_Click(object sender, EventArgs e)
        {        
            pin_update("2");
        }

        private void Num3_Click(object sender, EventArgs e)
        {         
            pin_update("3");
        }

        private void Num4_Click(object sender, EventArgs e)
        {       
            pin_update("4");
        }

        private void Num5_Click(object sender, EventArgs e)
        {      
            pin_update("5");
        }

        private void Num6_Click(object sender, EventArgs e)
        {      
            pin_update("6");
        }

        private void Num7_Click(object sender, EventArgs e)
        {      
            pin_update("7");
        }

        private void Num8_Click(object sender, EventArgs e)
        {    
            pin_update("8");
        }

        private void Num9_Click(object sender, EventArgs e)
        { 
            pin_update("9");
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            pin_update("0");  
        }
        // refactored function AS
        public void pin_update(String digit)
        {
            PIN = PIN + digit;
            this.PinEntry.Text = PIN;
        }
        private void log(Boolean flag = true)
        {
            if (flag == true)
            {
                string path = @"Y:\Documents\GitHub\2016_12_13_Helios_ATM_Implementation\Project_Supplementary\2016_12_28_AWS_Log.txt";
                string appendText = "Correct Pin" + " " + (DateTime.Now).ToString() + Environment.NewLine;
                string appendText2 = "Battery life: " + Lib2.charge + "% " + (DateTime.Now).ToString() + Environment.NewLine;

                File.AppendAllText(path, appendText);
                File.AppendAllText(path, appendText2);
            }
            else
            {

                string path = @"Y:\Documents\GitHub\2016_12_13_Helios_ATM_Implementation\Project_Supplementary\2016_12_28_AWS_Log.txt";
                string appendText = "Incorrect Pin:" + " " + (DateTime.Now).ToString() + Environment.NewLine;
                string appendText2 = "Battery life: " + Lib2.charge + "% " + (DateTime.Now).ToString() + Environment.NewLine;

                File.AppendAllText(path, appendText);
                File.AppendAllText(path, appendText2);

            }


        }




        //Delete all of the PIN entry textbox
        private void NumDeleteAll_Click(object sender, EventArgs e)
        {
            PIN = "";
            this.PinEntry.Text = PIN;
        }
        //Delete last number of the PIN entry textbox
        private void NumBack_Click(object sender, EventArgs e)
        {
            PIN = PIN.Substring(0, PIN.Length-1);
            this.PinEntry.Text = PIN;
        }
    }
}
