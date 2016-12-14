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
    public partial class ATM4 : Form
    {
        public ATM4()
        {
            InitializeComponent();
        }

        private void ATM4_Load(object sender, EventArgs e)
        {

        }

        private async void CardInserted_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);

            Form ATM5 = new ATM5(); // Instantiate a Form object.
            ATM5.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    this.WelcomeProgressBar.Increment(10);
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.WelcomeTimer.Start();
        //    this.WelcomeProgressBar.Visible = true;

        //    Form InsertCard = new ATM2(); // Instantiate a Form object.
        //    InsertCard.Show(); 
        //    this.Close();


        //   // not100yet:
        //   //if this.WelcomeProgressBar.Value= 100 (

        //    //     )
        //    // else
        //    // goto not100yet
        //    //         end if

        //}
    }
}
