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
    public partial class ATM1 : Form
    {
        public ATM1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.WelcomeProgressBar.Increment(10);  // this = is the current form
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.WelcomeTimer.Start();
            this.WelcomeProgressBar.Visible = true;
            await Task.Delay(3000);
            //System.Threading.Thread.Sleep(2000);
            
            Form ATM3 = new ATM3(); // Instantiate a Form object.
            ATM3.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
            

        }
    }
}
