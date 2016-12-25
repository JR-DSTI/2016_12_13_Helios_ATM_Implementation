

namespace Helios_ATM
{
    partial class ATM4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM4));
            this.label1 = new System.Windows.Forms.Label();
            this.EnglishButton = new MetroFramework.Controls.MetroButton();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.button3 = new MetroFramework.Controls.MetroButton();
            this.button4 = new MetroFramework.Controls.MetroButton();
            this.button5 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please choose language. ";
            // 
            // EnglishButton
            // 
            this.EnglishButton.Location = new System.Drawing.Point(31, 215);
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.Size = new System.Drawing.Size(142, 37);
            this.EnglishButton.TabIndex = 5;
            this.EnglishButton.Text = "English";
            this.EnglishButton.UseSelectable = true;
            this.EnglishButton.Click += new System.EventHandler(this.CardInserted_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(31, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Francais";
            this.button1.UseCustomBackColor = true;
            this.button1.UseSelectable = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.No;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(31, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "富盈";
            this.button2.UseCustomBackColor = true;
            this.button2.UseSelectable = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.No;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(340, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "...";
            this.button3.UseCustomBackColor = true;
            this.button3.UseSelectable = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.No;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(340, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 37);
            this.button4.TabIndex = 9;
            this.button4.Text = "Português";
            this.button4.UseCustomBackColor = true;
            this.button4.UseSelectable = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGray;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.No;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(340, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 37);
            this.button5.TabIndex = 8;
            this.button5.Text = "Espagnol";
            this.button5.UseCustomBackColor = true;
            this.button5.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(340, 498);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(142, 23);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Abort and Eject card";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(31, 498);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(142, 23);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "Back";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // NetworkSignal
            // 
            this.NetworkSignal.Location = new System.Drawing.Point(477, 9);
            this.NetworkSignal.Maximum = 100;
            this.NetworkSignal.Name = "NetworkSignal";
            this.NetworkSignal.Size = new System.Drawing.Size(27, 29);
            this.NetworkSignal.TabIndex = 14;
            this.NetworkSignal.UseSelectable = true;
            this.NetworkSignal.Value = 100;
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(10, 9);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.Size = new System.Drawing.Size(44, 17);
            this.BatteryCharge.TabIndex = 13;
            this.BatteryCharge.Value = 100;
            // 
            // ATM4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(516, 544);
            this.ControlBox = false;
            this.Controls.Add(this.NetworkSignal);
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EnglishButton);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ATM4";
            this.Load += new System.EventHandler(this.ATM4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton EnglishButton;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroButton button2;
        private MetroFramework.Controls.MetroButton button3;
        private MetroFramework.Controls.MetroButton button4;
        private MetroFramework.Controls.MetroButton button5;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
    }
}

