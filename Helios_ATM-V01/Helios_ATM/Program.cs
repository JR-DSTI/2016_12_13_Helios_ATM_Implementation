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
            Application.Run(new ATM1());
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
            // MessageBox.Show(text, caption);
            
            //Parent=new System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
            MetroMessageBox.Show(Parent, text, caption);
        }// System.Windows.Forms.IWin32Window,

        public static void Show(string text, string caption, int timeout, System.Windows.Forms.IWin32Window Parent)
        {
            new AutoClosingMessageBox(text, caption, timeout, Parent);
            //await Task.Delay(timeout); //async
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

    //public class Variables
    //{
    //    public static string strLog;
    //}
}
