

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM7a));
            this.label1 = new System.Windows.Forms.Label();
            this.Withdraw500Button = new MetroFramework.Controls.MetroButton();
            this.Withdraw100Button = new MetroFramework.Controls.MetroButton();
            this.Withdraw20Button = new MetroFramework.Controls.MetroButton();
            this.AbortButton = new MetroFramework.Controls.MetroButton();
            this.CancelButton = new MetroFramework.Controls.MetroButton();
            this.Withdraw5Button = new MetroFramework.Controls.MetroButton();
            this.WithdrawOtherButton = new MetroFramework.Controls.MetroButton();
            this.Withdraw10Button = new MetroFramework.Controls.MetroButton();
            this.Withdraw50Button = new MetroFramework.Controls.MetroButton();
            this.Withdraw200Button = new MetroFramework.Controls.MetroButton();
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
            this.BatteryNetworkTimer = new System.Windows.Forms.Timer(this.components);
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
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose amount to withdraw";
            // 
            // Withdraw500Button
            // 
            this.Withdraw500Button.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw500Button.Location = new System.Drawing.Point(57, 183);
            this.Withdraw500Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Withdraw500Button.Name = "Withdraw500Button";
            this.Withdraw500Button.Size = new System.Drawing.Size(141, 37);
            this.Withdraw500Button.TabIndex = 5;
            this.Withdraw500Button.Text = "500";
            this.Withdraw500Button.UseSelectable = true;
            this.Withdraw500Button.Click += new System.EventHandler(this.Withdraw500_Click);
            // 
            // Withdraw100Button
            // 
            this.Withdraw100Button.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw100Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Withdraw100Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdraw100Button.Location = new System.Drawing.Point(57, 252);
            this.Withdraw100Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Withdraw100Button.Name = "Withdraw100Button";
            this.Withdraw100Button.Size = new System.Drawing.Size(141, 37);
            this.Withdraw100Button.TabIndex = 6;
            this.Withdraw100Button.Text = "100";
            this.Withdraw100Button.UseCustomBackColor = true;
            this.Withdraw100Button.UseSelectable = true;
            this.Withdraw100Button.Click += new System.EventHandler(this.Withdraw100_Click);
            // 
            // Withdraw20Button
            // 
            this.Withdraw20Button.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw20Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Withdraw20Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdraw20Button.Location = new System.Drawing.Point(57, 321);
            this.Withdraw20Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Withdraw20Button.Name = "Withdraw20Button";
            this.Withdraw20Button.Size = new System.Drawing.Size(141, 37);
            this.Withdraw20Button.TabIndex = 7;
            this.Withdraw20Button.Text = "20";
            this.Withdraw20Button.UseCustomBackColor = true;
            this.Withdraw20Button.UseSelectable = true;
            this.Withdraw20Button.Click += new System.EventHandler(this.Withdraw20_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(317, 487);
            this.AbortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(141, 37);
            this.AbortButton.TabIndex = 11;
            this.AbortButton.Text = "Abort and Eject card";
            this.AbortButton.UseSelectable = true;
            this.AbortButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(57, 487);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(141, 37);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseSelectable = true;
            this.CancelButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Withdraw5Button
            // 
            this.Withdraw5Button.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw5Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Withdraw5Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdraw5Button.Location = new System.Drawing.Point(57, 390);
            this.Withdraw5Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Withdraw5Button.Name = "Withdraw5Button";
            this.Withdraw5Button.Size = new System.Drawing.Size(141, 37);
            this.Withdraw5Button.TabIndex = 13;
            this.Withdraw5Button.Text = "5";
            this.Withdraw5Button.UseCustomBackColor = true;
            this.Withdraw5Button.UseSelectable = true;
            this.Withdraw5Button.Click += new System.EventHandler(this.Withdraw5_Click);
            // 
            // WithdrawOtherButton
            // 
            this.WithdrawOtherButton.BackColor = System.Drawing.SystemColors.Control;
            this.WithdrawOtherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WithdrawOtherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WithdrawOtherButton.Location = new System.Drawing.Point(317, 390);
            this.WithdrawOtherButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WithdrawOtherButton.Name = "WithdrawOtherButton";
            this.WithdrawOtherButton.Size = new System.Drawing.Size(141, 37);
            this.WithdrawOtherButton.TabIndex = 18;
            this.WithdrawOtherButton.Text = "Other...";
            this.WithdrawOtherButton.UseCustomBackColor = true;
            this.WithdrawOtherButton.UseSelectable = true;
            this.WithdrawOtherButton.Click += new System.EventHandler(this.WithdrawOther_Click);
            // 
            // Withdraw10Button
            // 
            this.Withdraw10Button.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw10Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Withdraw10Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdraw10Button.Location = new System.Drawing.Point(317, 321);
            this.Withdraw10Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Withdraw10Button.Name = "Withdraw10Button";
            this.Withdraw10Button.Size = new System.Drawing.Size(141, 37);
            this.Withdraw10Button.TabIndex = 17;
            this.Withdraw10Button.Text = "10";
            this.Withdraw10Button.UseCustomBackColor = true;
            this.Withdraw10Button.UseSelectable = true;
            this.Withdraw10Button.Click += new System.EventHandler(this.Withdraw10_Click);
            // 
            // Withdraw50Button
            // 
            this.Withdraw50Button.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw50Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Withdraw50Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdraw50Button.Location = new System.Drawing.Point(317, 252);
            this.Withdraw50Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Withdraw50Button.Name = "Withdraw50Button";
            this.Withdraw50Button.Size = new System.Drawing.Size(141, 37);
            this.Withdraw50Button.TabIndex = 16;
            this.Withdraw50Button.Text = "50";
            this.Withdraw50Button.UseCustomBackColor = true;
            this.Withdraw50Button.UseSelectable = true;
            this.Withdraw50Button.Click += new System.EventHandler(this.Withdraw50_Click);
            // 
            // Withdraw200Button
            // 
            this.Withdraw200Button.BackColor = System.Drawing.SystemColors.Control;
            this.Withdraw200Button.Location = new System.Drawing.Point(317, 183);
            this.Withdraw200Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Withdraw200Button.Name = "Withdraw200Button";
            this.Withdraw200Button.Size = new System.Drawing.Size(141, 37);
            this.Withdraw200Button.TabIndex = 15;
            this.Withdraw200Button.Text = "200";
            this.Withdraw200Button.UseSelectable = true;
            this.Withdraw200Button.Click += new System.EventHandler(this.Withdraw200_Click);
            // 
            // NetworkSignal
            // 
            this.NetworkSignal.Location = new System.Drawing.Point(479, 7);
            this.NetworkSignal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NetworkSignal.Maximum = 100;
            this.NetworkSignal.Name = "NetworkSignal";
            this.NetworkSignal.Size = new System.Drawing.Size(27, 30);
            this.NetworkSignal.TabIndex = 20;
            this.NetworkSignal.UseSelectable = true;
            this.NetworkSignal.Value = 100;
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(12, 7);
            this.BatteryCharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.Size = new System.Drawing.Size(44, 17);
            this.BatteryCharge.TabIndex = 19;
            this.BatteryCharge.Value = 100;
            // 
            // BatteryNetworkTimer
            // 
            this.BatteryNetworkTimer.Interval = 1000;
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
            this.Controls.Add(this.WithdrawOtherButton);
            this.Controls.Add(this.Withdraw10Button);
            this.Controls.Add(this.Withdraw50Button);
            this.Controls.Add(this.Withdraw200Button);
            this.Controls.Add(this.Withdraw5Button);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.Withdraw20Button);
            this.Controls.Add(this.Withdraw100Button);
            this.Controls.Add(this.Withdraw500Button);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ATM7a";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Load += new System.EventHandler(this.ATM7a_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton AbortButton;
        private MetroFramework.Controls.MetroButton CancelButton;
        private MetroFramework.Controls.MetroButton Withdraw500Button;
        private MetroFramework.Controls.MetroButton Withdraw100Button;
        private MetroFramework.Controls.MetroButton Withdraw20Button;
        private MetroFramework.Controls.MetroButton Withdraw5Button;
        private MetroFramework.Controls.MetroButton WithdrawOtherButton;
        private MetroFramework.Controls.MetroButton Withdraw10Button;
        private MetroFramework.Controls.MetroButton Withdraw50Button;
        private MetroFramework.Controls.MetroButton Withdraw200Button;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
        private System.Windows.Forms.Timer BatteryNetworkTimer;
    }
}

