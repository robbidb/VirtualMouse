using System;
using System.Windows.Forms;

namespace VirtualMouse
{
    static class Program
    {
        /// <summary>
        /// Start
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VirtualMouse.Views.frmMain());
        }
    }
}
