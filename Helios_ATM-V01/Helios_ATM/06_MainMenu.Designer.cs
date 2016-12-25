

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM6));
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmMenuSelection = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Num3 = new MetroFramework.Controls.MetroButton();
            this.Num2 = new MetroFramework.Controls.MetroButton();
            this.Num1 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.NetworkSignal = new MetroFramework.Controls.MetroProgressSpinner();
            this.BatteryCharge = new MetroFramework.Controls.MetroProgressBar();
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
            // ConfirmMenuSelection
            // 
            this.ConfirmMenuSelection.Location = new System.Drawing.Point(420, 435);
            this.ConfirmMenuSelection.Name = "ConfirmMenuSelection";
            this.ConfirmMenuSelection.Size = new System.Drawing.Size(73, 75);
            this.ConfirmMenuSelection.TabIndex = 7;
            this.ConfirmMenuSelection.Text = "Confirm";
            this.ConfirmMenuSelection.UseSelectable = true;
            this.ConfirmMenuSelection.Visible = false;
            this.ConfirmMenuSelection.Click += new System.EventHandler(this.ConfirmPINentry_Click_1);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.Num3);
            this.metroPanel1.Controls.Add(this.Num2);
            this.metroPanel1.Controls.Add(this.Num1);
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
            // Num3
            // 
            this.Num3.DisplayFocus = true;
            this.Num3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num3.Highlight = true;
            this.Num3.Location = new System.Drawing.Point(22, 221);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(262, 75);
            this.Num3.TabIndex = 10;
            this.Num3.Text = "3: Balance Enquiry";
            this.Num3.UseSelectable = true;
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Num2
            // 
            this.Num2.DisplayFocus = true;
            this.Num2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num2.Highlight = true;
            this.Num2.Location = new System.Drawing.Point(22, 131);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(262, 75);
            this.Num2.TabIndex = 9;
            this.Num2.Text = "2: Change PIN       ";
            this.Num2.UseSelectable = true;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num1
            // 
            this.Num1.DisplayFocus = true;
            this.Num1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Num1.Highlight = true;
            this.Num1.Location = new System.Drawing.Point(22, 38);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(262, 75);
            this.Num1.TabIndex = 8;
            this.Num1.Text = "1:  Withdraw Cash";
            this.Num1.UseSelectable = true;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 445);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(77, 68);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Abort and\r\neject card";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
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
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.ConfirmMenuSelection);
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
        private MetroFramework.Controls.MetroButton ConfirmMenuSelection;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton Num3;
        private MetroFramework.Controls.MetroButton Num2;
        private MetroFramework.Controls.MetroButton Num1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroProgressSpinner NetworkSignal;
        private MetroFramework.Controls.MetroProgressBar BatteryCharge;
    }


}

