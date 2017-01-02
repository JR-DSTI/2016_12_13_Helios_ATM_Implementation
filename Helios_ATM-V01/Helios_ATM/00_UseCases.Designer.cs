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
            // ATM0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(516, 544);
            this.ControlBox = false;
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
    }
}

