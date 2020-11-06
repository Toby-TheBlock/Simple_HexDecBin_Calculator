using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexaCalculator
{
    static class Program
    { 
        private static Form1 mainForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainForm = new Form1();
            Application.Run(mainForm);
        }

        public static Form1 MainForm
        {
            get { return mainForm; }
        }
    }
}
