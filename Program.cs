using System;
using System.Windows.Forms;

namespace GPACalculator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // ต้องตรงกับชื่อฟอร์มของคุณ
        }
    }
}
