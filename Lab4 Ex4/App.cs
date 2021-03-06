﻿using Lab4_Ex4.Domain;
using Lab4_Ex4.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Ex4
{
    static class App
    {
        /// The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Repository repository = new Repository();
         
            Service service = new Service(repository);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainGUI(service));
        }
    }
}