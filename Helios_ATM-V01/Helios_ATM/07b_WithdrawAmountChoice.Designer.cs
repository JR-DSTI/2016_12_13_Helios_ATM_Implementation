﻿

using System.Drawing;
using System.Windows.Forms;

namespace Helios_ATM
{
    partial class ATM7b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM7b));
            this.EnterAmountLabel = new System.Windows.Forms.Label();
            this.ConfirmPINentryButton = new MetroFramework.Controls.MetroButton();
            this.WithdrawAmountTextbox = new System.Windows.Forms.TextBox();
            this.CancelButtonButton = new MetroFramework.Controls.MetroButton();
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
            this.AbortButton = new MetroFramework.Controls.MetroButton();
            this.PesosLabel1 = new MetroFramework.Controls.MetroLabel();
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
            this.BatteryNetworkTimer = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnterAmountLabel
            // 
            this.EnterAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnterAmountLabel.AutoSize = true;
            this.EnterAmountLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EnterAmountLabel.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.EnterAmountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnterAmountLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterAmountLabel.Location = new System.Drawing.Point(59, 10);
            this.EnterAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterAmountLabel.Name = "EnterAmountLabel";
            this.EnterAmountLabel.Size = new System.Drawing.Size(293, 35);
            this.EnterAmountLabel.TabIndex = 4;
            this.EnterAmountLabel.Text = "Enter desired amount.";
            // 
            // ConfirmPINentryButton
            // 
            this.ConfirmPINentryButton.Location = new System.Drawing.Point(315, 353);
            this.ConfirmPINentryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmPINentryButton.Name = "ConfirmPINentryButton";
            this.ConfirmPINentryButton.Size = new System.Drawing.Size(55, 61);
            this.ConfirmPINentryButton.TabIndex = 7;
            this.ConfirmPINentryButton.Text = "Confirm";
            this.ConfirmPINentryButton.UseSelectable = true;
            this.ConfirmPINentryButton.Click += new System.EventHandler(this.ConfirmPINentry_Click_1);
            // 
            // WithdrawAmountTextbox
            // 
            this.WithdrawAmountTextbox.AcceptsReturn = true;
            this.WithdrawAmountTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawAmountTextbox.Location = new System.Drawing.Point(128, 51);
            this.WithdrawAmountTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WithdrawAmountTextbox.MaxLength = 8;
            this.WithdrawAmountTextbox.Name = "WithdrawAmountTextbox";
            this.WithdrawAmountTextbox.Size = new System.Drawing.Size(144, 35);
            this.WithdrawAmountTextbox.TabIndex = 8;
            this.WithdrawAmountTextbox.Text = "XX,XXX.XX";
            this.WithdrawAmountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WithdrawAmountTextbox.TextChanged += new System.EventHandler(this.PinEntry_TextChanged);
            this.WithdrawAmountTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PinEntry_KeyDown);
            // 
            // CancelButtonButton
            // 
            this.CancelButtonButton.Location = new System.Drawing.Point(17, 332);
            this.CancelButtonButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButtonButton.Name = "CancelButtonButton";
            this.CancelButtonButton.Size = new System.Drawing.Size(58, 24);
            this.CancelButtonButton.TabIndex = 9;
            this.CancelButtonButton.Text = "Cancel";
            this.CancelButtonButton.UseSelectable = true;
            this.CancelButtonButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(80, 94);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(231, 325);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // NumDeleteAll
            // 
            this.NumDeleteAll.DisplayFocus = true;
            this.NumDeleteAll.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.NumDeleteAll.Highlight = true;
            this.NumDeleteAll.Location = new System.Drawing.Point(12, 259);
            this.NumDeleteAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumDeleteAll.Name = "NumDeleteAll";
            this.NumDeleteAll.Size = new System.Drawing.Size(56, 61);
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
            this.NumBack.Location = new System.Drawing.Point(163, 259);
            this.NumBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumBack.Name = "NumBack";
            this.NumBack.Size = new System.Drawing.Size(56, 61);
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
            this.Num3.Location = new System.Drawing.Point(163, 174);
            this.Num3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(56, 61);
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
            this.Num0.Location = new System.Drawing.Point(88, 259);
            this.Num0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(56, 61);
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
            this.Num2.Location = new System.Drawing.Point(88, 174);
            this.Num2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(56, 61);
            this.Num2.TabIndex = 9;
            this.Num2.Text = "2";
            this.Num2.UseSelectable = true;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num1
            // 
            this.Num1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num1.Highlight = true;
            this.Num1.Location = new System.Drawing.Point(12, 174);
            this.Num1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(56, 61);
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
            this.Num6.Location = new System.Drawing.Point(163, 92);
            this.Num6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(56, 61);
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
            this.Num5.Location = new System.Drawing.Point(88, 92);
            this.Num5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(56, 61);
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
            this.Num4.Location = new System.Drawing.Point(12, 92);
            this.Num4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(56, 61);
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
            this.Num9.Location = new System.Drawing.Point(163, 11);
            this.Num9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(56, 61);
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
            this.Num8.Location = new System.Drawing.Point(88, 11);
            this.Num8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(56, 61);
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
            this.Num7.Location = new System.Drawing.Point(12, 11);
            this.Num7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(56, 61);
            this.Num7.TabIndex = 2;
            this.Num7.Text = "7";
            this.Num7.UseSelectable = true;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(17, 362);
            this.AbortButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(58, 55);
            this.AbortButton.TabIndex = 12;
            this.AbortButton.Text = "Abort and\r\neject card";
            this.AbortButton.UseSelectable = true;
            this.AbortButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // PesosLabel1
            // 
            this.PesosLabel1.AutoSize = true;
            this.PesosLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PesosLabel1.Location = new System.Drawing.Point(287, 60);
            this.PesosLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PesosLabel1.Name = "PesosLabel1";
            this.PesosLabel1.Size = new System.Drawing.Size(54, 25);
            this.PesosLabel1.TabIndex = 13;
            this.PesosLabel1.Text = "Pesos";
            // 
            // NetworkSignal
            // 
            this.NetworkSignal.Location = new System.Drawing.Point(361, 10);
            this.NetworkSignal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NetworkSignal.Maximum = 100;
            this.NetworkSignal.Name = "NetworkSignal";
            this.NetworkSignal.Size = new System.Drawing.Size(20, 24);
            this.NetworkSignal.TabIndex = 15;
            this.NetworkSignal.UseSelectable = true;
            this.NetworkSignal.Value = 100;
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(6, 10);
            this.BatteryCharge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.Size = new System.Drawing.Size(33, 14);
            this.BatteryCharge.TabIndex = 14;
            this.BatteryCharge.Value = 100;
            // 
            // BatteryNetworkTimer
            // 
            this.BatteryNetworkTimer.Interval = 1000;
            this.BatteryNetworkTimer.Tick += new System.EventHandler(this.BatteryNetworkTimer_Tick);
            // 
            // ATM7b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(387, 442);
            this.ControlBox = false;
            this.Controls.Add(this.NetworkSignal);
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.PesosLabel1);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.CancelButtonButton);
            this.Controls.Add(this.WithdrawAmountTextbox);
            this.Controls.Add(this.ConfirmPINentryButton);
            this.Controls.Add(this.EnterAmountLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ATM7b";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Load += new System.EventHandler(this.ATM7b_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        /// <summary>
        /// A textbox that supports a watermak hint.
        /// </summary>
        public class WatermarkTextBox : TextBox
        {
            /// <summary>
            /// The text that will be presented as the watermak hint
            /// </summary>
            private string _watermarkText = "Type here";
            /// <summary>
            /// Gets or Sets the text that will be presented as the watermak hint
            /// </summary>
            public string WatermarkText
            {
                get { return _watermarkText; }
                set { _watermarkText = value; }
            }

            /// <summary>
            /// Whether watermark effect is enabled or not
            /// </summary>
            private bool _watermarkActive = true;
            /// <summary>
            /// Gets or Sets whether watermark effect is enabled or not
            /// </summary>
            public bool WatermarkActive
            {
                get { return _watermarkActive; }
                set { _watermarkActive = value; }
            }

            /// <summary>
            /// Create a new TextBox that supports watermak hint
            /// </summary>
            public WatermarkTextBox()
            {
                this._watermarkActive = true;
                this.Text = _watermarkText;
                this.ForeColor = Color.Gray;

                GotFocus += (source, e) =>
                {
                    RemoveWatermak();
                };

                LostFocus += (source, e) =>
                {
                    ApplyWatermark();
                };

            }

            /// <summary>
            /// Remove watermark from the textbox
            /// </summary>
            public void RemoveWatermak()
            {
                if (this._watermarkActive)
                {
                    this._watermarkActive = false;
                    this.Text = "";
                    this.ForeColor = Color.Black;
                }
            }

            /// <summary>
            /// Applywatermak immediately
            /// </summary>
            public void ApplyWatermark()
            {
                if (!this._watermarkActive && string.IsNullOrEmpty(this.Text)
                    || ForeColor == Color.Gray)
                {
                    this._watermarkActive = true;
                    this.Text = _watermarkText;
                    this.ForeColor = Color.Gray;
                }
            }

            /// <summary>
            /// Apply watermak to the textbox. 
            /// </summary>
            /// <param name="newText">Text to apply</param>
            public void ApplyWatermark(string newText)
            {
                WatermarkText = newText;
                ApplyWatermark();
            }

        }

        #endregion
        private System.Windows.Forms.Label EnterAmountLabel;
        private System.Windows.Forms.TextBox WithdrawAmountTextbox;
        private MetroFramework.Controls.MetroButton CancelButtonButton;
        private MetroFramework.Controls.MetroButton ConfirmPINentryButton;
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
        private MetroFramework.Controls.MetroButton AbortButton;
        private MetroFramework.Controls.MetroLabel PesosLabel1;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
        private Timer BatteryNetworkTimer;
    }


}

