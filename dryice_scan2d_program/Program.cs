using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dryice_scan2d_program {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Process[] pname = Process.GetProcessesByName("dryice_scan2d_program");
            if (pname.Length == 2) {
                Application.Exit();
                return;
            }
            string ggf = File.ReadAllText("dryice_scan2d_progarm_form.txt");
            File.Delete("dryice_scan2d_progarm_form.txt");
            if (ggf == "scan") Application.Run(new Form1());
            else {
                Application.Run(new Show());
                Application.Run(new Form1());
            }
        }
    }
}
