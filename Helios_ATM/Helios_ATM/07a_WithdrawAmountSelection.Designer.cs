

namespace Helios_ATM
{
    partial class ATM7a
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM7a));
            this.label1 = new System.Windows.Forms.Label();
            this.Withdraw500 = new MetroFramework.Controls.MetroButton();
            this.Withdraw100 = new MetroFramework.Controls.MetroButton();
            this.Withdraw20 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.Withdraw5 = new MetroFramework.Controls.MetroButton();
            this.WithdrawOther = new MetroFramework.Controls.MetroButton();
            this.Withdraw10 = new MetroFramework.Controls.MetroButton();
            this.Withdraw50 = new MetroFramework.Controls.MetroButton();
            this.Withdraw200 = new MetroFramework.Controls.MetroButton();
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
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose amount to withdraw";
            // 
            // Withdraw500
            // 
            this.Withdraw500.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw500.Location = new System.Drawing.Point(57, 183);
            this.Withdraw500.Name = "Withdraw500";
            this.Withdraw500.Size = new System.Drawing.Size(142, 37);
            this.Withdraw500.TabIndex = 5;
            this.Withdraw500.Text = "500";
            this.Withdraw500.UseSelectable = true;
            this.Withdraw500.Click += new System.EventHandler(this.CardInserted_Click);
            // 
            // Withdraw100
            // 
            this.Withdraw100.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Withdraw100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdraw100.Location = new System.Drawing.Point(57, 252);
            this.Withdraw100.Name = "Withdraw100";
            this.Withdraw100.Size = new System.Drawing.Size(142, 37);
            this.Withdraw100.TabIndex = 6;
            this.Withdraw100.Text = "100";
            this.Withdraw100.UseCustomBackColor = true;
            this.Withdraw100.UseSelectable = true;
            this.Withdraw100.Click += new System.EventHandler(this.Withdraw100_Click);
            // 
            // Withdraw20
            // 
            this.Withdraw20.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Withdraw20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdraw20.Location = new System.Drawing.Point(57, 321);
            this.Withdraw20.Name = "Withdraw20";
            this.Withdraw20.Size = new System.Drawing.Size(142, 37);
            this.Withdraw20.TabIndex = 7;
            this.Withdraw20.Text = "20";
            this.Withdraw20.UseCustomBackColor = true;
            this.Withdraw20.UseSelectable = true;
            this.Withdraw20.Click += new System.EventHandler(this.Withdraw20_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(317, 487);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(142, 37);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Abort and Eject card";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(57, 487);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(142, 37);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "Back";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Withdraw5
            // 
            this.Withdraw5.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Withdraw5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdraw5.Location = new System.Drawing.Point(57, 390);
            this.Withdraw5.Name = "Withdraw5";
            this.Withdraw5.Size = new System.Drawing.Size(142, 37);
            this.Withdraw5.TabIndex = 13;
            this.Withdraw5.Text = "5";
            this.Withdraw5.UseCustomBackColor = true;
            this.Withdraw5.UseSelectable = true;
            this.Withdraw5.Click += new System.EventHandler(this.Withdraw5_Click);
            // 
            // WithdrawOther
            // 
            this.WithdrawOther.BackColor = System.Drawing.SystemColors.Control;
            this.WithdrawOther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WithdrawOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WithdrawOther.Location = new System.Drawing.Point(317, 390);
            this.WithdrawOther.Name = "WithdrawOther";
            this.WithdrawOther.Size = new System.Drawing.Size(142, 37);
            this.WithdrawOther.TabIndex = 18;
            this.WithdrawOther.Text = "Other...";
            this.WithdrawOther.UseCustomBackColor = true;
            this.WithdrawOther.UseSelectable = true;
            this.WithdrawOther.Click += new System.EventHandler(this.WithdrawOther_Click);
            // 
            // Withdraw10
            // 
            this.Withdraw10.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Withdraw10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdraw10.Location = new System.Drawing.Point(317, 321);
            this.Withdraw10.Name = "Withdraw10";
            this.Withdraw10.Size = new System.Drawing.Size(142, 37);
            this.Withdraw10.TabIndex = 17;
            this.Withdraw10.Text = "10";
            this.Withdraw10.UseCustomBackColor = true;
            this.Withdraw10.UseSelectable = true;
            this.Withdraw10.Click += new System.EventHandler(this.Withdraw10_Click);
            // 
            // Withdraw50
            // 
            this.Withdraw50.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Withdraw50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdraw50.Location = new System.Drawing.Point(317, 252);
            this.Withdraw50.Name = "Withdraw50";
            this.Withdraw50.Size = new System.Drawing.Size(142, 37);
            this.Withdraw50.TabIndex = 16;
            this.Withdraw50.Text = "50";
            this.Withdraw50.UseCustomBackColor = true;
            this.Withdraw50.UseSelectable = true;
            this.Withdraw50.Click += new System.EventHandler(this.Withdraw50_Click);
            // 
            // Withdraw200
            // 
            this.Withdraw200.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw200.Location = new System.Drawing.Point(317, 183);
            this.Withdraw200.Name = "Withdraw200";
            this.Withdraw200.Size = new System.Drawing.Size(142, 37);
            this.Withdraw200.TabIndex = 15;
            this.Withdraw200.Text = "200";
            this.Withdraw200.UseSelectable = true;
            this.Withdraw200.Click += new System.EventHandler(this.Withdraw200_Click);
            // 
            // NetworkSignal
            // 
            this.NetworkSignal.Location = new System.Drawing.Point(479, 7);
            this.NetworkSignal.Maximum = 100;
            this.NetworkSignal.Name = "NetworkSignal";
            this.NetworkSignal.Size = new System.Drawing.Size(27, 29);
            this.NetworkSignal.TabIndex = 20;
            this.NetworkSignal.UseSelectable = true;
            this.NetworkSignal.Value = 100;
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(12, 7);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.Size = new System.Drawing.Size(44, 17);
            this.BatteryCharge.TabIndex = 19;
            this.BatteryCharge.Value = 100;
            // 
            // ATM7a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(516, 544);
            this.ControlBox = false;
            this.Controls.Add(this.NetworkSignal);
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.WithdrawOther);
            this.Controls.Add(this.Withdraw10);
            this.Controls.Add(this.Withdraw50);
            this.Controls.Add(this.Withdraw200);
            this.Controls.Add(this.Withdraw5);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Withdraw20);
            this.Controls.Add(this.Withdraw100);
            this.Controls.Add(this.Withdraw500);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ATM7a";
            this.Load += new System.EventHandler(this.ATM7a_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton Withdraw500;
        private MetroFramework.Controls.MetroButton Withdraw100;
        private MetroFramework.Controls.MetroButton Withdraw20;
        private MetroFramework.Controls.MetroButton Withdraw5;
        private MetroFramework.Controls.MetroButton WithdrawOther;
        private MetroFramework.Controls.MetroButton Withdraw10;
        private MetroFramework.Controls.MetroButton Withdraw50;
        private MetroFramework.Controls.MetroButton Withdraw200;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
    }
}

