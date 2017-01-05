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
            this.HeliosLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CheckBoxPowerSourceBattery = new MetroFramework.Controls.MetroCheckBox();
            this.UseCaseLabel = new MetroFramework.Controls.MetroLabel();
            this.CheckBoxNetworkConnectionUnstable = new MetroFramework.Controls.MetroCheckBox();
            this.SMSlabel = new MetroFramework.Controls.MetroLabel();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.phoneFormatLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBoxUseCases = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterHereButton
            // 
            this.EnterHereButton.Location = new System.Drawing.Point(173, 535);
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
            // HeliosLabel
            // 
            this.HeliosLabel.AutoSize = true;
            this.HeliosLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeliosLabel.Location = new System.Drawing.Point(139, 9);
            this.HeliosLabel.Name = "HeliosLabel";
            this.HeliosLabel.Size = new System.Drawing.Size(242, 77);
            this.HeliosLabel.TabIndex = 4;
            this.HeliosLabel.Text = "HELIOS";
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(7, 15);
            this.BatteryCharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.Size = new System.Drawing.Size(44, 17);
            this.BatteryCharge.TabIndex = 8;
            this.BatteryCharge.Value = 100;
            // 
            // NetworkSignal
            // 
            this.NetworkSignal.Location = new System.Drawing.Point(635, 15);
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
            // CheckBoxPowerSourceBattery
            // 
            this.CheckBoxPowerSourceBattery.AutoSize = true;
            this.CheckBoxPowerSourceBattery.Location = new System.Drawing.Point(133, 234);
            this.CheckBoxPowerSourceBattery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxPowerSourceBattery.Name = "CheckBoxPowerSourceBattery";
            this.CheckBoxPowerSourceBattery.Size = new System.Drawing.Size(203, 17);
            this.CheckBoxPowerSourceBattery.TabIndex = 12;
            this.CheckBoxPowerSourceBattery.Text = "Power source for ATM: battery";
            this.CheckBoxPowerSourceBattery.UseSelectable = true;
            // 
            // UseCaseLabel
            // 
            this.UseCaseLabel.AutoSize = true;
            this.UseCaseLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UseCaseLabel.Location = new System.Drawing.Point(45, 97);
            this.UseCaseLabel.Name = "UseCaseLabel";
            this.UseCaseLabel.Size = new System.Drawing.Size(429, 25);
            this.UseCaseLabel.TabIndex = 14;
            this.UseCaseLabel.Text = "Choose the use case for the upcoming ATM screens:";
            // 
            // CheckBoxNetworkConnectionUnstable
            // 
            this.CheckBoxNetworkConnectionUnstable.AutoSize = true;
            this.CheckBoxNetworkConnectionUnstable.Location = new System.Drawing.Point(133, 295);
            this.CheckBoxNetworkConnectionUnstable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxNetworkConnectionUnstable.Name = "CheckBoxNetworkConnectionUnstable";
            this.CheckBoxNetworkConnectionUnstable.Size = new System.Drawing.Size(195, 17);
            this.CheckBoxNetworkConnectionUnstable.TabIndex = 15;
            this.CheckBoxNetworkConnectionUnstable.Text = "Unstable network connection.";
            this.CheckBoxNetworkConnectionUnstable.UseSelectable = true;
            // 
            // SMSlabel
            // 
            this.SMSlabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SMSlabel.Location = new System.Drawing.Point(84, 362);
            this.SMSlabel.Name = "SMSlabel";
            this.SMSlabel.Size = new System.Drawing.Size(351, 62);
            this.SMSlabel.TabIndex = 17;
            this.SMSlabel.Text = "Enter a phone number for notifications: (SMS charges do apply!!! No joke.)";
            this.SMSlabel.WrapToLine = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(175, 441);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(169, 22);
            this.EmailTextBox.TabIndex = 18;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // phoneFormatLabel
            // 
            this.phoneFormatLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.phoneFormatLabel.Location = new System.Drawing.Point(110, 465);
            this.phoneFormatLabel.Name = "phoneFormatLabel";
            this.phoneFormatLabel.Size = new System.Drawing.Size(292, 49);
            this.phoneFormatLabel.TabIndex = 19;
            this.phoneFormatLabel.Text = "Numbers without spaces but with country code: +[country code]123454345";
            this.phoneFormatLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.phoneFormatLabel.WrapToLine = true;
            this.phoneFormatLabel.Click += new System.EventHandler(this.phoneFormatLabel_Click);
            // 
            // comboBoxUseCases
            // 
            this.comboBoxUseCases.FormattingEnabled = true;
            this.comboBoxUseCases.ItemHeight = 16;
            this.comboBoxUseCases.Location = new System.Drawing.Point(133, 166);
            this.comboBoxUseCases.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxUseCases.Name = "comboBoxUseCases";
            this.comboBoxUseCases.Size = new System.Drawing.Size(196, 24);
            this.comboBoxUseCases.TabIndex = 20;
            this.comboBoxUseCases.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(437, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "KILL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ATM0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(509, 590);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxUseCases);
            this.Controls.Add(this.phoneFormatLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.SMSlabel);
            this.Controls.Add(this.CheckBoxNetworkConnectionUnstable);
            this.Controls.Add(this.UseCaseLabel);
            this.Controls.Add(this.CheckBoxPowerSourceBattery);
            this.Controls.Add(this.NetworkSignal);
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.HeliosLabel);
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
        private System.Windows.Forms.Label HeliosLabel;
        private MetroFramework.Controls.MetroButton EnterHereButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroCheckBox CheckBoxPowerSourceBattery;
        private MetroFramework.Controls.MetroLabel UseCaseLabel;
        private MetroFramework.Controls.MetroCheckBox CheckBoxNetworkConnectionUnstable;
        private MetroFramework.Controls.MetroLabel SMSlabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private MetroFramework.Controls.MetroLabel phoneFormatLabel;
        private System.Windows.Forms.ComboBox comboBoxUseCases;
        private System.Windows.Forms.Button button1;
    }
}

