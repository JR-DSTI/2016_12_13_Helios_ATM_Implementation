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
    public partial class ATM6 : Form
    {
        public ATM6()
        {
            InitializeComponent();
            delay_progressbar();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.WelcomeProgressBar.Increment(10);  // this = is the current form
        }

        private async void delay_progressbar(){
            this.WelcomeTimer.Start();
            this.WelcomeProgressBar.Visible = true;
            await Task.Delay(2000);
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            

            //Form ATM3 = new ATM3(); // Instantiate a Form object.
            //ATM3.Show(); //show the new Form

            //this.Visible = false;  //Hide the old form


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
