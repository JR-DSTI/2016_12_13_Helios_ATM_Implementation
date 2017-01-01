

namespace Helios_ATM
{
    partial class ATM4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM4));
            this.label1 = new System.Windows.Forms.Label();
            this.EnglishButton = new MetroFramework.Controls.MetroButton();
            this.FrenchButton = new MetroFramework.Controls.MetroButton();
            this.MandarinButton = new MetroFramework.Controls.MetroButton();
            this.button3 = new MetroFramework.Controls.MetroButton();
            this.PortuguesButton = new MetroFramework.Controls.MetroButton();
            this.SpanishButton = new MetroFramework.Controls.MetroButton();
            this.AbortButton = new MetroFramework.Controls.MetroButton();
            this.CancelButton = new MetroFramework.Controls.MetroButton();
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please choose language. ";
            // 
            // EnglishButton
            // 
            this.EnglishButton.Location = new System.Drawing.Point(31, 215);
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.Size = new System.Drawing.Size(142, 37);
            this.EnglishButton.TabIndex = 5;
            this.EnglishButton.Text = "English";
            this.EnglishButton.UseSelectable = true;
            this.EnglishButton.Click += new System.EventHandler(this.CardInserted_Click);
            // 
            // FrenchButton
            // 
            this.FrenchButton.BackColor = System.Drawing.Color.DarkGray;
            this.FrenchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FrenchButton.Cursor = System.Windows.Forms.Cursors.No;
            this.FrenchButton.Enabled = false;
            this.FrenchButton.Location = new System.Drawing.Point(31, 286);
            this.FrenchButton.Name = "FrenchButton";
            this.FrenchButton.Size = new System.Drawing.Size(142, 37);
            this.FrenchButton.TabIndex = 6;
            this.FrenchButton.Text = "Francais";
            this.FrenchButton.UseCustomBackColor = true;
            this.FrenchButton.UseSelectable = true;
            // 
            // MandarinButton
            // 
            this.MandarinButton.BackColor = System.Drawing.Color.DarkGray;
            this.MandarinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MandarinButton.Cursor = System.Windows.Forms.Cursors.No;
            this.MandarinButton.Enabled = false;
            this.MandarinButton.Location = new System.Drawing.Point(31, 360);
            this.MandarinButton.Name = "MandarinButton";
            this.MandarinButton.Size = new System.Drawing.Size(142, 37);
            this.MandarinButton.TabIndex = 7;
            this.MandarinButton.Text = "富盈";
            this.MandarinButton.UseCustomBackColor = true;
            this.MandarinButton.UseSelectable = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.No;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(340, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "...";
            this.button3.UseCustomBackColor = true;
            this.button3.UseSelectable = true;
            // 
            // PortuguesButton
            // 
            this.PortuguesButton.BackColor = System.Drawing.Color.DarkGray;
            this.PortuguesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PortuguesButton.Cursor = System.Windows.Forms.Cursors.No;
            this.PortuguesButton.Enabled = false;
            this.PortuguesButton.Location = new System.Drawing.Point(340, 286);
            this.PortuguesButton.Name = "PortuguesButton";
            this.PortuguesButton.Size = new System.Drawing.Size(142, 37);
            this.PortuguesButton.TabIndex = 9;
            this.PortuguesButton.Text = "Português";
            this.PortuguesButton.UseCustomBackColor = true;
            this.PortuguesButton.UseSelectable = true;
            // 
            // SpanishButton
            // 
            this.SpanishButton.BackColor = System.Drawing.Color.DarkGray;
            this.SpanishButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SpanishButton.Cursor = System.Windows.Forms.Cursors.No;
            this.SpanishButton.Enabled = false;
            this.SpanishButton.Location = new System.Drawing.Point(340, 215);
            this.SpanishButton.Name = "SpanishButton";
            this.SpanishButton.Size = new System.Drawing.Size(142, 37);
            this.SpanishButton.TabIndex = 8;
            this.SpanishButton.Text = "Espagnol";
            this.SpanishButton.UseCustomBackColor = true;
            this.SpanishButton.UseSelectable = true;
            this.SpanishButton.Click += new System.EventHandler(this.SpanishButton_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(340, 498);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(142, 23);
            this.AbortButton.TabIndex = 11;
            this.AbortButton.Text = "Abort and Eject card";
            this.AbortButton.UseSelectable = true;
            this.AbortButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(31, 498);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(142, 23);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseSelectable = true;
            this.CancelButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // NetworkSignal
            // 
            this.NetworkSignal.Location = new System.Drawing.Point(477, 9);
            this.NetworkSignal.Maximum = 100;
            this.NetworkSignal.Name = "NetworkSignal";
            this.NetworkSignal.Size = new System.Drawing.Size(27, 29);
            this.NetworkSignal.TabIndex = 14;
            this.NetworkSignal.UseSelectable = true;
            this.NetworkSignal.Value = 100;
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(10, 9);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.Size = new System.Drawing.Size(44, 17);
            this.BatteryCharge.TabIndex = 13;
            this.BatteryCharge.Value = 100;
            // 
            // ATM4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(516, 544);
            this.ControlBox = false;
            this.Controls.Add(this.NetworkSignal);
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PortuguesButton);
            this.Controls.Add(this.SpanishButton);
            this.Controls.Add(this.MandarinButton);
            this.Controls.Add(this.FrenchButton);
            this.Controls.Add(this.EnglishButton);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ATM4";
            this.Load += new System.EventHandler(this.ATM4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton AbortButton;
        private MetroFramework.Controls.MetroButton CancelButton;
        private MetroFramework.Controls.MetroButton EnglishButton;
        private MetroFramework.Controls.MetroButton FrenchButton;
        private MetroFramework.Controls.MetroButton MandarinButton;
        private MetroFramework.Controls.MetroButton button3;
        private MetroFramework.Controls.MetroButton PortuguesButton;
        private MetroFramework.Controls.MetroButton SpanishButton;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
    }
}

