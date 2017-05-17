using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static class Program
    {
        public static Login_Form first;
        public static Form second;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            first = new Login_Form();
        //    second = new Main_form();
            Application.Run(first);
         //   Application.Run(second);
        }
    }
}
