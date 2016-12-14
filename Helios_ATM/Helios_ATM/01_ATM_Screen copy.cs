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
    public partial class ATM2 : Form
    {
        public ATM2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.WelcomeProgressBar.Increment(10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WelcomeTimer.Start();
            this.WelcomeProgressBar.Visible = true;
            

           // not100yet:
           //if this.WelcomeProgressBar.Value= 100 (
                
           //     )
           // else
           // goto not100yet
           //         end if

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ATM2
            // 
            this.ClientSize = new System.Drawing.Size(444, 364);
            this.Name = "ATM2";
            this.ResumeLayout(false);

        }
    }
}
