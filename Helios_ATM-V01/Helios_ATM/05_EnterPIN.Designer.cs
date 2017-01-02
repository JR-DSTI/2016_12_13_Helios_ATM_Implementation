

using System.Drawing;
using System.Windows.Forms;

namespace Helios_ATM
{
    partial class ATM5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM5));
            this.EnterPINLabel1 = new System.Windows.Forms.Label();
            this.ConfirmPINentryButton = new MetroFramework.Controls.MetroButton();
            this.PinEntry = new System.Windows.Forms.TextBox();
            this.CancelButton = new MetroFramework.Controls.MetroButton();
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
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
            this.BatteryNetworkTimer = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnterPINLabel1
            // 
            this.EnterPINLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnterPINLabel1.AutoSize = true;
            this.EnterPINLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EnterPINLabel1.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.EnterPINLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnterPINLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPINLabel1.Location = new System.Drawing.Point(63, 9);
            this.EnterPINLabel1.Name = "EnterPINLabel1";
            this.EnterPINLabel1.Size = new System.Drawing.Size(358, 42);
            this.EnterPINLabel1.TabIndex = 4;
            this.EnterPINLabel1.Text = "Please enter your PIN.";
            // 
            // ConfirmPINentryButton
            // 
            this.ConfirmPINentryButton.Location = new System.Drawing.Point(420, 435);
            this.ConfirmPINentryButton.Name = "ConfirmPINentryButton";
            this.ConfirmPINentryButton.Size = new System.Drawing.Size(73, 75);
            this.ConfirmPINentryButton.TabIndex = 7;
            this.ConfirmPINentryButton.Text = "Confirm";
            this.ConfirmPINentryButton.UseSelectable = true;
            this.ConfirmPINentryButton.Click += new System.EventHandler(this.ConfirmPINentry_Click_1);
            // 
            // PinEntry
            // 
            this.PinEntry.AcceptsReturn = true;
            this.PinEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinEntry.Location = new System.Drawing.Point(148, 57);
            this.PinEntry.MaxLength = 8;
            this.PinEntry.Name = "PinEntry";
            this.PinEntry.PasswordChar = '*';
            this.PinEntry.Size = new System.Drawing.Size(200, 53);
            this.PinEntry.TabIndex = 8;
            this.PinEntry.Text = "****";
            this.PinEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PinEntry.TextChanged += new System.EventHandler(this.PinEntry_TextChanged);
            this.PinEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PinEntry_KeyDown);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(23, 409);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(77, 30);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseSelectable = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            this.metroPanel1.Location = new System.Drawing.Point(106, 116);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(308, 400);
            this.metroPanel1.TabIndex = 10;
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
            this.NetworkSignal.Location = new System.Drawing.Point(476, 9);
            this.NetworkSignal.Maximum = 100;
            this.NetworkSignal.Name = "NetworkSignal";
            this.NetworkSignal.Size = new System.Drawing.Size(27, 29);
            this.NetworkSignal.TabIndex = 14;
            this.NetworkSignal.UseSelectable = true;
            this.NetworkSignal.Value = 100;
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.Location = new System.Drawing.Point(9, 9);
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
            // ATM5
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
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PinEntry);
            this.Controls.Add(this.ConfirmPINentryButton);
            this.Controls.Add(this.EnterPINLabel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ATM5";
            this.Load += new System.EventHandler(this.ATM5_Load);
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
        private System.Windows.Forms.Label EnterPINLabel1;
        private System.Windows.Forms.TextBox PinEntry;
        private new MetroFramework.Controls.MetroButton CancelButton;
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
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
        private Timer BatteryNetworkTimer;
    }


}

