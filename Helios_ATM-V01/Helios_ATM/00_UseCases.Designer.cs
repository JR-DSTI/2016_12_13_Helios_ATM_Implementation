namespace Helios_ATM
{
    partial class ATM0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM0));
            this.EnterHereButton = new MetroFramework.Controls.MetroButton();
            this.WelcomeTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CheckBoxZeroCash = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxPowerSourceBattery = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxPINEntriesExhausted = new MetroFramework.Controls.MetroCheckBox();
            this.UseCaseLabel = new MetroFramework.Controls.MetroLabel();
            this.CheckBoxNetworkConnectionUnstable = new MetroFramework.Controls.MetroCheckBox();
            this.SMSlabel = new MetroFramework.Controls.MetroLabel();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.phoneFormatLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterHereButton
            // 
            this.EnterHereButton.Location = new System.Drawing.Point(164, 510);
            this.EnterHereButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterHereButton.Name = "EnterHereButton";
            this.EnterHereButton.Size = new System.Drawing.Size(171, 23);
            this.EnterHereButton.TabIndex = 0;
            this.EnterHereButton.Text = "ENTER HERE";
            this.EnterHereButton.UseSelectable = true;
            this.EnterHereButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // WelcomeTimer
            // 
            this.WelcomeTimer.Interval = 1000;
            this.WelcomeTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 77);
            this.label1.TabIndex = 4;
            this.label1.Text = "HELIOS";
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(7, 15);
            this.BatteryCharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.Size = new System.Drawing.Size(44, 17);
            this.BatteryCharge.TabIndex = 8;
            this.BatteryCharge.Value = 100;
            this.BatteryCharge.Click += new System.EventHandler(this.BatteryCharge_Click);
            // 
            // NetworkSignal
            // 
            this.NetworkSignal.Location = new System.Drawing.Point(456, 15);
            this.NetworkSignal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NetworkSignal.Maximum = 100;
            this.NetworkSignal.Name = "NetworkSignal";
            this.NetworkSignal.Size = new System.Drawing.Size(45, 41);
            this.NetworkSignal.TabIndex = 10;
            this.NetworkSignal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NetworkSignal.UseSelectable = true;
            this.NetworkSignal.Value = 1;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CheckBoxZeroCash
            // 
            this.CheckBoxZeroCash.AutoSize = true;
            this.CheckBoxZeroCash.Location = new System.Drawing.Point(218, 169);
            this.CheckBoxZeroCash.Name = "CheckBoxZeroCash";
            this.CheckBoxZeroCash.Size = new System.Drawing.Size(149, 17);
            this.CheckBoxZeroCash.TabIndex = 11;
            this.CheckBoxZeroCash.Text = "Zero cash on account";
            this.CheckBoxZeroCash.UseSelectable = true;
            // 
            // CheckBoxPowerSourceBattery
            // 
            this.CheckBoxPowerSourceBattery.AutoSize = true;
            this.CheckBoxPowerSourceBattery.Location = new System.Drawing.Point(218, 214);
            this.CheckBoxPowerSourceBattery.Name = "CheckBoxPowerSourceBattery";
            this.CheckBoxPowerSourceBattery.Size = new System.Drawing.Size(151, 17);
            this.CheckBoxPowerSourceBattery.TabIndex = 12;
            this.CheckBoxPowerSourceBattery.Text = "Power source: battery";
            this.CheckBoxPowerSourceBattery.UseSelectable = true;
            // 
            // CheckBoxPINEntriesExhausted
            // 
            this.CheckBoxPINEntriesExhausted.AutoSize = true;
            this.CheckBoxPINEntriesExhausted.Location = new System.Drawing.Point(218, 259);
            this.CheckBoxPINEntriesExhausted.Name = "CheckBoxPINEntriesExhausted";
            this.CheckBoxPINEntriesExhausted.Size = new System.Drawing.Size(169, 17);
            this.CheckBoxPINEntriesExhausted.TabIndex = 13;
            this.CheckBoxPINEntriesExhausted.Text = "No more PIN entries left.";
            this.CheckBoxPINEntriesExhausted.UseSelectable = true;
            // 
            // UseCaseLabel
            // 
            this.UseCaseLabel.AutoSize = true;
            this.UseCaseLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UseCaseLabel.Location = new System.Drawing.Point(35, 97);
            this.UseCaseLabel.Name = "UseCaseLabel";
            this.UseCaseLabel.Size = new System.Drawing.Size(429, 25);
            this.UseCaseLabel.TabIndex = 14;
            this.UseCaseLabel.Text = "Choose the use case for the upcoming ATM screens:";
            // 
            // CheckBoxNetworkConnectionUnstable
            // 
            this.CheckBoxNetworkConnectionUnstable.AutoSize = true;
            this.CheckBoxNetworkConnectionUnstable.Location = new System.Drawing.Point(218, 304);
            this.CheckBoxNetworkConnectionUnstable.Name = "CheckBoxNetworkConnectionUnstable";
            this.CheckBoxNetworkConnectionUnstable.Size = new System.Drawing.Size(195, 17);
            this.CheckBoxNetworkConnectionUnstable.TabIndex = 15;
            this.CheckBoxNetworkConnectionUnstable.Text = "Unstable network connection.";
            this.CheckBoxNetworkConnectionUnstable.UseSelectable = true;
            // 
            // SMSlabel
            // 
            this.SMSlabel.AutoSize = true;
            this.SMSlabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SMSlabel.Location = new System.Drawing.Point(23, 400);
            this.SMSlabel.Name = "SMSlabel";
            this.SMSlabel.Size = new System.Drawing.Size(476, 25);
            this.SMSlabel.TabIndex = 17;
            this.SMSlabel.Text = "Enter a phone number for notifications (charges do apply):";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(218, 439);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(170, 22);
            this.EmailTextBox.TabIndex = 18;
            // 
            // phoneFormatLabel
            // 
            this.phoneFormatLabel.AutoSize = true;
            this.phoneFormatLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.phoneFormatLabel.Location = new System.Drawing.Point(121, 464);
            this.phoneFormatLabel.Name = "phoneFormatLabel";
            this.phoneFormatLabel.Size = new System.Drawing.Size(360, 17);
            this.phoneFormatLabel.TabIndex = 19;
            this.phoneFormatLabel.Text = "Number format with country code: 00[country code]123454345";
            // 
            // ATM0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(516, 544);
            this.ControlBox = false;
            this.Controls.Add(this.phoneFormatLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.SMSlabel);
            this.Controls.Add(this.CheckBoxNetworkConnectionUnstable);
            this.Controls.Add(this.UseCaseLabel);
            this.Controls.Add(this.CheckBoxPINEntriesExhausted);
            this.Controls.Add(this.CheckBoxPowerSourceBattery);
            this.Controls.Add(this.CheckBoxZeroCash);
            this.Controls.Add(this.NetworkSignal);
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterHereButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ATM0";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Load += new System.EventHandler(this.ATM0_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer WelcomeTimer;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton EnterHereButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroCheckBox CheckBoxZeroCash;
        private MetroFramework.Controls.MetroCheckBox CheckBoxPowerSourceBattery;
        private MetroFramework.Controls.MetroCheckBox CheckBoxPINEntriesExhausted;
        private MetroFramework.Controls.MetroLabel UseCaseLabel;
        private MetroFramework.Controls.MetroCheckBox CheckBoxNetworkConnectionUnstable;
        private MetroFramework.Controls.MetroLabel SMSlabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private MetroFramework.Controls.MetroLabel phoneFormatLabel;
    }
}

