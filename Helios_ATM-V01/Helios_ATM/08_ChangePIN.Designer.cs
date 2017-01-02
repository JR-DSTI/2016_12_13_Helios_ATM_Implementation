namespace Helios_ATM
{
    partial class ATM8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM8));
            this.ChangePINLabel = new System.Windows.Forms.Label();
            this.AbortButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.NumDeleteAll = new MetroFramework.Controls.MetroButton();
            this.NumBack = new MetroFramework.Controls.MetroButton();
            this.Num3 = new MetroFramework.Controls.MetroButton();
            this.Num0 = new MetroFramework.Controls.MetroButton();
            this.Num2 = new MetroFramework.Controls.MetroButton();
            this.Num1 = new MetroFramework.Controls.MetroButton();
            this.Num6 = new MetroFramework.Controls.MetroButton();
            this.Num5 = new MetroFramework.Controls.MetroButton();
            this.Num4 = new MetroFramework.Controls.MetroButton();
            this.Num9 = new MetroFramework.Controls.MetroButton();
            this.Num8 = new MetroFramework.Controls.MetroButton();
            this.Num7 = new MetroFramework.Controls.MetroButton();
            this.OLDPinEntry = new System.Windows.Forms.TextBox();
            this.NewPinEntry = new System.Windows.Forms.TextBox();
            this.ConfirmNewPinEntry = new System.Windows.Forms.TextBox();
            this.ConfirmPINentryButton = new MetroFramework.Controls.MetroButton();
            this.CancelButton = new MetroFramework.Controls.MetroButton();
            this.OldPINLabel1 = new MetroFramework.Controls.MetroLabel();
            this.NewPINLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ReentryPINLabel3 = new MetroFramework.Controls.MetroLabel();
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
            this.BatteryNetworkTimer = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangePINLabel
            // 
            this.ChangePINLabel.AutoSize = true;
            this.ChangePINLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePINLabel.Location = new System.Drawing.Point(145, 21);
            this.ChangePINLabel.Name = "ChangePINLabel";
            this.ChangePINLabel.Size = new System.Drawing.Size(232, 48);
            this.ChangePINLabel.TabIndex = 4;
            this.ChangePINLabel.Text = "Change PIN";
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(21, 434);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(77, 68);
            this.AbortButton.TabIndex = 13;
            this.AbortButton.Text = "Abort and\r\neject card";
            this.AbortButton.UseSelectable = true;
            this.AbortButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.NumDeleteAll);
            this.metroPanel1.Controls.Add(this.NumBack);
            this.metroPanel1.Controls.Add(this.Num3);
            this.metroPanel1.Controls.Add(this.Num0);
            this.metroPanel1.Controls.Add(this.Num2);
            this.metroPanel1.Controls.Add(this.Num1);
            this.metroPanel1.Controls.Add(this.Num6);
            this.metroPanel1.Controls.Add(this.Num5);
            this.metroPanel1.Controls.Add(this.Num4);
            this.metroPanel1.Controls.Add(this.Num9);
            this.metroPanel1.Controls.Add(this.Num8);
            this.metroPanel1.Controls.Add(this.Num7);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(185, 90);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(308, 400);
            this.metroPanel1.TabIndex = 15;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // NumDeleteAll
            // 
            this.NumDeleteAll.DisplayFocus = true;
            this.NumDeleteAll.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.NumDeleteAll.Highlight = true;
            this.NumDeleteAll.Location = new System.Drawing.Point(16, 319);
            this.NumDeleteAll.Name = "NumDeleteAll";
            this.NumDeleteAll.Size = new System.Drawing.Size(75, 75);
            this.NumDeleteAll.TabIndex = 12;
            this.NumDeleteAll.Text = "DEL";
            this.NumDeleteAll.UseSelectable = true;
            this.NumDeleteAll.Click += new System.EventHandler(this.NumDeleteAll_Click);
            // 
            // NumBack
            // 
            this.NumBack.DisplayFocus = true;
            this.NumBack.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.NumBack.Highlight = true;
            this.NumBack.Location = new System.Drawing.Point(217, 319);
            this.NumBack.Name = "NumBack";
            this.NumBack.Size = new System.Drawing.Size(75, 75);
            this.NumBack.TabIndex = 11;
            this.NumBack.Text = "<-";
            this.NumBack.UseSelectable = true;
            this.NumBack.Click += new System.EventHandler(this.NumBack_Click);
            // 
            // Num3
            // 
            this.Num3.DisplayFocus = true;
            this.Num3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num3.Highlight = true;
            this.Num3.Location = new System.Drawing.Point(217, 214);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(75, 75);
            this.Num3.TabIndex = 10;
            this.Num3.Text = "3";
            this.Num3.UseSelectable = true;
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Num0
            // 
            this.Num0.DisplayFocus = true;
            this.Num0.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num0.Highlight = true;
            this.Num0.Location = new System.Drawing.Point(117, 319);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(75, 75);
            this.Num0.TabIndex = 9;
            this.Num0.Text = "0";
            this.Num0.UseSelectable = true;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Num2
            // 
            this.Num2.DisplayFocus = true;
            this.Num2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num2.Highlight = true;
            this.Num2.Location = new System.Drawing.Point(117, 214);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(75, 75);
            this.Num2.TabIndex = 9;
            this.Num2.Text = "2";
            this.Num2.UseSelectable = true;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num1
            // 
            this.Num1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num1.Highlight = true;
            this.Num1.Location = new System.Drawing.Point(16, 214);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(75, 75);
            this.Num1.TabIndex = 8;
            this.Num1.Text = "1";
            this.Num1.UseSelectable = true;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num6
            // 
            this.Num6.DisplayFocus = true;
            this.Num6.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num6.Highlight = true;
            this.Num6.Location = new System.Drawing.Point(217, 113);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(75, 75);
            this.Num6.TabIndex = 7;
            this.Num6.Text = "6";
            this.Num6.UseSelectable = true;
            this.Num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // Num5
            // 
            this.Num5.DisplayFocus = true;
            this.Num5.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num5.Highlight = true;
            this.Num5.Location = new System.Drawing.Point(117, 113);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(75, 75);
            this.Num5.TabIndex = 6;
            this.Num5.Text = "5";
            this.Num5.UseSelectable = true;
            this.Num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // Num4
            // 
            this.Num4.DisplayFocus = true;
            this.Num4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num4.Highlight = true;
            this.Num4.Location = new System.Drawing.Point(16, 113);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(75, 75);
            this.Num4.TabIndex = 5;
            this.Num4.Text = "4";
            this.Num4.UseSelectable = true;
            this.Num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // Num9
            // 
            this.Num9.DisplayFocus = true;
            this.Num9.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num9.Highlight = true;
            this.Num9.Location = new System.Drawing.Point(217, 14);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(75, 75);
            this.Num9.TabIndex = 4;
            this.Num9.Text = "9";
            this.Num9.UseSelectable = true;
            this.Num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // Num8
            // 
            this.Num8.DisplayFocus = true;
            this.Num8.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num8.Highlight = true;
            this.Num8.Location = new System.Drawing.Point(117, 14);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(75, 75);
            this.Num8.TabIndex = 3;
            this.Num8.Text = "8";
            this.Num8.UseSelectable = true;
            this.Num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // Num7
            // 
            this.Num7.DisplayFocus = true;
            this.Num7.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num7.Highlight = true;
            this.Num7.Location = new System.Drawing.Point(16, 14);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(75, 75);
            this.Num7.TabIndex = 2;
            this.Num7.Text = "7";
            this.Num7.UseSelectable = true;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // OLDPinEntry
            // 
            this.OLDPinEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OLDPinEntry.ImeMode = System.Windows.Forms.ImeMode.On;
            this.OLDPinEntry.Location = new System.Drawing.Point(23, 126);
            this.OLDPinEntry.MaxLength = 8;
            this.OLDPinEntry.Name = "OLDPinEntry";
            this.OLDPinEntry.PasswordChar = '*';
            this.OLDPinEntry.Size = new System.Drawing.Size(126, 53);
            this.OLDPinEntry.TabIndex = 14;
            this.OLDPinEntry.Text = "****";
            this.OLDPinEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewPinEntry
            // 
            this.NewPinEntry.AcceptsReturn = true;
            this.NewPinEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPinEntry.Location = new System.Drawing.Point(21, 225);
            this.NewPinEntry.MaxLength = 8;
            this.NewPinEntry.Name = "NewPinEntry";
            this.NewPinEntry.PasswordChar = '*';
            this.NewPinEntry.Size = new System.Drawing.Size(126, 53);
            this.NewPinEntry.TabIndex = 16;
            this.NewPinEntry.Text = "****";
            this.NewPinEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfirmNewPinEntry
            // 
            this.ConfirmNewPinEntry.AcceptsReturn = true;
            this.ConfirmNewPinEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNewPinEntry.Location = new System.Drawing.Point(23, 326);
            this.ConfirmNewPinEntry.MaxLength = 8;
            this.ConfirmNewPinEntry.Name = "ConfirmNewPinEntry";
            this.ConfirmNewPinEntry.PasswordChar = '*';
            this.ConfirmNewPinEntry.Size = new System.Drawing.Size(126, 53);
            this.ConfirmNewPinEntry.TabIndex = 17;
            this.ConfirmNewPinEntry.Text = "****";
            this.ConfirmNewPinEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfirmPINentryButton
            // 
            this.ConfirmPINentryButton.Location = new System.Drawing.Point(106, 434);
            this.ConfirmPINentryButton.Name = "ConfirmPINentryButton";
            this.ConfirmPINentryButton.Size = new System.Drawing.Size(73, 68);
            this.ConfirmPINentryButton.TabIndex = 18;
            this.ConfirmPINentryButton.Text = "Confirm";
            this.ConfirmPINentryButton.UseSelectable = true;
            this.ConfirmPINentryButton.Click += new System.EventHandler(this.ConfirmPINentry_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(23, 508);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(77, 30);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseSelectable = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OldPINLabel1
            // 
            this.OldPINLabel1.AutoSize = true;
            this.OldPINLabel1.Location = new System.Drawing.Point(57, 103);
            this.OldPINLabel1.Name = "OldPINLabel1";
            this.OldPINLabel1.Size = new System.Drawing.Size(57, 20);
            this.OldPINLabel1.TabIndex = 20;
            this.OldPINLabel1.Text = "Old PIN";
            // 
            // NewPINLabel2
            // 
            this.NewPINLabel2.AutoSize = true;
            this.NewPINLabel2.Location = new System.Drawing.Point(57, 202);
            this.NewPINLabel2.Name = "NewPINLabel2";
            this.NewPINLabel2.Size = new System.Drawing.Size(64, 20);
            this.NewPINLabel2.TabIndex = 21;
            this.NewPINLabel2.Text = "New PIN";
            // 
            // ReentryPINLabel3
            // 
            this.ReentryPINLabel3.AutoSize = true;
            this.ReentryPINLabel3.Location = new System.Drawing.Point(33, 304);
            this.ReentryPINLabel3.Name = "ReentryPINLabel3";
            this.ReentryPINLabel3.Size = new System.Drawing.Size(114, 20);
            this.ReentryPINLabel3.TabIndex = 22;
            this.ReentryPINLabel3.Text = "Reenter new PIN";
            // 
            // NetworkSignal
            // 
            this.NetworkSignal.Location = new System.Drawing.Point(480, 12);
            this.NetworkSignal.Maximum = 100;
            this.NetworkSignal.Name = "NetworkSignal";
            this.NetworkSignal.Size = new System.Drawing.Size(27, 29);
            this.NetworkSignal.TabIndex = 24;
            this.NetworkSignal.UseSelectable = true;
            this.NetworkSignal.Value = 100;
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(13, 12);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.Size = new System.Drawing.Size(44, 17);
            this.BatteryCharge.TabIndex = 23;
            this.BatteryCharge.Value = 100;
            // 
            // BatteryNetworkTimer
            // 
            this.BatteryNetworkTimer.Interval = 1000;
            this.BatteryNetworkTimer.Tick += new System.EventHandler(this.BatteryNetworkTimer_Tick);
            // 
            // ATM8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(516, 544);
            this.ControlBox = false;
            this.Controls.Add(this.NetworkSignal);
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.ReentryPINLabel3);
            this.Controls.Add(this.NewPINLabel2);
            this.Controls.Add(this.OldPINLabel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmPINentryButton);
            this.Controls.Add(this.ConfirmNewPinEntry);
            this.Controls.Add(this.NewPinEntry);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.OLDPinEntry);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.ChangePINLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ATM8";
            this.Load += new System.EventHandler(this.ATM8_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ChangePINLabel;
        private MetroFramework.Controls.MetroButton AbortButton;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton NumDeleteAll;
        private MetroFramework.Controls.MetroButton NumBack;
        private MetroFramework.Controls.MetroButton Num3;
        private MetroFramework.Controls.MetroButton Num0;
        private MetroFramework.Controls.MetroButton Num2;
        private MetroFramework.Controls.MetroButton Num1;
        private MetroFramework.Controls.MetroButton Num6;
        private MetroFramework.Controls.MetroButton Num5;
        private MetroFramework.Controls.MetroButton Num4;
        private MetroFramework.Controls.MetroButton Num9;
        private MetroFramework.Controls.MetroButton Num8;
        private MetroFramework.Controls.MetroButton Num7;
        private System.Windows.Forms.TextBox OLDPinEntry;
        private System.Windows.Forms.TextBox NewPinEntry;
        private System.Windows.Forms.TextBox ConfirmNewPinEntry;
        private MetroFramework.Controls.MetroButton ConfirmPINentryButton;
        private MetroFramework.Controls.MetroButton CancelButton;
        private MetroFramework.Controls.MetroLabel OldPINLabel1;
        private MetroFramework.Controls.MetroLabel NewPINLabel2;
        private MetroFramework.Controls.MetroLabel ReentryPINLabel3;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
        private System.Windows.Forms.Timer BatteryNetworkTimer;
    }
}

