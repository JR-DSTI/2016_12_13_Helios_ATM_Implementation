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
            this.button1 = new System.Windows.Forms.Button();
            this.WelcomeTimer = new System.Windows.Forms.Timer(this.components);
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.WelcomeProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ENTER HERE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WelcomeTimer
            // 
            this.WelcomeTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(458, 10);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(16, 16);
            this.metroProgressSpinner1.TabIndex = 0;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(523, 41);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.TabIndex = 0;
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
            // ATM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(501, 544);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeProgressBar);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ATM1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer WelcomeTimer;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.ProgressBar WelcomeProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

