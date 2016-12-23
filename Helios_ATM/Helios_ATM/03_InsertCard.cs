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
    public partial class ATM3 : MetroFramework.Forms.MetroForm
    {
        public ATM3()
        {
            InitializeComponent();
        }

        private void ATM3_Load(object sender, EventArgs e)
        {

        }

        private async void CardInserted_Click(object sender, EventArgs e)
        {
            //again "sleep" for the form
            await Task.Delay(500);

            //continue to next form:
            Form ATM4 = new ATM4(); // Instantiate a Form object.
            ATM4.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //cancel to initial form, maybe not too necessary here
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
        }

        
    }
}
