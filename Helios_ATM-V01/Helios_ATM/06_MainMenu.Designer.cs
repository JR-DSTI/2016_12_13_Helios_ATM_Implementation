

using System.Drawing;
using System.Windows.Forms;

namespace Helios_ATM
{
    partial class ATM6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM6));
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmMenuSelectionButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.BalanceEnquiryButton = new MetroFramework.Controls.MetroButton();
            this.ChangePINButton = new MetroFramework.Controls.MetroButton();
            this.WithdrawCashButton = new MetroFramework.Controls.MetroButton();
            this.AbortButton = new MetroFramework.Controls.MetroButton();
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
            this.BatteryNetworkTimer = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(153, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main menu";
            // 
            // ConfirmMenuSelectionButton
            // 
            this.ConfirmMenuSelectionButton.Location = new System.Drawing.Point(420, 435);
            this.ConfirmMenuSelectionButton.Name = "ConfirmMenuSelectionButton";
            this.ConfirmMenuSelectionButton.Size = new System.Drawing.Size(73, 75);
            this.ConfirmMenuSelectionButton.TabIndex = 7;
            this.ConfirmMenuSelectionButton.Text = "Confirm";
            this.ConfirmMenuSelectionButton.UseSelectable = true;
            this.ConfirmMenuSelectionButton.Visible = false;
            this.ConfirmMenuSelectionButton.Click += new System.EventHandler(this.ConfirmPINentry_Click_1);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.BalanceEnquiryButton);
            this.metroPanel1.Controls.Add(this.ChangePINButton);
            this.metroPanel1.Controls.Add(this.WithdrawCashButton);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(106, 116);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(308, 310);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // BalanceEnquiryButton
            // 
            this.BalanceEnquiryButton.DisplayFocus = true;
            this.BalanceEnquiryButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BalanceEnquiryButton.Highlight = true;
            this.BalanceEnquiryButton.Location = new System.Drawing.Point(22, 221);
            this.BalanceEnquiryButton.Name = "BalanceEnquiryButton";
            this.BalanceEnquiryButton.Size = new System.Drawing.Size(262, 75);
            this.BalanceEnquiryButton.TabIndex = 10;
            this.BalanceEnquiryButton.Text = "3: Balance Enquiry";
            this.BalanceEnquiryButton.UseSelectable = true;
            this.BalanceEnquiryButton.Click += new System.EventHandler(this.Num3_Click);
            // 
            // ChangePINButton
            // 
            this.ChangePINButton.DisplayFocus = true;
            this.ChangePINButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ChangePINButton.Highlight = true;
            this.ChangePINButton.Location = new System.Drawing.Point(22, 131);
            this.ChangePINButton.Name = "ChangePINButton";
            this.ChangePINButton.Size = new System.Drawing.Size(262, 75);
            this.ChangePINButton.TabIndex = 9;
            this.ChangePINButton.Text = "2: Change PIN       ";
            this.ChangePINButton.UseSelectable = true;
            this.ChangePINButton.Click += new System.EventHandler(this.Num2_Click);
            // 
            // WithdrawCashButton
            // 
            this.WithdrawCashButton.DisplayFocus = true;
            this.WithdrawCashButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.WithdrawCashButton.Highlight = true;
            this.WithdrawCashButton.Location = new System.Drawing.Point(22, 38);
            this.WithdrawCashButton.Name = "WithdrawCashButton";
            this.WithdrawCashButton.Size = new System.Drawing.Size(262, 75);
            this.WithdrawCashButton.TabIndex = 8;
            this.WithdrawCashButton.Text = "1:  Withdraw Cash";
            this.WithdrawCashButton.UseSelectable = true;
            this.WithdrawCashButton.Click += new System.EventHandler(this.Num1_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(23, 445);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(77, 68);
            this.AbortButton.TabIndex = 12;
            this.AbortButton.Text = "Abort and\r\neject card";
            this.AbortButton.UseSelectable = true;
            this.AbortButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // NetworkSignal
            // 
            this.NetworkSignal.Location = new System.Drawing.Point(480, 12);
            this.NetworkSignal.Maximum = 100;
            this.NetworkSignal.Name = "NetworkSignal";
            this.NetworkSignal.Size = new System.Drawing.Size(27, 29);
            this.NetworkSignal.TabIndex = 14;
            this.NetworkSignal.UseSelectable = true;
            this.NetworkSignal.Value = 100;
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(13, 12);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.Size = new System.Drawing.Size(44, 17);
            this.BatteryCharge.TabIndex = 13;
            this.BatteryCharge.Value = 100;
            // 
            // BatteryNetworkTimer
            // 
            this.BatteryNetworkTimer.Interval = 1000;
            this.BatteryNetworkTimer.Tick += new System.EventHandler(this.BatteryNetworkTimer_Tick);
            // 
            // ATM6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(516, 544);
            this.ControlBox = false;
            this.Controls.Add(this.NetworkSignal);
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.ConfirmMenuSelectionButton);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ATM6";
            this.Load += new System.EventHandler(this.ATM6_Load);
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
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton ConfirmMenuSelectionButton;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton BalanceEnquiryButton;
        private MetroFramework.Controls.MetroButton ChangePINButton;
        private MetroFramework.Controls.MetroButton WithdrawCashButton;
        private MetroFramework.Controls.MetroButton AbortButton;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
        private Timer BatteryNetworkTimer;
    }


}

