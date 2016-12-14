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
    public partial class ATM5 : Form
    {
        private bool waterMarkActive;
        private String PIN;
        private int PINentries=0;

        public ATM5()
        {
            InitializeComponent();
        }

        private void ATM5_Load(object sender, EventArgs e1)
        {
            this.waterMarkActive = true;
            this.PinEntry.ForeColor = Color.Gray;
            this.PinEntry.Text = "****";

            this.PinEntry.GotFocus += (source,e) =>
            {
                if (this.waterMarkActive)
                {
                    this.waterMarkActive = false;
                    this.PinEntry.Text = "";
                    this.PinEntry.ForeColor = Color.Black;
                }
            };

            this.PinEntry.LostFocus += (source, e) =>
            {
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

            //Form ATM6 = new ATM6(); // Instantiate a Form object.
            //ATM6.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
        }

        private void ConfirmPINentry_Click_1(object sender, EventArgs e)
        {
            

            PIN = this.PinEntry.Text;
            if (!PIN.Any(char.IsLetter)) //Continue if PIN contains only numeric
            {

                PINentries = PINentries + 1;

                if (PINentries<=3 & PIN == "1111")
                {
                    MessageBox.Show("PIN entry successful!");
                    
                    //next screen

                }
                else if (PINentries < 3 & PIN != "1111")
                {
                    MessageBox.Show("PIN entry not successful, retry! Left attempts: " + Convert.ToString(3-PINentries));

                }
                else if (PINentries > 3)
                {
                    MessageBox.Show("Last PIN entry not successful, no attempts left, no money for you");
                    return;
                };


            }
            else
            {

                MessageBox.Show("Please provide a numercial PIN.");

            }

            //set back to empty box:
            this.PinEntry.Text = "";
        }

        private void PinEntry_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                ConfirmPINentry_Click_1(new object(), new EventArgs());
            }
        }
    }
}
