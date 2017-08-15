﻿using Furloader.loginPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furloader
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
            WorkSheduler worker = new WorkSheduler();
            Application.Run(new LoginFormFA(worker, "Furaffinity"));
            
        }
    }
}
