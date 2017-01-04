using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MetroFramework;
using System.Net.NetworkInformation;


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

        public static String useCase;
 
    }

    // //static class which holds the public battery charge properties, functions for decreasing
    public class battery

    {
        public static int decrement = 1;
        public static int charge = 100;
        static int iCountBattery = 0;

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
                    iCountBattery += 1;
                    if (iCountBattery == 1) { BatteryCharge.Value = 100; }
                    //set the Battery Progressbar to current charge: 
                    //12h to decrease battery equals 12h×60min×60s=43,200 seconds
                    //the timer ticks every second
                    if (iCountBattery % 432 ==0) //432 since the progress bar has value 100; total battery time is 43,200 seconds => 43,200 seconds/100=432
                    {
                        BatteryCharge.Value -= decrement;
                        //MessageBox.Show("stop and change"); 
                        //update new battery value
                        charge = BatteryCharge.Value;
                    }
                    
                }
                else
                {
                    AutoClosingMessageBox.Show("The ATM is running out of power. Disconnecting... \nATM is down for maintenance due to lack of energy supply", "Low energy", 1500, Form.ActiveForm);
                    //exit the environment
                    Environment.Exit(0);
                }
            }

            //set the Battery Progressbar to current charge:
            //BatteryCharge.Value = charge;


        }
    }

    public class networkConnection
    {

        public static double Pinger(string host, int echoNum)
        {

            long totalTime = 0;
            int timeOut = 120;
            for (int i = 0; i < echoNum; i++)
            {
                Ping pingSender = new Ping();
                try
                {
                    PingReply r = pingSender.Send(host, timeOut);
                    if (r.Status == IPStatus.Success)
                    {
                        totalTime += r.RoundtripTime;
                    }

                }
                catch(Exception ex)
                {
                    AutoClosingMessageBox.Show("Problem. \nError message: " + ex.Message, "ERROR", 2000, Parent: Form.ActiveForm);
                    totalTime = 0;
                    AutoClosingMessageBox.Show("Hardware problems with the ATM. \nATM is down for maintenance due to lack of cash", "Error info", 1000, Parent: Form.ActiveForm);

                    ////cancel to initial form, maybe not too necessary here
                    //AutoClosingMessageBox.Show("Returning to initial screen.", "Info", 1000, Parent: Form.ActiveForm);
                    //Form ATM1 = new ATM1(); // Instantiate a Form object.
                    //ATM1.Show(); //show the new Form
                    //Form.ActiveForm.Visible = false;  //Hide the old form

                    //Form.ActiveForm.log(false);
                    //Log current operation:
                    s3log.logOperation(null,"No or bad network connection. Logging is delayed here. Not sure when this log will arrive!");

                    //exit the environment
                    Environment.Exit(0);

                    return (totalTime / echoNum);

                }

            }
            return (totalTime / echoNum);
        }

        public static bool networkConnectionOK(MetroFramework.Controls.MetroProgressSpinner NetworkSignal)
        {
            //iff the usecase bad network connection was chosen:
            if (useCaseVariables.bCheckBoxNetworkConnectionUnstable)
            { 
                //MetroFramework.MetroMessageBox.Show(this, (Pinger("stackoverflow.com", 4)).ToString());
                if (Pinger("stackoverflow.com", 5) > 100)
                {
                    MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "The connection is lost"); // this = current form        
                    AutoClosingMessageBox.Show("Hardware problems with the ATM. \nATM is down for maintenance due to lack of cash", "Error info", 1000, Parent: Form.ActiveForm);
                    //exit the environment
                    Environment.Exit(0);

                    return false;
                }
                else
                {
                    NetworkSignal.Value =Convert.ToInt32(Pinger("stackoverflow.com", 5));
                    return true;

                }
            }
            else
            {
                return true;
            }
        }
    }
}
