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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM0));
            this.EnterHereButton = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.label3 = new System.Windows.Forms.Label();
            this.InfoText = new System.Windows.Forms.Label();
            this.EnvironmentLabel = new System.Windows.Forms.Label();
            this.ProblemsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CheckBoxPowerSourceBattery = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxNetworkConnectionUnstable = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxPINEntriesExhausted = new MetroFramework.Controls.MetroCheckBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "WELCOME";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 11;
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoText.Location = new System.Drawing.Point(49, 133);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(405, 38);
            this.InfoText.TabIndex = 12;
            this.InfoText.Text = "Please choose the use case.";
            // 
            // EnvironmentLabel
            // 
            this.EnvironmentLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnvironmentLabel.Location = new System.Drawing.Point(42, 191);
            this.EnvironmentLabel.MaximumSize = new System.Drawing.Size(1000, 100);
            this.EnvironmentLabel.Name = "EnvironmentLabel";
            this.EnvironmentLabel.Size = new System.Drawing.Size(412, 59);
            this.EnvironmentLabel.TabIndex = 13;
            this.EnvironmentLabel.Text = "For information about the environment, move the cursor over the elements.";
            this.EnvironmentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProblemsLabel
            // 
            this.ProblemsLabel.AutoSize = true;
            this.ProblemsLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemsLabel.Location = new System.Drawing.Point(62, 267);
            this.ProblemsLabel.Name = "ProblemsLabel";
            this.ProblemsLabel.Size = new System.Drawing.Size(106, 25);
            this.ProblemsLabel.TabIndex = 14;
            this.ProblemsLabel.Text = "Problems:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "E-Mail notifications receiver:";
            // 
            // EmailTextBox
            // 
            // 
            // 
            // 
            this.EmailTextBox.CustomButton.Image = null;
            this.EmailTextBox.CustomButton.Location = new System.Drawing.Point(322, 1);
            this.EmailTextBox.CustomButton.Name = "";
            this.EmailTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EmailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EmailTextBox.CustomButton.TabIndex = 1;
            this.EmailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmailTextBox.CustomButton.UseSelectable = true;
            this.EmailTextBox.CustomButton.Visible = false;
            this.EmailTextBox.Lines = new string[] {
        "Enter your E-Mail here!"};
            this.EmailTextBox.Location = new System.Drawing.Point(67, 470);
            this.EmailTextBox.MaxLength = 32767;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.SelectionLength = 0;
            this.EmailTextBox.SelectionStart = 0;
            this.EmailTextBox.ShortcutsEnabled = true;
            this.EmailTextBox.Size = new System.Drawing.Size(344, 23);
            this.EmailTextBox.TabIndex = 18;
            this.EmailTextBox.Text = "Enter your E-Mail here!";
            this.EmailTextBox.UseSelectable = true;
            this.EmailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CheckBoxPowerSourceBattery
            // 
            this.CheckBoxPowerSourceBattery.AutoSize = true;
            this.CheckBoxPowerSourceBattery.Checked = true;
            this.CheckBoxPowerSourceBattery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxPowerSourceBattery.Location = new System.Drawing.Point(214, 272);
            this.CheckBoxPowerSourceBattery.Name = "CheckBoxPowerSourceBattery";
            this.CheckBoxPowerSourceBattery.Size = new System.Drawing.Size(150, 17);
            this.CheckBoxPowerSourceBattery.TabIndex = 19;
            this.CheckBoxPowerSourceBattery.Text = "Power source: Battery";
            this.CheckBoxPowerSourceBattery.UseSelectable = true;
            // 
            // CheckBoxNetworkConnectionUnstable
            // 
            this.CheckBoxNetworkConnectionUnstable.AutoSize = true;
            this.CheckBoxNetworkConnectionUnstable.Checked = true;
            this.CheckBoxNetworkConnectionUnstable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxNetworkConnectionUnstable.Location = new System.Drawing.Point(214, 308);
            this.CheckBoxNetworkConnectionUnstable.Name = "CheckBoxNetworkConnectionUnstable";
            this.CheckBoxNetworkConnectionUnstable.Size = new System.Drawing.Size(193, 17);
            this.CheckBoxNetworkConnectionUnstable.TabIndex = 20;
            this.CheckBoxNetworkConnectionUnstable.Text = "Network connection unstable";
            this.CheckBoxNetworkConnectionUnstable.UseSelectable = true;
            // 
            // CheckBoxPINEntriesExhausted
            // 
            this.CheckBoxPINEntriesExhausted.AutoSize = true;
            this.CheckBoxPINEntriesExhausted.Checked = true;
            this.CheckBoxPINEntriesExhausted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxPINEntriesExhausted.Location = new System.Drawing.Point(214, 344);
            this.CheckBoxPINEntriesExhausted.Name = "CheckBoxPINEntriesExhausted";
            this.CheckBoxPINEntriesExhausted.Size = new System.Drawing.Size(150, 17);
            this.CheckBoxPINEntriesExhausted.TabIndex = 21;
            this.CheckBoxPINEntriesExhausted.Text = "PIN entries exhausted";
            this.CheckBoxPINEntriesExhausted.UseSelectable = true;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ATM0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(516, 544);
            this.ControlBox = false;
            this.Controls.Add(this.CheckBoxPINEntriesExhausted);
            this.Controls.Add(this.CheckBoxNetworkConnectionUnstable);
            this.Controls.Add(this.CheckBoxPowerSourceBattery);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProblemsLabel);
            this.Controls.Add(this.EnvironmentLabel);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NetworkSignal);
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterHereButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ATM0";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Load += new System.EventHandler(this.ATM0_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton EnterHereButton;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Label EnvironmentLabel;
        private System.Windows.Forms.Label ProblemsLabel;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox EmailTextBox;
        private MetroFramework.Controls.MetroCheckBox CheckBoxPowerSourceBattery;
        private MetroFramework.Controls.MetroCheckBox CheckBoxNetworkConnectionUnstable;
        private MetroFramework.Controls.MetroCheckBox CheckBoxPINEntriesExhausted;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}

