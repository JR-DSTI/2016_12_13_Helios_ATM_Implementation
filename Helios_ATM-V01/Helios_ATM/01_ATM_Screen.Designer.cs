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
            this.MetroProgressBar_nextscreen = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ENTER HERE";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WelcomeTimer
            // 
            this.WelcomeTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WelcomeProgressBar
            // 
            this.WelcomeProgressBar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.WelcomeProgressBar.Location = new System.Drawing.Point(139, 273);
            this.WelcomeProgressBar.Name = "WelcomeProgressBar";
            this.WelcomeProgressBar.Size = new System.Drawing.Size(219, 61);
            this.WelcomeProgressBar.TabIndex = 3;
            this.WelcomeProgressBar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 77);
            this.label1.TabIndex = 4;
            this.label1.Text = "HELIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 77);
            this.label2.TabIndex = 5;
            this.label2.Text = "WELCOME";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(431, 452);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(62, 32);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "FastTrack";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(7, 15);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.Size = new System.Drawing.Size(44, 17);
            this.BatteryCharge.TabIndex = 8;
            this.BatteryCharge.Value = 100;
            // 
            // NetworkSignal
            // 
            this.NetworkSignal.Location = new System.Drawing.Point(474, 15);
            this.NetworkSignal.Maximum = 100;
            this.NetworkSignal.Name = "NetworkSignal";
            this.NetworkSignal.Size = new System.Drawing.Size(27, 29);
            this.NetworkSignal.TabIndex = 10;
            this.NetworkSignal.UseSelectable = true;
            this.NetworkSignal.Value = 100;
            // 
            // MetroProgressBar_nextscreen
            // 
            this.MetroProgressBar_nextscreen.Location = new System.Drawing.Point(159, 208);
            this.MetroProgressBar_nextscreen.MarqueeAnimationSpeed = 10;
            this.MetroProgressBar_nextscreen.Name = "MetroProgressBar_nextscreen";
            this.MetroProgressBar_nextscreen.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.MetroProgressBar_nextscreen.Size = new System.Drawing.Size(176, 68);
            this.MetroProgressBar_nextscreen.TabIndex = 11;
            this.MetroProgressBar_nextscreen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroProgressBar_nextscreen.UseWaitCursor = true;
            // 
            // ATM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(516, 544);
            this.ControlBox = false;
            this.Controls.Add(this.MetroProgressBar_nextscreen);
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
            this.Name = "ATM1";
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
        private MetroFramework.Controls.MetroProgressBar MetroProgressBar_nextscreen;
    }
}

