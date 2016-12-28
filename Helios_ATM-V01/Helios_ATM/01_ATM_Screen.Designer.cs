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
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.WelcomeTimer = new System.Windows.Forms.Timer(this.components);
            this.WelcomeProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "ENTER HERE";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WelcomeTimer
            // 
            this.WelcomeTimer.Interval = 1000;
            this.WelcomeTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WelcomeProgressBar
            // 
            this.WelcomeProgressBar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.WelcomeProgressBar.Location = new System.Drawing.Point(105, 221);
            this.WelcomeProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.WelcomeProgressBar.Name = "WelcomeProgressBar";
            this.WelcomeProgressBar.Size = new System.Drawing.Size(164, 13);
            this.WelcomeProgressBar.TabIndex = 3;
            this.WelcomeProgressBar.Visible = false;
            this.WelcomeProgressBar.Click += new System.EventHandler(this.WelcomeProgressBar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "HELIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 61);
            this.label2.TabIndex = 5;
            this.label2.Text = "WELCOME";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(323, 367);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(46, 26);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "FastTrack";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(5, 12);
            this.BatteryCharge.Margin = new System.Windows.Forms.Padding(2);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.Size = new System.Drawing.Size(33, 14);
            this.BatteryCharge.TabIndex = 8;
            this.BatteryCharge.Value = 100;
            this.BatteryCharge.Click += new System.EventHandler(this.BatteryCharge_Click);
            // 
            // NetworkSignal
            // 
            this.NetworkSignal.Location = new System.Drawing.Point(342, 12);
            this.NetworkSignal.Margin = new System.Windows.Forms.Padding(2);
            this.NetworkSignal.Maximum = 100;
            this.NetworkSignal.Name = "NetworkSignal";
            this.NetworkSignal.Size = new System.Drawing.Size(34, 33);
            this.NetworkSignal.TabIndex = 10;
            this.NetworkSignal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NetworkSignal.UseSelectable = true;
            this.NetworkSignal.Value = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Initializing...";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ATM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(387, 442);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NetworkSignal);
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeProgressBar);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ATM1";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Load += new System.EventHandler(this.ATM1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer WelcomeTimer;
        private System.Windows.Forms.ProgressBar WelcomeProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

