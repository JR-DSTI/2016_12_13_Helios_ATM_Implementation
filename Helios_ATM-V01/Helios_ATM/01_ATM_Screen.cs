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
    public partial class ATM1 : MetroFramework.Forms.MetroForm
    {
        public ATM1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.WelcomeProgressBar.Increment(10);  // this = is the current form
        }

        private async void MetroProgressBar_nextscreen_progress()
        {

            do
            {
                this.MetroProgressBar_nextscreen.Increment(6);
                await Task.Delay(50);
            } while  (this.MetroProgressBar_nextscreen.ProgressTotalPercent < 100);
            
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            //timer to pretend waiting and system setup :
            MetroProgressBar_nextscreen_progress();

            //"await" needs the async in the function declaration and equals "Sleep"
            await Task.Delay(2000);
            
            //start the next form
            Form ATM3 = new ATM3(); // Instantiate a Form object.
            ATM3.Show(); //show the new Form

            //hide the old form
            this.Visible = false;  //Hide the old form
            

        }

        private void ATM1_Load(object sender, EventArgs e)
        {

        }

        //Quick jump to current Form:
        private void metroButton1_Click(object sender, EventArgs e)
        {
            MetroFramework.Forms.MetroForm ATM6 = new ATM6(); // Instantiate a Form object.
            ATM6.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
        }

        
    }
}
