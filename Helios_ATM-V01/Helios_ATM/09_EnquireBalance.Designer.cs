

namespace Helios_ATM
{
     partial class ATM9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM9));
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new MetroFramework.Controls.MetroButton();
            this.CheckingsLabel = new MetroFramework.Controls.MetroLabel();
            this.SavingsLabel = new MetroFramework.Controls.MetroLabel();
            this.PesosLabel2 = new MetroFramework.Controls.MetroLabel();
            this.PesosLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CheckingsButton = new MetroFramework.Controls.MetroButton();
            this.SavingsButton = new MetroFramework.Controls.MetroButton();
            this.AbortButton = new MetroFramework.Controls.MetroButton();
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
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enquire balance";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(35, 430);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 73);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseSelectable = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CheckingsLabel
            // 
            this.CheckingsLabel.AutoSize = true;
            this.CheckingsLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CheckingsLabel.Location = new System.Drawing.Point(272, 187);
            this.CheckingsLabel.Name = "CheckingsLabel";
            this.CheckingsLabel.Size = new System.Drawing.Size(97, 25);
            this.CheckingsLabel.Style = MetroFramework.MetroColorStyle.Silver;
            this.CheckingsLabel.TabIndex = 7;
            this.CheckingsLabel.Text = "XX,XXX.XX";
            this.CheckingsLabel.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // SavingsLabel
            // 
            this.SavingsLabel.AutoSize = true;
            this.SavingsLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SavingsLabel.Location = new System.Drawing.Point(272, 282);
            this.SavingsLabel.Name = "SavingsLabel";
            this.SavingsLabel.Size = new System.Drawing.Size(97, 25);
            this.SavingsLabel.Style = MetroFramework.MetroColorStyle.Silver;
            this.SavingsLabel.TabIndex = 8;
            this.SavingsLabel.Text = "XX,XXX.XX";
            this.SavingsLabel.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // PesosLabel2
            // 
            this.PesosLabel2.AutoSize = true;
            this.PesosLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PesosLabel2.Location = new System.Drawing.Point(405, 282);
            this.PesosLabel2.Name = "PesosLabel2";
            this.PesosLabel2.Size = new System.Drawing.Size(57, 25);
            this.PesosLabel2.TabIndex = 10;
            this.PesosLabel2.Text = "Pesos";
            this.PesosLabel2.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // PesosLabel1
            // 
            this.PesosLabel1.AutoSize = true;
            this.PesosLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PesosLabel1.Location = new System.Drawing.Point(405, 187);
            this.PesosLabel1.Name = "PesosLabel1";
            this.PesosLabel1.Size = new System.Drawing.Size(57, 25);
            this.PesosLabel1.TabIndex = 9;
            this.PesosLabel1.Text = "Pesos";
            // 
            // CheckingsButton
            // 
            this.CheckingsButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CheckingsButton.Location = new System.Drawing.Point(64, 179);
            this.CheckingsButton.Name = "CheckingsButton";
            this.CheckingsButton.Size = new System.Drawing.Size(146, 40);
            this.CheckingsButton.TabIndex = 11;
            this.CheckingsButton.Text = "Checkings";
            this.CheckingsButton.UseSelectable = true;
            this.CheckingsButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // SavingsButton
            // 
            this.SavingsButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.SavingsButton.Location = new System.Drawing.Point(64, 274);
            this.SavingsButton.Name = "SavingsButton";
            this.SavingsButton.Size = new System.Drawing.Size(146, 40);
            this.SavingsButton.TabIndex = 12;
            this.SavingsButton.Text = "Savings";
            this.SavingsButton.UseSelectable = true;
            this.SavingsButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(385, 435);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(77, 68);
            this.AbortButton.TabIndex = 13;
            this.AbortButton.Text = "Abort and\r\neject card";
            this.AbortButton.UseSelectable = true;
            this.AbortButton.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // NetworkSignal
            // 
            this.NetworkSignal.Location = new System.Drawing.Point(480, 12);
            this.NetworkSignal.Maximum = 100;
            this.NetworkSignal.Name = "NetworkSignal";
            this.NetworkSignal.Size = new System.Drawing.Size(27, 29);
            this.NetworkSignal.TabIndex = 15;
            this.NetworkSignal.UseSelectable = true;
            this.NetworkSignal.Value = 100;
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(13, 12);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.Size = new System.Drawing.Size(44, 17);
            this.BatteryCharge.TabIndex = 14;
            this.BatteryCharge.Value = 100;
            // 
            // BatteryNetworkTimer
            // 
            this.BatteryNetworkTimer.Interval = 1000;
            this.BatteryNetworkTimer.Tick += new System.EventHandler(this.BatteryNetworkTimer_Tick);
            // 
            // ATM9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(516, 544);
            this.ControlBox = false;
            this.Controls.Add(this.NetworkSignal);
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.SavingsButton);
            this.Controls.Add(this.CheckingsButton);
            this.Controls.Add(this.PesosLabel2);
            this.Controls.Add(this.PesosLabel1);
            this.Controls.Add(this.SavingsLabel);
            this.Controls.Add(this.CheckingsLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ATM9";
            this.Load += new System.EventHandler(this.ATM9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private new MetroFramework.Controls.MetroButton CancelButton;
        private MetroFramework.Controls.MetroLabel CheckingsLabel;
        private MetroFramework.Controls.MetroLabel SavingsLabel;
        private MetroFramework.Controls.MetroLabel PesosLabel2;
        private MetroFramework.Controls.MetroLabel PesosLabel1;
        private MetroFramework.Controls.MetroButton CheckingsButton;
        private MetroFramework.Controls.MetroButton SavingsButton;
        private MetroFramework.Controls.MetroButton AbortButton;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
        private System.Windows.Forms.Timer BatteryNetworkTimer;
    }
}

