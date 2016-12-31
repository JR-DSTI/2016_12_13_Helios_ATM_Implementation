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
    public partial class DragandDrop : Form
    {
        public DragandDrop()
        {
            InitializeComponent();
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
           
                e.Effect = DragDropEffects.Copy;
         
        }


        private void DragandDrop_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\assan\Downloads\Untitled.bmp");
            pictureBox2.Image = Image.FromFile(@"C:\Users\assan\Downloads\filetype_bmp.bmp");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            if ((e.Data.GetDataPresent(DataFormats.Bitmap)))
                this.pictureBox2.Image = (Bitmap)(e.Data.GetData(DataFormats.Bitmap));

        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{

        //}

        //private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        //{

        //}

        //private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        //{

        //}

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.All);
        }
    }
}
