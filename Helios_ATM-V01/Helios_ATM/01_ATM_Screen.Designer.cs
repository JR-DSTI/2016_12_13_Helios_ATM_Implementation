namespace Helios_ATM
{
    partial class ATM1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM1));
            this.EnterHereButton = new MetroFramework.Controls.MetroButton();
            this.WelcomeTimer = new System.Windows.Forms.Timer(this.components);
            this.WelcomeProgressBar = new System.Windows.Forms.ProgressBar();
            this.HeliosLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.InitializeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BatteryNetworkTimer = new System.Windows.Forms.Timer(this.components);
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
            // WelcomeProgressBar
            // 
            this.WelcomeProgressBar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.WelcomeProgressBar.Location = new System.Drawing.Point(140, 272);
            this.WelcomeProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WelcomeProgressBar.Name = "WelcomeProgressBar";
            this.WelcomeProgressBar.Size = new System.Drawing.Size(219, 16);
            this.WelcomeProgressBar.TabIndex = 3;
            this.WelcomeProgressBar.Visible = false;
            // 
            // HeliosLabel
            // 
            this.HeliosLabel.AutoSize = true;
            this.HeliosLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeliosLabel.Location = new System.Drawing.Point(125, 9);
            this.HeliosLabel.Name = "HeliosLabel";
            this.HeliosLabel.Size = new System.Drawing.Size(242, 77);
            this.HeliosLabel.TabIndex = 4;
            this.HeliosLabel.Text = "HELIOS";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(83, 430);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(336, 77);
            this.WelcomeLabel.TabIndex = 5;
            this.WelcomeLabel.Text = "WELCOME";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(431, 452);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(61, 32);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "FastTrack";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
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
            // InitializeLabel
            // 
            this.InitializeLabel.AutoSize = true;
            this.InitializeLabel.Location = new System.Drawing.Point(140, 250);
            this.InitializeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InitializeLabel.Name = "InitializeLabel";
            this.InitializeLabel.Size = new System.Drawing.Size(81, 17);
            this.InitializeLabel.TabIndex = 11;
            this.InitializeLabel.Text = "Initializing...";
            // 
            // BatteryNetworkTimer
            // 
            this.BatteryNetworkTimer.Interval = 1000;
            this.BatteryNetworkTimer.Tick += new System.EventHandler(this.BatteryNetworkTimer_Tick);
            // 
            // ATM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(516, 544);
            this.ControlBox = false;
            this.Controls.Add(this.InitializeLabel);
            this.Controls.Add(this.NetworkSignal);
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.HeliosLabel);
            this.Controls.Add(this.WelcomeProgressBar);
            this.Controls.Add(this.EnterHereButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ATM1";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Load += new System.EventHandler(this.ATM1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer WelcomeTimer;
        private System.Windows.Forms.ProgressBar WelcomeProgressBar;
        private System.Windows.Forms.Label HeliosLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton EnterHereButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private System.Windows.Forms.Label InitializeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer BatteryNetworkTimer;
    }
}

