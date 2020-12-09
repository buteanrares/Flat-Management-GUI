using Lab4_Ex4.Domain;
using Lab4_Ex4.GUI;
using Lab4_Ex4.Validator;
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
            ModelValidator modelValidator = new ModelValidator();

            Repository repository = new Repository("C:\\Users\\butea\\source\\repos\\Lab4 Ex4\\Lab4 Ex4\\Database");
            repository.loadFromFile();
         
            Service service = new Service(repository,modelValidator);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainGUI(service));
        }
    }
}