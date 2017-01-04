

namespace Helios_ATM
{
     partial class ATM3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM3));
            this.InsertCardLabel = new System.Windows.Forms.Label();
            this.CardInsertedButton = new MetroFramework.Controls.MetroButton();
            this.AbortCancelButton = new MetroFramework.Controls.MetroButton();
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BatteryNetworkTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // InsertCardLabel
            // 
            this.InsertCardLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InsertCardLabel.AutoSize = true;
            this.InsertCardLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InsertCardLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertCardLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertCardLabel.Location = new System.Drawing.Point(63, 9);
            this.InsertCardLabel.Name = "InsertCardLabel";
            this.InsertCardLabel.Size = new System.Drawing.Size(374, 42);
            this.InsertCardLabel.TabIndex = 4;
            this.InsertCardLabel.Text = "Please insert your card.";
            // 
            // CardInsertedButton
            // 
            this.CardInsertedButton.Location = new System.Drawing.Point(361, 430);
            this.CardInsertedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CardInsertedButton.Name = "CardInsertedButton";
            this.CardInsertedButton.Size = new System.Drawing.Size(93, 73);
            this.CardInsertedButton.TabIndex = 5;
            this.CardInsertedButton.Text = "Card Inserted";
            this.CardInsertedButton.UseSelectable = true;
            this.CardInsertedButton.Click += new System.EventHandler(this.CardInserted_Click);
            // 
            // AbortCancelButton
            // 
            this.AbortCancelButton.Location = new System.Drawing.Point(35, 430);
            this.AbortCancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AbortCancelButton.Name = "AbortCancelButton";
            this.AbortCancelButton.Size = new System.Drawing.Size(93, 73);
            this.AbortCancelButton.TabIndex = 6;
            this.AbortCancelButton.Text = "Cancel";
            this.AbortCancelButton.UseSelectable = true;
            this.AbortCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NetworkSignal
            // 
            this.NetworkSignal.Location = new System.Drawing.Point(477, 9);
            this.NetworkSignal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NetworkSignal.Maximum = 100;
            this.NetworkSignal.Name = "NetworkSignal";
            this.NetworkSignal.Size = new System.Drawing.Size(27, 30);
            this.NetworkSignal.TabIndex = 12;
            this.NetworkSignal.UseSelectable = true;
            this.NetworkSignal.Value = 100;
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(13, 9);
            this.BatteryCharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.Size = new System.Drawing.Size(44, 17);
            this.BatteryCharge.TabIndex = 11;
            this.BatteryCharge.Value = 100;
            this.BatteryCharge.Click += new System.EventHandler(this.BatteryCharge_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BatteryNetworkTimer
            // 
            this.BatteryNetworkTimer.Interval = 1000;
            this.BatteryNetworkTimer.Tick += new System.EventHandler(this.BatteryNetworkTimer_Tick);
            // 
            // ATM3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(516, 544);
            this.ControlBox = false;
            this.Controls.Add(this.NetworkSignal);
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.AbortCancelButton);
            this.Controls.Add(this.CardInsertedButton);
            this.Controls.Add(this.InsertCardLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ATM3";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Load += new System.EventHandler(this.ATM3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InsertCardLabel;
        private MetroFramework.Controls.MetroButton AbortCancelButton;
        private MetroFramework.Controls.MetroButton CardInsertedButton;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer BatteryNetworkTimer;
    }
}

