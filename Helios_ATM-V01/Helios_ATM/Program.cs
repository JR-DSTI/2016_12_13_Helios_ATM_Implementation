using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MetroFramework;

namespace Helios_ATM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Variables.strLog = "";
            Application.Run(new ATM0());
        }
        
    }

    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        string _text;

         AutoClosingMessageBox(string text, string caption, int timeout, System.Windows.Forms.IWin32Window Parent)
        {
            _text = text;
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            
            //Parent=new System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
            MetroMessageBox.Show(Parent, text, caption);
        }// System.Windows.Forms.IWin32Window,

        public static void Show(string text, string caption, int timeout, System.Windows.Forms.IWin32Window Parent)
        {
            new AutoClosingMessageBox(text, caption, timeout, Parent);
        }

        void OnTimerElapsed(object state)
        {
            //IntPtr mbWnd =FindWindowByCaption(IntPtr.Zero, _caption);
            IntPtr mbWnd = FindWindow(null, "");
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        
        }

    //storing all use case variables
    public class useCaseVariables
    {
        public static string strNotificationAddress;

        public static bool bCheckBoxPINEntriesExhausted;
        public static bool bCheckBoxNetworkConnectionUnstable;
        public static bool bCheckBoxPowerSourceBattery;
        public static bool bCheckBoxZeroCash;
    }

    // //static class which holds the public battery charge properties, functions for decreasing
    public class battery

    {
        public static int decrement = 1;
        public static int charge = 100;
        public static int decr()
        {
            return 2;
        }



        public static void discharge(MetroFramework.Controls.MetroProgressBar BatteryCharge)
        {
            //iff the usecase battery source was chosen:

            if (useCaseVariables.bCheckBoxPowerSourceBattery)
            {
                if (charge > 0)
                {
                    BatteryCharge.Value -= decrement;
                    charge = BatteryCharge.Value;
                }
                else
                {
                    AutoClosingMessageBox.Show("The ATM is running out of power. Disconnecting...", "Low energy", 1500, Form.ActiveForm);
                    //charge = 100;
                    Environment.Exit(0);
                }
            }
           
           
        }
    }
}
