using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NedospasovaAE.Sprint7.Project.V4.Lib;

namespace Tyuiu.NedospasovaAE.Sprint7.Project.V4
{
    static class Program
    {
        public static FormMain_NAE formMain;
        public static FormAddEdit_NAE formAddEdit;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BD_NAE.LoadFromCsvFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain_NAE();
            formAddEdit = new FormAddEdit_NAE();
            Application.Run(formMain);
        }
    }
}
